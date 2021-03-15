
namespace PantallaChat
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.BTN_Enviar = new System.Windows.Forms.Button();
            this.TBX_Mensaje = new System.Windows.Forms.TextBox();
            this.LBX_Chat = new System.Windows.Forms.ListBox();
            this.LBL_Usuario = new System.Windows.Forms.Label();
            this.TBX_Nick = new System.Windows.Forms.TextBox();
            this.BTN_Conectar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BTN_Enviar
            // 
            this.BTN_Enviar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Enviar.Location = new System.Drawing.Point(638, 436);
            this.BTN_Enviar.Name = "BTN_Enviar";
            this.BTN_Enviar.Size = new System.Drawing.Size(97, 30);
            this.BTN_Enviar.TabIndex = 0;
            this.BTN_Enviar.Text = "Enviar";
            this.BTN_Enviar.UseVisualStyleBackColor = true;
            this.BTN_Enviar.Click += new System.EventHandler(this.BTN_Enviar_Click);
            // 
            // TBX_Mensaje
            // 
            this.TBX_Mensaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBX_Mensaje.Location = new System.Drawing.Point(42, 438);
            this.TBX_Mensaje.Multiline = true;
            this.TBX_Mensaje.Name = "TBX_Mensaje";
            this.TBX_Mensaje.Size = new System.Drawing.Size(561, 30);
            this.TBX_Mensaje.TabIndex = 1;
            this.TBX_Mensaje.TextChanged += new System.EventHandler(this.TBX_Mensaje_TextChanged);
            // 
            // LBX_Chat
            // 
            this.LBX_Chat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBX_Chat.FormattingEnabled = true;
            this.LBX_Chat.ItemHeight = 20;
            this.LBX_Chat.Location = new System.Drawing.Point(42, 93);
            this.LBX_Chat.Name = "LBX_Chat";
            this.LBX_Chat.Size = new System.Drawing.Size(693, 324);
            this.LBX_Chat.TabIndex = 2;
            // 
            // LBL_Usuario
            // 
            this.LBL_Usuario.AutoSize = true;
            this.LBL_Usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Usuario.Location = new System.Drawing.Point(151, 42);
            this.LBL_Usuario.Name = "LBL_Usuario";
            this.LBL_Usuario.Size = new System.Drawing.Size(72, 20);
            this.LBL_Usuario.TabIndex = 3;
            this.LBL_Usuario.Text = "Usuario:";
            this.LBL_Usuario.Click += new System.EventHandler(this.LBL_Usuario_Click);
            // 
            // TBX_Nick
            // 
            this.TBX_Nick.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBX_Nick.Location = new System.Drawing.Point(253, 37);
            this.TBX_Nick.Multiline = true;
            this.TBX_Nick.Name = "TBX_Nick";
            this.TBX_Nick.Size = new System.Drawing.Size(243, 31);
            this.TBX_Nick.TabIndex = 5;
            // 
            // BTN_Conectar
            // 
            this.BTN_Conectar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Conectar.Location = new System.Drawing.Point(528, 37);
            this.BTN_Conectar.Name = "BTN_Conectar";
            this.BTN_Conectar.Size = new System.Drawing.Size(102, 31);
            this.BTN_Conectar.TabIndex = 6;
            this.BTN_Conectar.Text = "Conectar";
            this.BTN_Conectar.UseVisualStyleBackColor = true;
            this.BTN_Conectar.Click += new System.EventHandler(this.BTN_Conectar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(782, 503);
            this.Controls.Add(this.BTN_Conectar);
            this.Controls.Add(this.TBX_Nick);
            this.Controls.Add(this.LBL_Usuario);
            this.Controls.Add(this.LBX_Chat);
            this.Controls.Add(this.TBX_Mensaje);
            this.Controls.Add(this.BTN_Enviar);
            this.MaximumSize = new System.Drawing.Size(800, 550);
            this.MinimumSize = new System.Drawing.Size(800, 550);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTN_Enviar;
        private System.Windows.Forms.TextBox TBX_Mensaje;
        private System.Windows.Forms.ListBox LBX_Chat;
        private System.Windows.Forms.Label LBL_Usuario;
        private System.Windows.Forms.TextBox TBX_Nick;
        private System.Windows.Forms.Button BTN_Conectar;
    }
}

