namespace Port_manager.Formularios
{
    partial class frmInformeBuqueUsuario
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblBuques = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtgBuque = new System.Windows.Forms.DataGridView();
            this.serial_buque = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.capitan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.origen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha_ingreso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.capacidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCamcelar = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgBuque)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblBuques);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(962, 56);
            this.panel2.TabIndex = 2;
            // 
            // lblBuques
            // 
            this.lblBuques.AutoSize = true;
            this.lblBuques.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuques.ForeColor = System.Drawing.Color.White;
            this.lblBuques.Location = new System.Drawing.Point(323, 9);
            this.lblBuques.Name = "lblBuques";
            this.lblBuques.Size = new System.Drawing.Size(343, 29);
            this.lblBuques.TabIndex = 3;
            this.lblBuques.Text = "Información del Buque Usuario";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.panel1.Controls.Add(this.btnGuardar);
            this.panel1.Controls.Add(this.btnCamcelar);
            this.panel1.Controls.Add(this.dtgBuque);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(962, 450);
            this.panel1.TabIndex = 2;
            // 
            // dtgBuque
            // 
            this.dtgBuque.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(60)))));
            this.dtgBuque.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgBuque.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.serial_buque,
            this.capitan,
            this.empresa,
            this.origen,
            this.fecha_ingreso,
            this.capacidad});
            this.dtgBuque.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dtgBuque.Location = new System.Drawing.Point(15, 143);
            this.dtgBuque.Margin = new System.Windows.Forms.Padding(2);
            this.dtgBuque.Name = "dtgBuque";
            this.dtgBuque.RowHeadersWidth = 51;
            this.dtgBuque.RowTemplate.Height = 24;
            this.dtgBuque.Size = new System.Drawing.Size(929, 209);
            this.dtgBuque.TabIndex = 3;
            // 
            // serial_buque
            // 
            this.serial_buque.HeaderText = "Serial Buque";
            this.serial_buque.MinimumWidth = 6;
            this.serial_buque.Name = "serial_buque";
            this.serial_buque.Width = 150;
            // 
            // capitan
            // 
            this.capitan.HeaderText = "Capitan";
            this.capitan.MinimumWidth = 6;
            this.capitan.Name = "capitan";
            this.capitan.Width = 150;
            // 
            // empresa
            // 
            this.empresa.HeaderText = "Empresa";
            this.empresa.MinimumWidth = 6;
            this.empresa.Name = "empresa";
            this.empresa.Width = 180;
            // 
            // origen
            // 
            this.origen.HeaderText = "Origen";
            this.origen.MinimumWidth = 6;
            this.origen.Name = "origen";
            this.origen.Width = 150;
            // 
            // fecha_ingreso
            // 
            this.fecha_ingreso.HeaderText = "Fecha Ingreso";
            this.fecha_ingreso.MinimumWidth = 6;
            this.fecha_ingreso.Name = "fecha_ingreso";
            this.fecha_ingreso.Width = 125;
            // 
            // capacidad
            // 
            this.capacidad.HeaderText = "Capacidad";
            this.capacidad.MinimumWidth = 6;
            this.capacidad.Name = "capacidad";
            this.capacidad.Width = 125;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(168)))), ((int)(((byte)(83)))));
            this.btnGuardar.FlatAppearance.BorderSize = 3;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.btnGuardar.ForeColor = System.Drawing.Color.Black;
            this.btnGuardar.Location = new System.Drawing.Point(346, 382);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(97, 42);
            this.btnGuardar.TabIndex = 8;
            this.btnGuardar.Text = "Guardar 💾";
            this.btnGuardar.UseVisualStyleBackColor = false;
            // 
            // btnCamcelar
            // 
            this.btnCamcelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(115)))), ((int)(((byte)(232)))));
            this.btnCamcelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.btnCamcelar.ForeColor = System.Drawing.Color.Black;
            this.btnCamcelar.Location = new System.Drawing.Point(510, 383);
            this.btnCamcelar.Name = "btnCamcelar";
            this.btnCamcelar.Size = new System.Drawing.Size(93, 41);
            this.btnCamcelar.TabIndex = 7;
            this.btnCamcelar.Text = "Cancelar ⛔";
            this.btnCamcelar.UseVisualStyleBackColor = false;
            // 
            // frmInformeBuqueUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 450);
            this.Controls.Add(this.panel1);
            this.Name = "frmInformeBuqueUsuario";
            this.Text = "Datos de Buques";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgBuque)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblBuques;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dtgBuque;
        private System.Windows.Forms.DataGridViewTextBoxColumn serial_buque;
        private System.Windows.Forms.DataGridViewTextBoxColumn capitan;
        private System.Windows.Forms.DataGridViewTextBoxColumn empresa;
        private System.Windows.Forms.DataGridViewTextBoxColumn origen;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha_ingreso;
        private System.Windows.Forms.DataGridViewTextBoxColumn capacidad;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCamcelar;
    }
}