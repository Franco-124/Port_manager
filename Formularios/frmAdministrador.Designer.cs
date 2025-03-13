namespace Port_manager.Formularios
{
    partial class frmAdministrador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdministrador));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnCambioContra = new FontAwesome.Sharp.IconButton();
            this.btnGestionAdb = new FontAwesome.Sharp.IconButton();
            this.btnIncidencias = new FontAwesome.Sharp.IconButton();
            this.btnCargaDescarga = new FontAwesome.Sharp.IconButton();
            this.btnClasificacion = new FontAwesome.Sharp.IconButton();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.pnlTitleBar = new System.Windows.Forms.Panel();
            this.pnlAdmin = new System.Windows.Forms.Panel();
            this.btnCerrarSesion = new FontAwesome.Sharp.IconButton();
            this.lbDate = new System.Windows.Forms.Label();
            this.lblBienvenida = new System.Windows.Forms.Label();
            this.lblInicio = new System.Windows.Forms.Label();
            this.IcnHome = new FontAwesome.Sharp.IconPictureBox();
            this.pnlShadow = new System.Windows.Forms.Panel();
            this.pnlDesktop = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.pnlTitleBar.SuspendLayout();
            this.pnlAdmin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IcnHome)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.panelMenu.Controls.Add(this.btnCambioContra);
            this.panelMenu.Controls.Add(this.btnGestionAdb);
            this.panelMenu.Controls.Add(this.btnIncidencias);
            this.panelMenu.Controls.Add(this.btnCargaDescarga);
            this.panelMenu.Controls.Add(this.btnClasificacion);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(220, 516);
            this.panelMenu.TabIndex = 0;
            this.panelMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnCambioContra
            // 
            this.btnCambioContra.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCambioContra.FlatAppearance.BorderSize = 0;
            this.btnCambioContra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCambioContra.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCambioContra.ForeColor = System.Drawing.Color.White;
            this.btnCambioContra.IconChar = FontAwesome.Sharp.IconChar.Key;
            this.btnCambioContra.IconColor = System.Drawing.Color.White;
            this.btnCambioContra.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCambioContra.IconSize = 40;
            this.btnCambioContra.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCambioContra.Location = new System.Drawing.Point(0, 380);
            this.btnCambioContra.Name = "btnCambioContra";
            this.btnCambioContra.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnCambioContra.Size = new System.Drawing.Size(220, 60);
            this.btnCambioContra.TabIndex = 5;
            this.btnCambioContra.Text = "Cambio de contraseña";
            this.btnCambioContra.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCambioContra.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCambioContra.UseVisualStyleBackColor = true;
            this.btnCambioContra.Click += new System.EventHandler(this.btnCambioContra_Click);
            // 
            // btnGestionAdb
            // 
            this.btnGestionAdb.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGestionAdb.FlatAppearance.BorderSize = 0;
            this.btnGestionAdb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGestionAdb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestionAdb.ForeColor = System.Drawing.Color.White;
            this.btnGestionAdb.IconChar = FontAwesome.Sharp.IconChar.User;
            this.btnGestionAdb.IconColor = System.Drawing.Color.White;
            this.btnGestionAdb.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGestionAdb.IconSize = 40;
            this.btnGestionAdb.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGestionAdb.Location = new System.Drawing.Point(0, 320);
            this.btnGestionAdb.Name = "btnGestionAdb";
            this.btnGestionAdb.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnGestionAdb.Size = new System.Drawing.Size(220, 60);
            this.btnGestionAdb.TabIndex = 4;
            this.btnGestionAdb.Text = "Gestión de Administrador";
            this.btnGestionAdb.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGestionAdb.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGestionAdb.UseVisualStyleBackColor = true;
            this.btnGestionAdb.Click += new System.EventHandler(this.btnGestionAdb_Click);
            // 
            // btnIncidencias
            // 
            this.btnIncidencias.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnIncidencias.FlatAppearance.BorderSize = 0;
            this.btnIncidencias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIncidencias.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIncidencias.ForeColor = System.Drawing.Color.White;
            this.btnIncidencias.IconChar = FontAwesome.Sharp.IconChar.CircleExclamation;
            this.btnIncidencias.IconColor = System.Drawing.Color.White;
            this.btnIncidencias.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnIncidencias.IconSize = 40;
            this.btnIncidencias.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIncidencias.Location = new System.Drawing.Point(0, 260);
            this.btnIncidencias.Name = "btnIncidencias";
            this.btnIncidencias.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnIncidencias.Size = new System.Drawing.Size(220, 60);
            this.btnIncidencias.TabIndex = 3;
            this.btnIncidencias.Text = "Registro de incidencias";
            this.btnIncidencias.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIncidencias.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnIncidencias.UseVisualStyleBackColor = true;
            this.btnIncidencias.Click += new System.EventHandler(this.btnIncidencias_Click);
            // 
            // btnCargaDescarga
            // 
            this.btnCargaDescarga.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCargaDescarga.FlatAppearance.BorderSize = 0;
            this.btnCargaDescarga.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCargaDescarga.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargaDescarga.ForeColor = System.Drawing.Color.White;
            this.btnCargaDescarga.IconChar = FontAwesome.Sharp.IconChar.Trailer;
            this.btnCargaDescarga.IconColor = System.Drawing.Color.White;
            this.btnCargaDescarga.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCargaDescarga.IconSize = 40;
            this.btnCargaDescarga.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCargaDescarga.Location = new System.Drawing.Point(0, 200);
            this.btnCargaDescarga.Name = "btnCargaDescarga";
            this.btnCargaDescarga.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnCargaDescarga.Size = new System.Drawing.Size(220, 60);
            this.btnCargaDescarga.TabIndex = 2;
            this.btnCargaDescarga.Text = "Carga/Descarga de Carga";
            this.btnCargaDescarga.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCargaDescarga.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCargaDescarga.UseVisualStyleBackColor = true;
            this.btnCargaDescarga.Click += new System.EventHandler(this.btnCargaDescarga_Click);
            // 
            // btnClasificacion
            // 
            this.btnClasificacion.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnClasificacion.FlatAppearance.BorderSize = 0;
            this.btnClasificacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClasificacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClasificacion.ForeColor = System.Drawing.Color.White;
            this.btnClasificacion.IconChar = FontAwesome.Sharp.IconChar.Ship;
            this.btnClasificacion.IconColor = System.Drawing.Color.White;
            this.btnClasificacion.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnClasificacion.IconSize = 40;
            this.btnClasificacion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClasificacion.Location = new System.Drawing.Point(0, 140);
            this.btnClasificacion.Name = "btnClasificacion";
            this.btnClasificacion.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnClasificacion.Size = new System.Drawing.Size(220, 60);
            this.btnClasificacion.TabIndex = 1;
            this.btnClasificacion.Text = "Clasificación y Asignación de Muelles";
            this.btnClasificacion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClasificacion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClasificacion.UseVisualStyleBackColor = true;
            this.btnClasificacion.Click += new System.EventHandler(this.btnClasificacion_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelLogo.BackgroundImage")));
            this.panelLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(220, 140);
            this.panelLogo.TabIndex = 0;
            this.panelLogo.Click += new System.EventHandler(this.panelLogo_Click_1);
            // 
            // pnlTitleBar
            // 
            this.pnlTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.pnlTitleBar.Controls.Add(this.pnlAdmin);
            this.pnlTitleBar.Controls.Add(this.lblInicio);
            this.pnlTitleBar.Controls.Add(this.IcnHome);
            this.pnlTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitleBar.Location = new System.Drawing.Point(220, 0);
            this.pnlTitleBar.Name = "pnlTitleBar";
            this.pnlTitleBar.Size = new System.Drawing.Size(756, 75);
            this.pnlTitleBar.TabIndex = 1;
            this.pnlTitleBar.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlTitleBar_Paint);
            // 
            // pnlAdmin
            // 
            this.pnlAdmin.Controls.Add(this.btnCerrarSesion);
            this.pnlAdmin.Controls.Add(this.lbDate);
            this.pnlAdmin.Controls.Add(this.lblBienvenida);
            this.pnlAdmin.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlAdmin.Location = new System.Drawing.Point(320, 0);
            this.pnlAdmin.Name = "pnlAdmin";
            this.pnlAdmin.Size = new System.Drawing.Size(436, 75);
            this.pnlAdmin.TabIndex = 2;
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.btnCerrarSesion.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCerrarSesion.FlatAppearance.BorderSize = 0;
            this.btnCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarSesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarSesion.ForeColor = System.Drawing.Color.White;
            this.btnCerrarSesion.IconChar = FontAwesome.Sharp.IconChar.SquareXmark;
            this.btnCerrarSesion.IconColor = System.Drawing.Color.White;
            this.btnCerrarSesion.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCerrarSesion.IconSize = 32;
            this.btnCerrarSesion.Location = new System.Drawing.Point(324, 0);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(112, 75);
            this.btnCerrarSesion.TabIndex = 4;
            this.btnCerrarSesion.Text = "Cerrar Sesión";
            this.btnCerrarSesion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCerrarSesion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCerrarSesion.UseVisualStyleBackColor = false;
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            // 
            // lbDate
            // 
            this.lbDate.AutoSize = true;
            this.lbDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lbDate.Location = new System.Drawing.Point(196, 33);
            this.lbDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(89, 17);
            this.lbDate.TabIndex = 3;
            this.lbDate.Text = "current_date";
            this.lbDate.Click += new System.EventHandler(this.lbDate_Click);
            // 
            // lblBienvenida
            // 
            this.lblBienvenida.AutoSize = true;
            this.lblBienvenida.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBienvenida.ForeColor = System.Drawing.Color.White;
            this.lblBienvenida.Location = new System.Drawing.Point(3, 33);
            this.lblBienvenida.Name = "lblBienvenida";
            this.lblBienvenida.Size = new System.Drawing.Size(46, 17);
            this.lblBienvenida.TabIndex = 0;
            this.lblBienvenida.Text = "label1";
            this.lblBienvenida.Click += new System.EventHandler(this.lblBienvenida_Click);
            // 
            // lblInicio
            // 
            this.lblInicio.AutoSize = true;
            this.lblInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInicio.ForeColor = System.Drawing.Color.White;
            this.lblInicio.Location = new System.Drawing.Point(62, 33);
            this.lblInicio.Name = "lblInicio";
            this.lblInicio.Size = new System.Drawing.Size(40, 17);
            this.lblInicio.TabIndex = 1;
            this.lblInicio.Text = "Inicio";
            // 
            // IcnHome
            // 
            this.IcnHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.IcnHome.IconChar = FontAwesome.Sharp.IconChar.House;
            this.IcnHome.IconColor = System.Drawing.Color.White;
            this.IcnHome.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IcnHome.Location = new System.Drawing.Point(24, 24);
            this.IcnHome.Name = "IcnHome";
            this.IcnHome.Size = new System.Drawing.Size(32, 32);
            this.IcnHome.TabIndex = 0;
            this.IcnHome.TabStop = false;
            this.IcnHome.Click += new System.EventHandler(this.IcnHome_Click);
            // 
            // pnlShadow
            // 
            this.pnlShadow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(24)))), ((int)(((byte)(58)))));
            this.pnlShadow.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlShadow.Location = new System.Drawing.Point(220, 75);
            this.pnlShadow.Name = "pnlShadow";
            this.pnlShadow.Size = new System.Drawing.Size(756, 10);
            this.pnlShadow.TabIndex = 2;
            // 
            // pnlDesktop
            // 
            this.pnlDesktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.pnlDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDesktop.Location = new System.Drawing.Point(220, 85);
            this.pnlDesktop.Name = "pnlDesktop";
            this.pnlDesktop.Size = new System.Drawing.Size(756, 431);
            this.pnlDesktop.TabIndex = 3;
            this.pnlDesktop.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlDesktop_Paint);
            // 
            // frmAdministrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(976, 516);
            this.Controls.Add(this.pnlDesktop);
            this.Controls.Add(this.pnlShadow);
            this.Controls.Add(this.pnlTitleBar);
            this.Controls.Add(this.panelMenu);
            this.Name = "frmAdministrador";
            this.Text = "Panel de Administrador";
            this.Load += new System.EventHandler(this.frmAdministrador_Load);
            this.panelMenu.ResumeLayout(false);
            this.pnlTitleBar.ResumeLayout(false);
            this.pnlTitleBar.PerformLayout();
            this.pnlAdmin.ResumeLayout(false);
            this.pnlAdmin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IcnHome)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelLogo;
        private FontAwesome.Sharp.IconButton btnClasificacion;
        private FontAwesome.Sharp.IconButton btnCambioContra;
        private FontAwesome.Sharp.IconButton btnGestionAdb;
        private FontAwesome.Sharp.IconButton btnIncidencias;
        private FontAwesome.Sharp.IconButton btnCargaDescarga;
        private System.Windows.Forms.Panel pnlTitleBar;
        private FontAwesome.Sharp.IconPictureBox IcnHome;
        private System.Windows.Forms.Panel pnlShadow;
        private System.Windows.Forms.Panel pnlDesktop;
        private System.Windows.Forms.Label lblInicio;
        private System.Windows.Forms.Panel pnlAdmin;
        private System.Windows.Forms.Label lblBienvenida;
        private System.Windows.Forms.Label lbDate;
        private FontAwesome.Sharp.IconButton btnCerrarSesion;
    }
}