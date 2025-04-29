namespace Port_manager.Formularios
{
    partial class frmInformeIncidencias
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblBuques = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtgIncidencias = new System.Windows.Forms.DataGridView();
            this.numero_incidencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serial_buque = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipo_incidencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ubicacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnImprimir = new FontAwesome.Sharp.IconButton();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgIncidencias)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblBuques);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(845, 56);
            this.panel2.TabIndex = 2;
            // 
            // lblBuques
            // 
            this.lblBuques.AutoSize = true;
            this.lblBuques.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuques.ForeColor = System.Drawing.Color.White;
            this.lblBuques.Location = new System.Drawing.Point(303, 9);
            this.lblBuques.Name = "lblBuques";
            this.lblBuques.Size = new System.Drawing.Size(255, 29);
            this.lblBuques.TabIndex = 3;
            this.lblBuques.Text = "Informe de Incidencias";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.panel1.Controls.Add(this.btnImprimir);
            this.panel1.Controls.Add(this.dtgIncidencias);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(845, 450);
            this.panel1.TabIndex = 2;
            // 
            // dtgIncidencias
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtgIncidencias.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgIncidencias.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(60)))));
            this.dtgIncidencias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgIncidencias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numero_incidencia,
            this.serial_buque,
            this.tipo_incidencia,
            this.ubicacion,
            this.descripcion,
            this.estado});
            this.dtgIncidencias.Location = new System.Drawing.Point(40, 107);
            this.dtgIncidencias.Name = "dtgIncidencias";
            this.dtgIncidencias.RowHeadersVisible = false;
            this.dtgIncidencias.RowHeadersWidth = 51;
            this.dtgIncidencias.Size = new System.Drawing.Size(770, 268);
            this.dtgIncidencias.TabIndex = 3;
            // 
            // numero_incidencia
            // 
            this.numero_incidencia.HeaderText = "# de Incidencia";
            this.numero_incidencia.MinimumWidth = 6;
            this.numero_incidencia.Name = "numero_incidencia";
            this.numero_incidencia.Width = 110;
            // 
            // serial_buque
            // 
            this.serial_buque.HeaderText = "Serial";
            this.serial_buque.MinimumWidth = 6;
            this.serial_buque.Name = "serial_buque";
            this.serial_buque.Width = 80;
            // 
            // tipo_incidencia
            // 
            this.tipo_incidencia.HeaderText = "Tipo de Incidencia";
            this.tipo_incidencia.MinimumWidth = 6;
            this.tipo_incidencia.Name = "tipo_incidencia";
            this.tipo_incidencia.Width = 125;
            // 
            // ubicacion
            // 
            this.ubicacion.HeaderText = "Ubicacion";
            this.ubicacion.MinimumWidth = 6;
            this.ubicacion.Name = "ubicacion";
            this.ubicacion.Width = 125;
            // 
            // descripcion
            // 
            this.descripcion.HeaderText = "Descripcion";
            this.descripcion.MinimumWidth = 6;
            this.descripcion.Name = "descripcion";
            this.descripcion.Width = 200;
            // 
            // estado
            // 
            this.estado.HeaderText = "Estado";
            this.estado.MinimumWidth = 6;
            this.estado.Name = "estado";
            this.estado.Width = 125;
            // 
            // btnImprimir
            // 
            this.btnImprimir.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnImprimir.IconColor = System.Drawing.Color.Black;
            this.btnImprimir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnImprimir.Location = new System.Drawing.Point(40, 389);
            this.btnImprimir.Margin = new System.Windows.Forms.Padding(2);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(86, 35);
            this.btnImprimir.TabIndex = 3;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            // 
            // frmInformeIncidencias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 450);
            this.Controls.Add(this.panel1);
            this.Name = "frmInformeIncidencias";
            this.Text = "Estado de Incidencias";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgIncidencias)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblBuques;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dtgIncidencias;
        private System.Windows.Forms.DataGridViewTextBoxColumn numero_incidencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn serial_buque;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo_incidencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn ubicacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado;
        private FontAwesome.Sharp.IconButton btnImprimir;
    }
}