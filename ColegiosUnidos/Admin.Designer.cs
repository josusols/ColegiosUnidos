namespace ColegiosUnidos
{
    partial class Admin
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
            this.BTN_inModDatos = new System.Windows.Forms.Button();
            this.CMS_datos = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.TSMI_ingreso = new System.Windows.Forms.ToolStripMenuItem();
            this.Separador = new System.Windows.Forms.ToolStripSeparator();
            this.TSMI_modificacion = new System.Windows.Forms.ToolStripMenuItem();
            this.BTN_consultaInfo = new System.Windows.Forms.Button();
            this.BTN_exImDatos = new System.Windows.Forms.Button();
            this.BTN_regresar = new System.Windows.Forms.Button();
            this.BTN_confGeneral = new System.Windows.Forms.Button();
            this.PB_fondo = new System.Windows.Forms.PictureBox();
            this.CMS_datos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB_fondo)).BeginInit();
            this.SuspendLayout();
            // 
            // BTN_inModDatos
            // 
            this.BTN_inModDatos.BackColor = System.Drawing.Color.Black;
            this.BTN_inModDatos.ContextMenuStrip = this.CMS_datos;
            this.BTN_inModDatos.Enabled = false;
            this.BTN_inModDatos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTN_inModDatos.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_inModDatos.ForeColor = System.Drawing.Color.White;
            this.BTN_inModDatos.Location = new System.Drawing.Point(393, 47);
            this.BTN_inModDatos.Name = "BTN_inModDatos";
            this.BTN_inModDatos.Size = new System.Drawing.Size(115, 115);
            this.BTN_inModDatos.TabIndex = 4;
            this.BTN_inModDatos.Text = "Ingreso y Modificacion de Datos";
            this.BTN_inModDatos.UseVisualStyleBackColor = false;
            this.BTN_inModDatos.Click += new System.EventHandler(this.BTN_inModDatos_Click);
            // 
            // CMS_datos
            // 
            this.CMS_datos.BackColor = System.Drawing.Color.DimGray;
            this.CMS_datos.Font = new System.Drawing.Font("Elephant", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CMS_datos.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMI_ingreso,
            this.Separador,
            this.TSMI_modificacion});
            this.CMS_datos.Name = "CMS_datos";
            this.CMS_datos.Size = new System.Drawing.Size(154, 54);
            // 
            // TSMI_ingreso
            // 
            this.TSMI_ingreso.Image = global::ColegiosUnidos.Properties.Resources.ingreso;
            this.TSMI_ingreso.Name = "TSMI_ingreso";
            this.TSMI_ingreso.Size = new System.Drawing.Size(153, 22);
            this.TSMI_ingreso.Text = "Ingreso";
            this.TSMI_ingreso.Click += new System.EventHandler(this.TSMI_ingreso_Click);
            // 
            // Separador
            // 
            this.Separador.Name = "Separador";
            this.Separador.Size = new System.Drawing.Size(150, 6);
            // 
            // TSMI_modificacion
            // 
            this.TSMI_modificacion.Image = global::ColegiosUnidos.Properties.Resources.ingreso;
            this.TSMI_modificacion.Name = "TSMI_modificacion";
            this.TSMI_modificacion.Size = new System.Drawing.Size(153, 22);
            this.TSMI_modificacion.Text = "Modificacion";
            this.TSMI_modificacion.Click += new System.EventHandler(this.TSMI_modificacion_Click);
            // 
            // BTN_consultaInfo
            // 
            this.BTN_consultaInfo.BackColor = System.Drawing.Color.Black;
            this.BTN_consultaInfo.Enabled = false;
            this.BTN_consultaInfo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTN_consultaInfo.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_consultaInfo.ForeColor = System.Drawing.Color.White;
            this.BTN_consultaInfo.Location = new System.Drawing.Point(153, 185);
            this.BTN_consultaInfo.Name = "BTN_consultaInfo";
            this.BTN_consultaInfo.Size = new System.Drawing.Size(115, 115);
            this.BTN_consultaInfo.TabIndex = 3;
            this.BTN_consultaInfo.Text = "Consultas Ordenadas de la Informacion";
            this.BTN_consultaInfo.UseVisualStyleBackColor = false;
            this.BTN_consultaInfo.Click += new System.EventHandler(this.BTN_consultaInfo_Click);
            // 
            // BTN_exImDatos
            // 
            this.BTN_exImDatos.BackColor = System.Drawing.Color.Black;
            this.BTN_exImDatos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTN_exImDatos.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_exImDatos.ForeColor = System.Drawing.Color.White;
            this.BTN_exImDatos.Location = new System.Drawing.Point(393, 185);
            this.BTN_exImDatos.Name = "BTN_exImDatos";
            this.BTN_exImDatos.Size = new System.Drawing.Size(115, 115);
            this.BTN_exImDatos.TabIndex = 5;
            this.BTN_exImDatos.Text = "Exportar e Importar Datos";
            this.BTN_exImDatos.UseVisualStyleBackColor = false;
            this.BTN_exImDatos.Click += new System.EventHandler(this.BTN_exImDatos_Click);
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
            this.BTN_regresar.TabIndex = 1;
            this.BTN_regresar.UseVisualStyleBackColor = false;
            this.BTN_regresar.Click += new System.EventHandler(this.BTN_regresar_Click);
            // 
            // BTN_confGeneral
            // 
            this.BTN_confGeneral.BackColor = System.Drawing.Color.Black;
            this.BTN_confGeneral.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTN_confGeneral.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_confGeneral.ForeColor = System.Drawing.Color.White;
            this.BTN_confGeneral.Location = new System.Drawing.Point(153, 47);
            this.BTN_confGeneral.Name = "BTN_confGeneral";
            this.BTN_confGeneral.Size = new System.Drawing.Size(115, 115);
            this.BTN_confGeneral.TabIndex = 2;
            this.BTN_confGeneral.Text = "Configuracion General";
            this.BTN_confGeneral.UseVisualStyleBackColor = false;
            this.BTN_confGeneral.Click += new System.EventHandler(this.BTN_confGeneral_Click);
            // 
            // PB_fondo
            // 
            this.PB_fondo.Location = new System.Drawing.Point(29, 29);
            this.PB_fondo.Name = "PB_fondo";
            this.PB_fondo.Size = new System.Drawing.Size(504, 283);
            this.PB_fondo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PB_fondo.TabIndex = 6;
            this.PB_fondo.TabStop = false;
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(563, 384);
            this.Controls.Add(this.BTN_regresar);
            this.Controls.Add(this.BTN_exImDatos);
            this.Controls.Add(this.BTN_consultaInfo);
            this.Controls.Add(this.BTN_inModDatos);
            this.Controls.Add(this.BTN_confGeneral);
            this.Controls.Add(this.PB_fondo);
            this.ForeColor = System.Drawing.Color.Transparent;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.Admin_Load);
            this.VisibleChanged += new System.EventHandler(this.Admin_VisibleChanged);
            this.CMS_datos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PB_fondo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BTN_confGeneral;
        private System.Windows.Forms.Button BTN_inModDatos;
        private System.Windows.Forms.Button BTN_consultaInfo;
        private System.Windows.Forms.Button BTN_exImDatos;
        private System.Windows.Forms.Button BTN_regresar;
        private System.Windows.Forms.PictureBox PB_fondo;
        private System.Windows.Forms.ContextMenuStrip CMS_datos;
        private System.Windows.Forms.ToolStripMenuItem TSMI_ingreso;
        private System.Windows.Forms.ToolStripMenuItem TSMI_modificacion;
        private System.Windows.Forms.ToolStripSeparator Separador;
    }
}