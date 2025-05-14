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
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblBuques = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtgIncidencias = new System.Windows.Forms.DataGridView();
            this.numero_incidencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serial_buque = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipo_Incidencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ubicacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre_admin = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1127, 69);
            this.panel2.TabIndex = 2;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // lblBuques
            // 
            this.lblBuques.AutoSize = true;
            this.lblBuques.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuques.ForeColor = System.Drawing.Color.White;
            this.lblBuques.Location = new System.Drawing.Point(404, 11);
            this.lblBuques.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBuques.Name = "lblBuques";
            this.lblBuques.Size = new System.Drawing.Size(313, 36);
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
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1127, 554);
            this.panel1.TabIndex = 2;
            // 
            // dtgIncidencias
            // 
            this.dtgIncidencias.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgIncidencias.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgIncidencias.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgIncidencias.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.dtgIncidencias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgIncidencias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numero_incidencia,
            this.serial_buque,
            this.tipo_Incidencia,
            this.ubicacion,
            this.descripcion,
            this.estado,
            this.nombre_admin});
            this.dtgIncidencias.Location = new System.Drawing.Point(16, 119);
            this.dtgIncidencias.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtgIncidencias.Name = "dtgIncidencias";
            this.dtgIncidencias.RowHeadersWidth = 51;
            this.dtgIncidencias.Size = new System.Drawing.Size(1095, 326);
            this.dtgIncidencias.TabIndex = 4;
            this.dtgIncidencias.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgIncidencias_CellContentClick_1);
            // 
            // numero_incidencia
            // 
            this.numero_incidencia.HeaderText = "Numero Incidencia";
            this.numero_incidencia.MinimumWidth = 6;
            this.numero_incidencia.Name = "numero_incidencia";
            // 
            // serial_buque
            // 
            this.serial_buque.HeaderText = "Serial Buque";
            this.serial_buque.MinimumWidth = 6;
            this.serial_buque.Name = "serial_buque";
            // 
            // tipo_Incidencia
            // 
            this.tipo_Incidencia.HeaderText = "Incidencia";
            this.tipo_Incidencia.MinimumWidth = 6;
            this.tipo_Incidencia.Name = "tipo_Incidencia";
            // 
            // ubicacion
            // 
            this.ubicacion.HeaderText = "Ubicacion";
            this.ubicacion.MinimumWidth = 6;
            this.ubicacion.Name = "ubicacion";
            // 
            // descripcion
            // 
            this.descripcion.HeaderText = "Descripcion";
            this.descripcion.MinimumWidth = 6;
            this.descripcion.Name = "descripcion";
            // 
            // estado
            // 
            this.estado.HeaderText = "Estado";
            this.estado.MinimumWidth = 6;
            this.estado.Name = "estado";
            // 
            // nombre_admin
            // 
            this.nombre_admin.HeaderText = "Nombre Administrador";
            this.nombre_admin.MinimumWidth = 6;
            this.nombre_admin.Name = "nombre_admin";
            // 
            // btnImprimir
            // 
            this.btnImprimir.BackColor = System.Drawing.Color.Tomato;
            this.btnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnImprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimir.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnImprimir.IconColor = System.Drawing.Color.Black;
            this.btnImprimir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnImprimir.Location = new System.Drawing.Point(16, 468);
            this.btnImprimir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(235, 57);
            this.btnImprimir.TabIndex = 3;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = false;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // frmInformeIncidencias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1127, 554);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
        private FontAwesome.Sharp.IconButton btnImprimir;
        private System.Windows.Forms.DataGridView dtgIncidencias;
        private System.Windows.Forms.DataGridViewTextBoxColumn numero_incidencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn serial_buque;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo_Incidencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn ubicacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre_admin;
    }
}