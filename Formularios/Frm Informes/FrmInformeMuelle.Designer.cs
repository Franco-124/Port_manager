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
            this.dtgMuelles = new System.Windows.Forms.DataGridView();
            this.id_muelle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.capacidad_muelle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipo_muelle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblMuelles = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnImprimir = new FontAwesome.Sharp.IconButton();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgMuelles)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.btnImprimir);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dtgMuelles);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 1;
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
            this.dtgMuelles.Location = new System.Drawing.Point(94, 112);
            this.dtgMuelles.Name = "dtgMuelles";
            this.dtgMuelles.RowHeadersVisible = false;
            this.dtgMuelles.RowHeadersWidth = 51;
            this.dtgMuelles.Size = new System.Drawing.Size(624, 268);
            this.dtgMuelles.TabIndex = 3;
            // 
            // id_muelle
            // 
            this.id_muelle.HeaderText = "ID Muelle";
            this.id_muelle.Name = "id_muelle";
            this.id_muelle.Width = 120;
            // 
            // capacidad_muelle
            // 
            this.capacidad_muelle.HeaderText = "Capacidad del Muelle";
            this.capacidad_muelle.Name = "capacidad_muelle";
            this.capacidad_muelle.Width = 180;
            // 
            // tipo_muelle
            // 
            this.tipo_muelle.HeaderText = "Tipo de Muelle";
            this.tipo_muelle.Name = "tipo_muelle";
            this.tipo_muelle.Width = 180;
            // 
            // estado
            // 
            this.estado.HeaderText = "Estado";
            this.estado.Name = "estado";
            this.estado.Width = 140;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblMuelles);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 56);
            this.panel2.TabIndex = 2;
            // 
            // lblMuelles
            // 
            this.lblMuelles.AutoSize = true;
            this.lblMuelles.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMuelles.ForeColor = System.Drawing.Color.White;
            this.lblMuelles.Location = new System.Drawing.Point(183, 9);
            this.lblMuelles.Name = "lblMuelles";
            this.lblMuelles.Size = new System.Drawing.Size(414, 29);
            this.lblMuelles.TabIndex = 3;
            this.lblMuelles.Text = "Informe de Disponibilidad de Muelles";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(91, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Filtrar Estado:";
            // 
            // btnImprimir
            // 
            this.btnImprimir.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnImprimir.IconColor = System.Drawing.Color.Black;
            this.btnImprimir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnImprimir.Location = new System.Drawing.Point(94, 404);
            this.btnImprimir.Margin = new System.Windows.Forms.Padding(2);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(86, 35);
            this.btnImprimir.TabIndex = 7;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(198, 71);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(140, 21);
            this.comboBox1.TabIndex = 8;
            // 
            // FrmInformeMuelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "FrmInformeMuelle";
            this.Text = "Disponibilidad Muelles";
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
        private System.Windows.Forms.ComboBox comboBox1;
        private FontAwesome.Sharp.IconButton btnImprimir;
    }
}