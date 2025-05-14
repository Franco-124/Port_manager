namespace Port_manager.Formularios
{
    partial class FrmInformeMuelle
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
            this.btnMostrar = new System.Windows.Forms.Button();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.btnImprimir = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.dtgMuelles = new System.Windows.Forms.DataGridView();
            this.id_muelle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.capacidad_muelle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipo_muelle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblMuelles = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgMuelles)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.panel1.Controls.Add(this.btnMostrar);
            this.panel1.Controls.Add(this.cmbEstado);
            this.panel1.Controls.Add(this.btnImprimir);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dtgMuelles);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1067, 554);
            this.panel1.TabIndex = 1;
            // 
            // btnMostrar
            // 
            this.btnMostrar.BackColor = System.Drawing.Color.IndianRed;
            this.btnMostrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMostrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrar.Location = new System.Drawing.Point(509, 497);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(121, 43);
            this.btnMostrar.TabIndex = 9;
            this.btnMostrar.Text = "Mostrar";
            this.btnMostrar.UseVisualStyleBackColor = false;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // cmbEstado
            // 
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Items.AddRange(new object[] {
            "disponible",
            "ocupado"});
            this.cmbEstado.Location = new System.Drawing.Point(264, 87);
            this.cmbEstado.Margin = new System.Windows.Forms.Padding(4);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(185, 24);
            this.cmbEstado.TabIndex = 8;
            this.cmbEstado.SelectedValueChanged += new System.EventHandler(this.cmbEstado_SelectedValueChanged);
            // 
            // btnImprimir
            // 
            this.btnImprimir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnImprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimir.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnImprimir.IconColor = System.Drawing.Color.Black;
            this.btnImprimir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnImprimir.Location = new System.Drawing.Point(344, 497);
            this.btnImprimir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(115, 43);
            this.btnImprimir.TabIndex = 7;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = false;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(121, 89);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Filtrar Estado:";
            // 
            // dtgMuelles
            // 
            this.dtgMuelles.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(60)))));
            this.dtgMuelles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgMuelles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_muelle,
            this.capacidad_muelle,
            this.tipo_muelle,
            this.estado});
            this.dtgMuelles.Location = new System.Drawing.Point(98, 136);
            this.dtgMuelles.Margin = new System.Windows.Forms.Padding(4);
            this.dtgMuelles.Name = "dtgMuelles";
            this.dtgMuelles.RowHeadersVisible = false;
            this.dtgMuelles.RowHeadersWidth = 51;
            this.dtgMuelles.Size = new System.Drawing.Size(874, 330);
            this.dtgMuelles.TabIndex = 3;
            // 
            // id_muelle
            // 
            this.id_muelle.HeaderText = "ID Muelle";
            this.id_muelle.MinimumWidth = 6;
            this.id_muelle.Name = "id_muelle";
            this.id_muelle.Width = 120;
            // 
            // capacidad_muelle
            // 
            this.capacidad_muelle.HeaderText = "Capacidad del Muelle";
            this.capacidad_muelle.MinimumWidth = 6;
            this.capacidad_muelle.Name = "capacidad_muelle";
            this.capacidad_muelle.Width = 180;
            // 
            // tipo_muelle
            // 
            this.tipo_muelle.HeaderText = "Tipo de Muelle";
            this.tipo_muelle.MinimumWidth = 6;
            this.tipo_muelle.Name = "tipo_muelle";
            this.tipo_muelle.Width = 180;
            // 
            // estado
            // 
            this.estado.HeaderText = "Estado";
            this.estado.MinimumWidth = 6;
            this.estado.Name = "estado";
            this.estado.Width = 140;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblMuelles);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1067, 69);
            this.panel2.TabIndex = 2;
            // 
            // lblMuelles
            // 
            this.lblMuelles.AutoSize = true;
            this.lblMuelles.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMuelles.ForeColor = System.Drawing.Color.White;
            this.lblMuelles.Location = new System.Drawing.Point(244, 11);
            this.lblMuelles.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMuelles.Name = "lblMuelles";
            this.lblMuelles.Size = new System.Drawing.Size(504, 36);
            this.lblMuelles.TabIndex = 3;
            this.lblMuelles.Text = "Informe de Disponibilidad de Muelles";
            // 
            // FrmInformeMuelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmInformeMuelle";
            this.Text = "Disponibilidad Muelles";
            this.Load += new System.EventHandler(this.FrmInformeMuelle_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgMuelles)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dtgMuelles;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblMuelles;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_muelle;
        private System.Windows.Forms.DataGridViewTextBoxColumn capacidad_muelle;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo_muelle;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbEstado;
        private FontAwesome.Sharp.IconButton btnImprimir;
        private System.Windows.Forms.Button btnMostrar;
    }
}