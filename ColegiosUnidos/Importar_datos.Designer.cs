namespace ColegiosUnidos
{
    partial class Importar_datos
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
            this.BTN_Cargar = new System.Windows.Forms.Button();
            this.L_cargar = new System.Windows.Forms.Label();
            this.OFD_TablaDatos = new System.Windows.Forms.DataGridView();
            this.BTN_BuscarArchivo = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.BTN_regresar1 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.BTN_regresar2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.OFD_TablaDatos)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // BTN_Cargar
            // 
            this.BTN_Cargar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Cargar.Location = new System.Drawing.Point(84, 344);
            this.BTN_Cargar.Name = "BTN_Cargar";
            this.BTN_Cargar.Size = new System.Drawing.Size(115, 36);
            this.BTN_Cargar.TabIndex = 7;
            this.BTN_Cargar.Text = "Cargar";
            this.BTN_Cargar.UseVisualStyleBackColor = true;
            this.BTN_Cargar.Click += new System.EventHandler(this.button2_Click);
            // 
            // L_cargar
            // 
            this.L_cargar.AutoSize = true;
            this.L_cargar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_cargar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.L_cargar.Location = new System.Drawing.Point(134, 11);
            this.L_cargar.Name = "L_cargar";
            this.L_cargar.Size = new System.Drawing.Size(261, 20);
            this.L_cargar.TabIndex = 6;
            this.L_cargar.Text = "¿Desea cargar el siguiente archivo?";
            // 
            // OFD_TablaDatos
            // 
            this.OFD_TablaDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OFD_TablaDatos.Location = new System.Drawing.Point(84, 34);
            this.OFD_TablaDatos.Name = "OFD_TablaDatos";
            this.OFD_TablaDatos.Size = new System.Drawing.Size(526, 288);
            this.OFD_TablaDatos.TabIndex = 5;
            this.OFD_TablaDatos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.OFD_TablaDatos_CellContentClick);
            // 
            // BTN_BuscarArchivo
            // 
            this.BTN_BuscarArchivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_BuscarArchivo.Location = new System.Drawing.Point(495, 344);
            this.BTN_BuscarArchivo.Name = "BTN_BuscarArchivo";
            this.BTN_BuscarArchivo.Size = new System.Drawing.Size(115, 36);
            this.BTN_BuscarArchivo.TabIndex = 4;
            this.BTN_BuscarArchivo.Text = "Buscar archivo";
            this.BTN_BuscarArchivo.UseVisualStyleBackColor = true;
            this.BTN_BuscarArchivo.Click += new System.EventHandler(this.button1_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // BTN_regresar1
            // 
            this.BTN_regresar1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BTN_regresar1.BackColor = System.Drawing.Color.Transparent;
            this.BTN_regresar1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BTN_regresar1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BTN_regresar1.FlatAppearance.BorderSize = 0;
            this.BTN_regresar1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.BTN_regresar1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.BTN_regresar1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTN_regresar1.Location = new System.Drawing.Point(6, 11);
            this.BTN_regresar1.Name = "BTN_regresar1";
            this.BTN_regresar1.Size = new System.Drawing.Size(65, 54);
            this.BTN_regresar1.TabIndex = 8;
            this.BTN_regresar1.UseVisualStyleBackColor = false;
            this.BTN_regresar1.Click += new System.EventHandler(this.BTN_regresar_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(659, 418);
            this.tabControl1.TabIndex = 9;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Black;
            this.tabPage1.Controls.Add(this.OFD_TablaDatos);
            this.tabPage1.Controls.Add(this.BTN_regresar1);
            this.tabPage1.Controls.Add(this.BTN_Cargar);
            this.tabPage1.Controls.Add(this.BTN_BuscarArchivo);
            this.tabPage1.Controls.Add(this.L_cargar);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(0);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(651, 392);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Importar";
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Black;
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.button3);
            this.tabPage2.Controls.Add(this.BTN_regresar2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(651, 392);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Exportar";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(163, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(345, 31);
            this.label1.TabIndex = 12;
            this.label1.Text = "¿Desea exportar los datos?";
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(281, 216);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(115, 36);
            this.button3.TabIndex = 11;
            this.button3.Text = "Exportar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // BTN_regresar2
            // 
            this.BTN_regresar2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BTN_regresar2.BackColor = System.Drawing.Color.Transparent;
            this.BTN_regresar2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BTN_regresar2.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BTN_regresar2.FlatAppearance.BorderSize = 0;
            this.BTN_regresar2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.BTN_regresar2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.BTN_regresar2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTN_regresar2.Location = new System.Drawing.Point(5, 12);
            this.BTN_regresar2.Name = "BTN_regresar2";
            this.BTN_regresar2.Size = new System.Drawing.Size(65, 54);
            this.BTN_regresar2.TabIndex = 9;
            this.BTN_regresar2.UseVisualStyleBackColor = false;
            this.BTN_regresar2.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Importar_datos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(659, 418);
            this.Controls.Add(this.tabControl1);
            this.Name = "Importar_datos";
            this.Text = "Importar_datos";
            this.Load += new System.EventHandler(this.Importar_datos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.OFD_TablaDatos)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BTN_Cargar;
        private System.Windows.Forms.Label L_cargar;
        private System.Windows.Forms.DataGridView OFD_TablaDatos;
        private System.Windows.Forms.Button BTN_BuscarArchivo;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button BTN_regresar1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button BTN_regresar2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
    }
}