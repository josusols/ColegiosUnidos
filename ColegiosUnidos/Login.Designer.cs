namespace ColegiosUnidos
{
    partial class Login
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
            this.components = new System.ComponentModel.Container();
            this.TB_contraseña = new System.Windows.Forms.TextBox();
            this.TB_usuario = new System.Windows.Forms.TextBox();
            this.Pulsaciones = new System.Windows.Forms.Timer(this.components);
            this.L_contraseña = new System.Windows.Forms.Label();
            this.L_usuario = new System.Windows.Forms.Label();
            this.PB_logo = new System.Windows.Forms.PictureBox();
            this.PB_fondo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PB_logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_fondo)).BeginInit();
            this.SuspendLayout();
            // 
            // TB_contraseña
            // 
            this.TB_contraseña.BackColor = System.Drawing.Color.DimGray;
            this.TB_contraseña.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TB_contraseña.Font = new System.Drawing.Font("High Tower Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_contraseña.ForeColor = System.Drawing.Color.White;
            this.TB_contraseña.Location = new System.Drawing.Point(88, 160);
            this.TB_contraseña.Name = "TB_contraseña";
            this.TB_contraseña.PasswordChar = '*';
            this.TB_contraseña.Size = new System.Drawing.Size(189, 19);
            this.TB_contraseña.TabIndex = 2;
            this.TB_contraseña.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Teclas);
            // 
            // TB_usuario
            // 
            this.TB_usuario.BackColor = System.Drawing.Color.DimGray;
            this.TB_usuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TB_usuario.Font = new System.Drawing.Font("High Tower Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_usuario.ForeColor = System.Drawing.Color.White;
            this.TB_usuario.Location = new System.Drawing.Point(88, 70);
            this.TB_usuario.Name = "TB_usuario";
            this.TB_usuario.Size = new System.Drawing.Size(189, 19);
            this.TB_usuario.TabIndex = 1;
            this.TB_usuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Teclas);
            // 
            // Pulsaciones
            // 
            this.Pulsaciones.Interval = 500;
            this.Pulsaciones.Tick += new System.EventHandler(this.Pulsaciones_Tick);
            // 
            // L_contraseña
            // 
            this.L_contraseña.AutoSize = true;
            this.L_contraseña.BackColor = System.Drawing.Color.Transparent;
            this.L_contraseña.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_contraseña.ForeColor = System.Drawing.Color.Aqua;
            this.L_contraseña.Location = new System.Drawing.Point(12, 99);
            this.L_contraseña.Name = "L_contraseña";
            this.L_contraseña.Size = new System.Drawing.Size(298, 58);
            this.L_contraseña.TabIndex = 0;
            this.L_contraseña.Text = "Contraseña";
            // 
            // L_usuario
            // 
            this.L_usuario.AutoSize = true;
            this.L_usuario.BackColor = System.Drawing.Color.Transparent;
            this.L_usuario.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_usuario.ForeColor = System.Drawing.Color.Aqua;
            this.L_usuario.Location = new System.Drawing.Point(12, 9);
            this.L_usuario.Name = "L_usuario";
            this.L_usuario.Size = new System.Drawing.Size(190, 58);
            this.L_usuario.TabIndex = 0;
            this.L_usuario.Text = "Usuario";
            // 
            // PB_logo
            // 
            this.PB_logo.BackColor = System.Drawing.Color.Transparent;
            this.PB_logo.Location = new System.Drawing.Point(307, 5);
            this.PB_logo.Name = "PB_logo";
            this.PB_logo.Size = new System.Drawing.Size(200, 200);
            this.PB_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.PB_logo.TabIndex = 4;
            this.PB_logo.TabStop = false;
            // 
            // PB_fondo
            // 
            this.PB_fondo.Location = new System.Drawing.Point(-1, -8);
            this.PB_fondo.Name = "PB_fondo";
            this.PB_fondo.Size = new System.Drawing.Size(508, 204);
            this.PB_fondo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PB_fondo.TabIndex = 35;
            this.PB_fondo.TabStop = false;
            this.PB_fondo.Click += new System.EventHandler(this.PB_fondo_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(506, 195);
            this.Controls.Add(this.PB_logo);
            this.Controls.Add(this.TB_contraseña);
            this.Controls.Add(this.L_contraseña);
            this.Controls.Add(this.L_usuario);
            this.Controls.Add(this.TB_usuario);
            this.Controls.Add(this.PB_fondo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Teclas);
            ((System.ComponentModel.ISupportInitialize)(this.PB_logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_fondo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TB_contraseña;
        private System.Windows.Forms.TextBox TB_usuario;
        private System.Windows.Forms.Timer Pulsaciones;
        private System.Windows.Forms.PictureBox PB_fondo;
        private System.Windows.Forms.Label L_contraseña;
        private System.Windows.Forms.Label L_usuario;
        private System.Windows.Forms.PictureBox PB_logo;
    }
}