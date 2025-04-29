namespace Port_manager.Formularios
{
    partial class frmInformePendientes
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtgPendientes = new System.Windows.Forms.DataGridView();
            this.serial_buque = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_muelle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipo_carga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblPendientes = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPendientes)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.panel1.Controls.Add(this.dtgPendientes);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(810, 451);
            this.panel1.TabIndex = 0;
            // 
            // dtgPendientes
            // 
            this.dtgPendientes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(60)))));
            this.dtgPendientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgPendientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.serial_buque,
            this.id_muelle,
            this.accion,
            this.tipo_carga});
            this.dtgPendientes.Location = new System.Drawing.Point(50, 99);
            this.dtgPendientes.Name = "dtgPendientes";
            this.dtgPendientes.RowHeadersVisible = false;
            this.dtgPendientes.RowHeadersWidth = 51;
            this.dtgPendientes.Size = new System.Drawing.Size(721, 268);
            this.dtgPendientes.TabIndex = 3;
            // 
            // serial_buque
            // 
            this.serial_buque.HeaderText = "Serial del Buque";
            this.serial_buque.Name = "serial_buque";
            this.serial_buque.Width = 180;
            // 
            // id_muelle
            // 
            this.id_muelle.HeaderText = "ID del Muelle";
            this.id_muelle.Name = "id_muelle";
            this.id_muelle.Width = 180;
            // 
            // accion
            // 
            this.accion.HeaderText = "Acción del Buque";
            this.accion.Name = "accion";
            this.accion.Width = 180;
            // 
            // tipo_carga
            // 
            this.tipo_carga.HeaderText = "Tipo de carga";
            this.tipo_carga.Name = "tipo_carga";
            this.tipo_carga.Width = 180;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblPendientes);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(810, 56);
            this.panel2.TabIndex = 2;
            // 
            // lblPendientes
            // 
            this.lblPendientes.AutoSize = true;
            this.lblPendientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPendientes.ForeColor = System.Drawing.Color.White;
            this.lblPendientes.Location = new System.Drawing.Point(154, 9);
            this.lblPendientes.Name = "lblPendientes";
            this.lblPendientes.Size = new System.Drawing.Size(511, 29);
            this.lblPendientes.TabIndex = 3;
            this.lblPendientes.Text = "Informe de Pendientes por Cargar y Descargar";
            // 
            // frmInformePendientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 451);
            this.Controls.Add(this.panel1);
            this.Name = "frmInformePendientes";
            this.Text = "Carga y Descarga";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgPendientes)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dtgPendientes;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblPendientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn serial_buque;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_muelle;
        private System.Windows.Forms.DataGridViewTextBoxColumn accion;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo_carga;
    }
}