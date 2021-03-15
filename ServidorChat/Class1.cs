using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Threading;
using System.Net.Sockets;
using System.IO;
using System.Net;

namespace ServidorChat
{
    class Servidor_Chat
	{
		private TcpListener server;
		private TcpClient client = new TcpClient();
		private IPEndPoint ipendpoint = new IPEndPoint(IPAddress.Any, 8000);
		private List<Connection> list = new List<Connection>();

		Connection con;

		private struct Connection
		{
			public NetworkStream stream;
			public StreamWriter streamW;
			public StreamReader streamR;
			public string nick;
		}
		public Servidor_Chat()
		{
			Inicio();
		}
		public void Inicio()
		{
			Console.WriteLine("Servidor activado.");
			server = new TcpListener(ipendpoint);
			server.Start();

			while (true)
			{
				client = server.AcceptTcpClient();

				con = new Connection();
				con.stream = client.GetStream();
				con.streamR = new StreamReader(con.stream);
				con.streamW = new StreamWriter(con.stream);

				con.nick = con.streamR.ReadLine();

				list.Add(con);
				Console.WriteLine(con.nick + " se a conectado");

				Thread t = new Thread(Escuchar_Conexion);
				t.Start();
			}
		}
		void Escuchar_Conexion()
		{
			Connection hcon = con;

			do
			{
				try
				{
					string tmp = hcon.streamR.ReadLine();
					Console.WriteLine(hcon.nick + ": " + tmp);
					foreach (Connection c in list)
					{
						try
						{
							c.streamW.WriteLine(hcon.nick + ": " + tmp);
							c.streamW.Flush();
						}
						catch
						{
							//No va a pasar nada aquí :V
						}
					}
				}
				catch
				{
					list.Remove(hcon);
					Console.WriteLine(con.nick + " se a desconectado.");
					break;
				}
			} while (true);
		}
	}
}
