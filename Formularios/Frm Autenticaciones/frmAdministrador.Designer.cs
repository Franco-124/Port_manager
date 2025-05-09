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
            this.pnlInformes = new System.Windows.Forms.Panel();
            this.btnInformeBuques = new FontAwesome.Sharp.IconButton();
            this.btnInformePendientes = new FontAwesome.Sharp.IconButton();
            this.btnInformeMuelles = new FontAwesome.Sharp.IconButton();
            this.btnInformeUsuario = new FontAwesome.Sharp.IconButton();
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
            this.pnlInformes.SuspendLayout();
            this.pnlTitleBar.SuspendLayout();
            this.pnlAdmin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IcnHome)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.panelMenu.Controls.Add(this.btnCambioContra);
            this.panelMenu.Controls.Add(this.pnlInformes);
            this.panelMenu.Controls.Add(this.btnGestionAdb);
            this.panelMenu.Controls.Add(this.btnIncidencias);
            this.panelMenu.Controls.Add(this.btnCargaDescarga);
            this.panelMenu.Controls.Add(this.btnClasificacion);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(293, 817);
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
            this.btnCambioContra.Location = new System.Drawing.Point(0, 745);
            this.btnCambioContra.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCambioContra.Name = "btnCambioContra";
            this.btnCambioContra.Padding = new System.Windows.Forms.Padding(13, 0, 27, 0);
            this.btnCambioContra.Size = new System.Drawing.Size(293, 74);
            this.btnCambioContra.TabIndex = 7;
            this.btnCambioContra.Text = "Cambio de Contraseña";
            this.btnCambioContra.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCambioContra.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCambioContra.UseVisualStyleBackColor = true;
            this.btnCambioContra.Click += new System.EventHandler(this.btnCambioContra_Click_1);
            // 
            // pnlInformes
            // 
            this.pnlInformes.Controls.Add(this.btnInformeBuques);
            this.pnlInformes.Controls.Add(this.btnInformePendientes);
            this.pnlInformes.Controls.Add(this.btnInformeMuelles);
            this.pnlInformes.Controls.Add(this.btnInformeUsuario);
            this.pnlInformes.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlInformes.Location = new System.Drawing.Point(0, 542);
            this.pnlInformes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlInformes.Name = "pnlInformes";
            this.pnlInformes.Size = new System.Drawing.Size(293, 203);
            this.pnlInformes.TabIndex = 6;
            // 
            // btnInformeBuques
            // 
            this.btnInformeBuques.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInformeBuques.FlatAppearance.BorderSize = 0;
            this.btnInformeBuques.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInformeBuques.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInformeBuques.ForeColor = System.Drawing.Color.White;
            this.btnInformeBuques.IconChar = FontAwesome.Sharp.IconChar.Folder;
            this.btnInformeBuques.IconColor = System.Drawing.Color.White;
            this.btnInformeBuques.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnInformeBuques.IconSize = 30;
            this.btnInformeBuques.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInformeBuques.Location = new System.Drawing.Point(0, 147);
            this.btnInformeBuques.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnInformeBuques.Name = "btnInformeBuques";
            this.btnInformeBuques.Padding = new System.Windows.Forms.Padding(13, 0, 27, 0);
            this.btnInformeBuques.Size = new System.Drawing.Size(293, 49);
            this.btnInformeBuques.TabIndex = 8;
            this.btnInformeBuques.Text = "Buques Registrados";
            this.btnInformeBuques.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInformeBuques.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnInformeBuques.UseVisualStyleBackColor = true;
            this.btnInformeBuques.Click += new System.EventHandler(this.btnInformeBuques_Click);
            // 
            // btnInformePendientes
            // 
            this.btnInformePendientes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInformePendientes.FlatAppearance.BorderSize = 0;
            this.btnInformePendientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInformePendientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInformePendientes.ForeColor = System.Drawing.Color.White;
            this.btnInformePendientes.IconChar = FontAwesome.Sharp.IconChar.Folder;
            this.btnInformePendientes.IconColor = System.Drawing.Color.White;
            this.btnInformePendientes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnInformePendientes.IconSize = 30;
            this.btnInformePendientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInformePendientes.Location = new System.Drawing.Point(0, 98);
            this.btnInformePendientes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnInformePendientes.Name = "btnInformePendientes";
            this.btnInformePendientes.Padding = new System.Windows.Forms.Padding(13, 0, 27, 0);
            this.btnInformePendientes.Size = new System.Drawing.Size(293, 49);
            this.btnInformePendientes.TabIndex = 7;
            this.btnInformePendientes.Text = "Carga y Descarga";
            this.btnInformePendientes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInformePendientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnInformePendientes.UseVisualStyleBackColor = true;
            this.btnInformePendientes.Click += new System.EventHandler(this.btnInformePendientes_Click);
            // 
            // btnInformeMuelles
            // 
            this.btnInformeMuelles.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInformeMuelles.FlatAppearance.BorderSize = 0;
            this.btnInformeMuelles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInformeMuelles.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInformeMuelles.ForeColor = System.Drawing.Color.White;
            this.btnInformeMuelles.IconChar = FontAwesome.Sharp.IconChar.Folder;
            this.btnInformeMuelles.IconColor = System.Drawing.Color.White;
            this.btnInformeMuelles.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnInformeMuelles.IconSize = 30;
            this.btnInformeMuelles.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInformeMuelles.Location = new System.Drawing.Point(0, 49);
            this.btnInformeMuelles.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnInformeMuelles.Name = "btnInformeMuelles";
            this.btnInformeMuelles.Padding = new System.Windows.Forms.Padding(13, 0, 27, 0);
            this.btnInformeMuelles.Size = new System.Drawing.Size(293, 49);
            this.btnInformeMuelles.TabIndex = 6;
            this.btnInformeMuelles.Text = "Disponibilidad Muelles";
            this.btnInformeMuelles.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInformeMuelles.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnInformeMuelles.UseVisualStyleBackColor = true;
            this.btnInformeMuelles.Click += new System.EventHandler(this.btnInformeMuelles_Click);
            // 
            // btnInformeUsuario
            // 
            this.btnInformeUsuario.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInformeUsuario.FlatAppearance.BorderSize = 0;
            this.btnInformeUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInformeUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInformeUsuario.ForeColor = System.Drawing.Color.White;
            this.btnInformeUsuario.IconChar = FontAwesome.Sharp.IconChar.Folder;
            this.btnInformeUsuario.IconColor = System.Drawing.Color.White;
            this.btnInformeUsuario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnInformeUsuario.IconSize = 30;
            this.btnInformeUsuario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInformeUsuario.Location = new System.Drawing.Point(0, 0);
            this.btnInformeUsuario.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnInformeUsuario.Name = "btnInformeUsuario";
            this.btnInformeUsuario.Padding = new System.Windows.Forms.Padding(13, 0, 27, 0);
            this.btnInformeUsuario.Size = new System.Drawing.Size(293, 49);
            this.btnInformeUsuario.TabIndex = 5;
            this.btnInformeUsuario.Text = "Usuarios Registrados";
            this.btnInformeUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInformeUsuario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnInformeUsuario.UseVisualStyleBackColor = true;
            this.btnInformeUsuario.Click += new System.EventHandler(this.btnInformeUsuario_Click);
            // 
            // btnGestionAdb
            // 
            this.btnGestionAdb.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGestionAdb.FlatAppearance.BorderSize = 0;
            this.btnGestionAdb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGestionAdb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestionAdb.ForeColor = System.Drawing.Color.White;
            this.btnGestionAdb.IconChar = FontAwesome.Sharp.IconChar.Folder;
            this.btnGestionAdb.IconColor = System.Drawing.Color.White;
            this.btnGestionAdb.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGestionAdb.IconSize = 40;
            this.btnGestionAdb.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGestionAdb.Location = new System.Drawing.Point(0, 468);
            this.btnGestionAdb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGestionAdb.Name = "btnGestionAdb";
            this.btnGestionAdb.Padding = new System.Windows.Forms.Padding(13, 0, 27, 0);
            this.btnGestionAdb.Size = new System.Drawing.Size(293, 74);
            this.btnGestionAdb.TabIndex = 4;
            this.btnGestionAdb.Text = "Informes";
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
            this.btnIncidencias.Location = new System.Drawing.Point(0, 394);
            this.btnIncidencias.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnIncidencias.Name = "btnIncidencias";
            this.btnIncidencias.Padding = new System.Windows.Forms.Padding(13, 0, 27, 0);
            this.btnIncidencias.Size = new System.Drawing.Size(293, 74);
            this.btnIncidencias.TabIndex = 3;
            this.btnIncidencias.Text = "Registro de Incidencias";
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
            this.btnCargaDescarga.Location = new System.Drawing.Point(0, 320);
            this.btnCargaDescarga.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCargaDescarga.Name = "btnCargaDescarga";
            this.btnCargaDescarga.Padding = new System.Windows.Forms.Padding(13, 0, 27, 0);
            this.btnCargaDescarga.Size = new System.Drawing.Size(293, 74);
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
            this.btnClasificacion.Location = new System.Drawing.Point(0, 246);
            this.btnClasificacion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnClasificacion.Name = "btnClasificacion";
            this.btnClasificacion.Padding = new System.Windows.Forms.Padding(13, 0, 27, 0);
            this.btnClasificacion.Size = new System.Drawing.Size(293, 74);
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
            this.panelLogo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(293, 246);
            this.panelLogo.TabIndex = 0;
            this.panelLogo.Click += new System.EventHandler(this.panelLogo_Click_1);
            this.panelLogo.Paint += new System.Windows.Forms.PaintEventHandler(this.panelLogo_Paint);
            // 
            // pnlTitleBar
            // 
            this.pnlTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.pnlTitleBar.Controls.Add(this.pnlAdmin);
            this.pnlTitleBar.Controls.Add(this.lblInicio);
            this.pnlTitleBar.Controls.Add(this.IcnHome);
            this.pnlTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitleBar.Location = new System.Drawing.Point(293, 0);
            this.pnlTitleBar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlTitleBar.Name = "pnlTitleBar";
            this.pnlTitleBar.Size = new System.Drawing.Size(1299, 92);
            this.pnlTitleBar.TabIndex = 1;
            this.pnlTitleBar.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlTitleBar_Paint);
            // 
            // pnlAdmin
            // 
            this.pnlAdmin.Controls.Add(this.btnCerrarSesion);
            this.pnlAdmin.Controls.Add(this.lbDate);
            this.pnlAdmin.Controls.Add(this.lblBienvenida);
            this.pnlAdmin.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlAdmin.Location = new System.Drawing.Point(498, 0);
            this.pnlAdmin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlAdmin.Name = "pnlAdmin";
            this.pnlAdmin.Size = new System.Drawing.Size(801, 92);
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
            this.btnCerrarSesion.Location = new System.Drawing.Point(652, 0);
            this.btnCerrarSesion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(149, 92);
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
            this.lbDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lbDate.Location = new System.Drawing.Point(504, 30);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(121, 25);
            this.lbDate.TabIndex = 3;
            this.lbDate.Text = "current_date";
            this.lbDate.Click += new System.EventHandler(this.lbDate_Click);
            // 
            // lblBienvenida
            // 
            this.lblBienvenida.AutoSize = true;
            this.lblBienvenida.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBienvenida.ForeColor = System.Drawing.Color.White;
            this.lblBienvenida.Location = new System.Drawing.Point(205, 30);
            this.lblBienvenida.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBienvenida.Name = "lblBienvenida";
            this.lblBienvenida.Size = new System.Drawing.Size(64, 25);
            this.lblBienvenida.TabIndex = 0;
            this.lblBienvenida.Text = "label1";
            this.lblBienvenida.Click += new System.EventHandler(this.lblBienvenida_Click);
            // 
            // lblInicio
            // 
            this.lblInicio.AutoSize = true;
            this.lblInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInicio.ForeColor = System.Drawing.Color.White;
            this.lblInicio.Location = new System.Drawing.Point(83, 41);
            this.lblInicio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInicio.Name = "lblInicio";
            this.lblInicio.Size = new System.Drawing.Size(51, 22);
            this.lblInicio.TabIndex = 1;
            this.lblInicio.Text = "Inicio";
            // 
            // IcnHome
            // 
            this.IcnHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.IcnHome.IconChar = FontAwesome.Sharp.IconChar.House;
            this.IcnHome.IconColor = System.Drawing.Color.White;
            this.IcnHome.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IcnHome.IconSize = 39;
            this.IcnHome.Location = new System.Drawing.Point(32, 30);
            this.IcnHome.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.IcnHome.Name = "IcnHome";
            this.IcnHome.Size = new System.Drawing.Size(43, 39);
            this.IcnHome.TabIndex = 0;
            this.IcnHome.TabStop = false;
            this.IcnHome.Click += new System.EventHandler(this.IcnHome_Click);
            // 
            // pnlShadow
            // 
            this.pnlShadow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(24)))), ((int)(((byte)(58)))));
            this.pnlShadow.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlShadow.Location = new System.Drawing.Point(293, 92);
            this.pnlShadow.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlShadow.Name = "pnlShadow";
            this.pnlShadow.Size = new System.Drawing.Size(1299, 12);
            this.pnlShadow.TabIndex = 2;
            // 
            // pnlDesktop
            // 
            this.pnlDesktop.AutoSize = true;
            this.pnlDesktop.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlDesktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.pnlDesktop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDesktop.Location = new System.Drawing.Point(293, 104);
            this.pnlDesktop.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlDesktop.Name = "pnlDesktop";
            this.pnlDesktop.Size = new System.Drawing.Size(1299, 713);
            this.pnlDesktop.TabIndex = 3;
            this.pnlDesktop.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlDesktop_Paint);
            // 
            // frmAdministrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1592, 817);
            this.Controls.Add(this.pnlDesktop);
            this.Controls.Add(this.pnlShadow);
            this.Controls.Add(this.pnlTitleBar);
            this.Controls.Add(this.panelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmAdministrador";
            this.Text = "Panel de Administrador";
            this.Load += new System.EventHandler(this.frmAdministrador_Load);
            this.panelMenu.ResumeLayout(false);
            this.pnlInformes.ResumeLayout(false);
            this.pnlTitleBar.ResumeLayout(false);
            this.pnlTitleBar.PerformLayout();
            this.pnlAdmin.ResumeLayout(false);
            this.pnlAdmin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IcnHome)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private FontAwesome.Sharp.IconButton btnClasificacion;
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
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Panel pnlInformes;
        private FontAwesome.Sharp.IconButton btnInformePendientes;
        private FontAwesome.Sharp.IconButton btnInformeMuelles;
        private FontAwesome.Sharp.IconButton btnInformeUsuario;
        private FontAwesome.Sharp.IconButton btnInformeBuques;
        private FontAwesome.Sharp.IconButton btnCambioContra;
    }
}