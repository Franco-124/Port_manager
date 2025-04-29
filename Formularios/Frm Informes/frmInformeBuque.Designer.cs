namespace Port_manager.Formularios
{
    partial class frmInformeBuque
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtgBuque = new System.Windows.Forms.DataGridView();
            this.serial_buque = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.capitan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.origen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha_ingreso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.capacidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblBuques = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnImprimir = new FontAwesome.Sharp.IconButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgBuque)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.panel1.Controls.Add(this.btnImprimir);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dtgBuque);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(840, 450);
            this.panel1.TabIndex = 1;
            // 
            // dtgBuque
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtgBuque.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dtgBuque.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(60)))));
            this.dtgBuque.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgBuque.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.serial_buque,
            this.capitan,
            this.empresa,
            this.origen,
            this.fecha_ingreso,
            this.capacidad});
            this.dtgBuque.Location = new System.Drawing.Point(12, 109);
            this.dtgBuque.Name = "dtgBuque";
            this.dtgBuque.RowHeadersVisible = false;
            this.dtgBuque.RowHeadersWidth = 51;
            this.dtgBuque.Size = new System.Drawing.Size(816, 268);
            this.dtgBuque.TabIndex = 3;
            // 
            // serial_buque
            // 
            this.serial_buque.HeaderText = "Serial";
            this.serial_buque.MinimumWidth = 6;
            this.serial_buque.Name = "serial_buque";
            this.serial_buque.Width = 125;
            // 
            // capitan
            // 
            this.capitan.HeaderText = "Capitan";
            this.capitan.MinimumWidth = 6;
            this.capitan.Name = "capitan";
            this.capitan.Width = 125;
            // 
            // empresa
            // 
            this.empresa.HeaderText = "Empresa";
            this.empresa.MinimumWidth = 6;
            this.empresa.Name = "empresa";
            this.empresa.Width = 125;
            // 
            // origen
            // 
            this.origen.HeaderText = "Origen";
            this.origen.MinimumWidth = 6;
            this.origen.Name = "origen";
            this.origen.Width = 125;
            // 
            // fecha_ingreso
            // 
            this.fecha_ingreso.HeaderText = "Fecha de Ingreso";
            this.fecha_ingreso.MinimumWidth = 6;
            this.fecha_ingreso.Name = "fecha_ingreso";
            this.fecha_ingreso.Width = 200;
            // 
            // capacidad
            // 
            this.capacidad.HeaderText = "Capacidad";
            this.capacidad.MinimumWidth = 6;
            this.capacidad.Name = "capacidad";
            this.capacidad.Width = 125;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblBuques);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(840, 56);
            this.panel2.TabIndex = 2;
            // 
            // lblBuques
            // 
            this.lblBuques.AutoSize = true;
            this.lblBuques.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuques.ForeColor = System.Drawing.Color.White;
            this.lblBuques.Location = new System.Drawing.Point(242, 9);
            this.lblBuques.Name = "lblBuques";
            this.lblBuques.Size = new System.Drawing.Size(371, 29);
            this.lblBuques.TabIndex = 3;
            this.lblBuques.Text = "Informe de Buques Administrador";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(12, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Filtrar:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(73, 72);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // btnImprimir
            // 
            this.btnImprimir.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnImprimir.IconColor = System.Drawing.Color.Black;
            this.btnImprimir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnImprimir.Location = new System.Drawing.Point(15, 395);
            this.btnImprimir.Margin = new System.Windows.Forms.Padding(2);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(86, 35);
            this.btnImprimir.TabIndex = 6;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            // 
            // frmInformeBuque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 450);
            this.Controls.Add(this.panel1);
            this.Name = "frmInformeBuque";
            this.Text = "Buques Registrados";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgBuque)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dtgBuque;
        private System.Windows.Forms.DataGridViewTextBoxColumn serial_buque;
        private System.Windows.Forms.DataGridViewTextBoxColumn capitan;
        private System.Windows.Forms.DataGridViewTextBoxColumn empresa;
        private System.Windows.Forms.DataGridViewTextBoxColumn origen;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha_ingreso;
        private System.Windows.Forms.DataGridViewTextBoxColumn capacidad;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblBuques;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton btnImprimir;
    }
}