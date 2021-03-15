using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Threading;
using System.Net.Sockets;
using System.IO;

namespace PantallaChat
{
    public partial class Form1 : Form
    {
        static private NetworkStream stream;
        static private StreamWriter streamW;
        static private StreamReader streamR;
        static private TcpClient cliente = new TcpClient();
        static private string nick = "unknown";

        private delegate void DaddItem(String s);

        private void AddItem(String s)
        {
            LBX_Chat.Items.Add(s);
        }
        public Form1()
        {
            InitializeComponent();
        }

        void Listen()
        {
            while (cliente.Connected)
            {
                try
                {
                    this.Invoke(new DaddItem(AddItem), streamR.ReadLine());
                }
                catch
                {
                    MessageBox.Show("No se a podido conectar con el servidor.");
                    Application.Exit();
;                }
            }
        }

        void Conectar()
        {
            try
            {
                cliente.Connect("127.0.0.1", 8000);
                if (cliente.Connected)
                {
                    Thread t = new Thread(Listen);

                    stream = cliente.GetStream();
                    streamW = new StreamWriter(stream);
                    streamR = new StreamReader(stream);

                    streamW.WriteLine(nick);
                    streamW.Flush();

                    t.Start();
                }
                else
                {
                    MessageBox.Show("Servidor no disponible.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Servidor no disponible.");
                Application.Exit();
            }
        }

        private void button1_Click(object sender, EventArgs e) {   /* Función creada por accidente */    }

        private void BTN_Conectar_Click(object sender, EventArgs e)
        {
            nick = TBX_Nick.Text;
            Conectar();
        }

        private void BTN_Enviar_Click(object sender, EventArgs e)
        {
            streamW.WriteLine(TBX_Mensaje.Text);
            streamW.Flush();
            TBX_Mensaje.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        { /* Creada por Accidente */ }

        private void TBX_Mensaje_TextChanged(object sender, EventArgs e)
        {/* Creada por Accidente */}

        private void LBL_Usuario_Click(object sender, EventArgs e)
        {/* Creada por Accidente */}
    }
}
