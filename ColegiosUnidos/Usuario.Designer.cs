namespace ColegiosUnidos
{
    partial class Usuario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BTN_regresar = new System.Windows.Forms.Button();
            this.PB_fondo = new System.Windows.Forms.PictureBox();
            this.BTN_exImDatos = new System.Windows.Forms.Button();
            this.BTN_consultaInfo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PB_fondo)).BeginInit();
            this.SuspendLayout();
            // 
            // BTN_regresar
            // 
            this.BTN_regresar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BTN_regresar.BackColor = System.Drawing.Color.Transparent;
            this.BTN_regresar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BTN_regresar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BTN_regresar.FlatAppearance.BorderSize = 0;
            this.BTN_regresar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.BTN_regresar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.BTN_regresar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTN_regresar.Location = new System.Drawing.Point(41, 38);
            this.BTN_regresar.Name = "BTN_regresar";
            this.BTN_regresar.Size = new System.Drawing.Size(53, 54);
            this.BTN_regresar.TabIndex = 7;
            this.BTN_regresar.UseVisualStyleBackColor = false;
            this.BTN_regresar.Click += new System.EventHandler(this.BTN_regresar_Click);
            // 
            // PB_fondo
            // 
            this.PB_fondo.Location = new System.Drawing.Point(29, 29);
            this.PB_fondo.Name = "PB_fondo";
            this.PB_fondo.Size = new System.Drawing.Size(504, 283);
            this.PB_fondo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PB_fondo.TabIndex = 8;
            this.PB_fondo.TabStop = false;
            this.PB_fondo.Click += new System.EventHandler(this.PB_fondo_Click);
            // 
            // BTN_exImDatos
            // 
            this.BTN_exImDatos.BackColor = System.Drawing.Color.Black;
            this.BTN_exImDatos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTN_exImDatos.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_exImDatos.ForeColor = System.Drawing.Color.White;
            this.BTN_exImDatos.Location = new System.Drawing.Point(337, 111);
            this.BTN_exImDatos.Name = "BTN_exImDatos";
            this.BTN_exImDatos.Size = new System.Drawing.Size(115, 115);
            this.BTN_exImDatos.TabIndex = 10;
            this.BTN_exImDatos.Text = "Exportar e Importar Datos";
            this.BTN_exImDatos.UseVisualStyleBackColor = false;
            this.BTN_exImDatos.Click += new System.EventHandler(this.BTN_exImDatos_Click);
            // 
            // BTN_consultaInfo
            // 
            this.BTN_consultaInfo.BackColor = System.Drawing.Color.Black;
            this.BTN_consultaInfo.Enabled = false;
            this.BTN_consultaInfo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTN_consultaInfo.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_consultaInfo.ForeColor = System.Drawing.Color.White;
            this.BTN_consultaInfo.Location = new System.Drawing.Point(139, 111);
            this.BTN_consultaInfo.Name = "BTN_consultaInfo";
            this.BTN_consultaInfo.Size = new System.Drawing.Size(115, 115);
            this.BTN_consultaInfo.TabIndex = 9;
            this.BTN_consultaInfo.Text = "Consultas Ordenadas de la Informacion";
            this.BTN_consultaInfo.UseVisualStyleBackColor = false;
            this.BTN_consultaInfo.Click += new System.EventHandler(this.BTN_consultaInfo_Click);
            // 
            // Usuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(563, 384);
            this.Controls.Add(this.BTN_exImDatos);
            this.Controls.Add(this.BTN_consultaInfo);
            this.Controls.Add(this.BTN_regresar);
            this.Controls.Add(this.PB_fondo);
            this.ForeColor = System.Drawing.Color.Transparent;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Usuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Usuario";
            this.Load += new System.EventHandler(this.Usuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PB_fondo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BTN_regresar;
        private System.Windows.Forms.PictureBox PB_fondo;
        private System.Windows.Forms.Button BTN_exImDatos;
        private System.Windows.Forms.Button BTN_consultaInfo;
    }
}