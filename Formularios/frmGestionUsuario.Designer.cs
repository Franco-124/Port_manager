namespace Port_manager.Formularios
{
    partial class frmGestionUsuario
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
            this.lblRegistro = new System.Windows.Forms.Label();
            this.dtgUsuarios = new System.Windows.Forms.DataGridView();
            this.id_usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre_usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblRegistro);
            this.panel1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1067, 69);
            this.panel1.TabIndex = 0;
            // 
            // lblRegistro
            // 
            this.lblRegistro.AutoSize = true;
            this.lblRegistro.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lblRegistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistro.ForeColor = System.Drawing.Color.White;
            this.lblRegistro.Location = new System.Drawing.Point(389, 17);
            this.lblRegistro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRegistro.Name = "lblRegistro";
            this.lblRegistro.Size = new System.Drawing.Size(282, 36);
            this.lblRegistro.TabIndex = 3;
            this.lblRegistro.Text = "Informe de Usuarios";
            // 
            // dtgUsuarios
            // 
            this.dtgUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_usuario,
            this.nombre_usuario,
            this.email,
            this.rol});
            this.dtgUsuarios.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dtgUsuarios.Location = new System.Drawing.Point(31, 86);
            this.dtgUsuarios.Name = "dtgUsuarios";
            this.dtgUsuarios.RowHeadersWidth = 51;
            this.dtgUsuarios.RowTemplate.Height = 24;
            this.dtgUsuarios.Size = new System.Drawing.Size(959, 285);
            this.dtgUsuarios.TabIndex = 1;
            // 
            // id_usuario
            // 
            this.id_usuario.HeaderText = "ID";
            this.id_usuario.MinimumWidth = 6;
            this.id_usuario.Name = "id_usuario";
            this.id_usuario.Width = 150;
            // 
            // nombre_usuario
            // 
            this.nombre_usuario.HeaderText = "Usuario";
            this.nombre_usuario.MinimumWidth = 6;
            this.nombre_usuario.Name = "nombre_usuario";
            this.nombre_usuario.Width = 150;
            // 
            // email
            // 
            this.email.HeaderText = "Email";
            this.email.MinimumWidth = 6;
            this.email.Name = "email";
            this.email.Width = 180;
            // 
            // rol
            // 
            this.rol.HeaderText = "Rol";
            this.rol.MinimumWidth = 6;
            this.rol.Name = "rol";
            this.rol.Width = 150;
            // 
            // frmGestionUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.dtgUsuarios);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmGestionUsuario";
            this.Text = "Usuarios Registrados";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgUsuarios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblRegistro;
        private System.Windows.Forms.DataGridView dtgUsuarios;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre_usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn rol;
    }
}