﻿namespace Port_manager
{
    partial class frmLogin
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnolvidocontraseña = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCrear_cuenta = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.cbkterminos = new System.Windows.Forms.CheckBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtEnombre = new System.Windows.Forms.TextBox();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(567, 773);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnolvidocontraseña);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.btnCrear_cuenta);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.btnLogin);
            this.panel2.Controls.Add(this.cbkterminos);
            this.panel2.Controls.Add(this.txtPassword);
            this.panel2.Controls.Add(this.txtEnombre);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel2.Location = new System.Drawing.Point(567, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(665, 773);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // btnolvidocontraseña
            // 
            this.btnolvidocontraseña.BackColor = System.Drawing.Color.White;
            this.btnolvidocontraseña.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnolvidocontraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnolvidocontraseña.Location = new System.Drawing.Point(412, 355);
            this.btnolvidocontraseña.Name = "btnolvidocontraseña";
            this.btnolvidocontraseña.Size = new System.Drawing.Size(225, 30);
            this.btnolvidocontraseña.TabIndex = 12;
            this.btnolvidocontraseña.Text = "¿Olvido su contraseña?";
            this.btnolvidocontraseña.UseVisualStyleBackColor = false;
            this.btnolvidocontraseña.Click += new System.EventHandler(this.btnolvidocontraseña_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(83, 217);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(236, 31);
            this.label5.TabIndex = 11;
            this.label5.Text = "Ingrese su contraseña";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(80, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(407, 31);
            this.label4.TabIndex = 10;
            this.label4.Text = "Ingrese su nombre de usuario o E-mail";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(180, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(335, 59);
            this.label2.TabIndex = 9;
            this.label2.Text = "Inicio de sesión";
            // 
            // btnCrear_cuenta
            // 
            this.btnCrear_cuenta.BackColor = System.Drawing.Color.White;
            this.btnCrear_cuenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrear_cuenta.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrear_cuenta.Location = new System.Drawing.Point(85, 621);
            this.btnCrear_cuenta.Name = "btnCrear_cuenta";
            this.btnCrear_cuenta.Size = new System.Drawing.Size(552, 54);
            this.btnCrear_cuenta.TabIndex = 8;
            this.btnCrear_cuenta.Text = "Crear Cuenta";
            this.btnCrear_cuenta.UseVisualStyleBackColor = false;
            this.btnCrear_cuenta.Click += new System.EventHandler(this.btnCrear_cuenta_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(343, 550);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 38);
            this.label3.TabIndex = 7;
            this.label3.Text = "O";
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.White;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(85, 472);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(552, 52);
            this.btnLogin.TabIndex = 6;
            this.btnLogin.Text = "Iniciar Sesión";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // cbkterminos
            // 
            this.cbkterminos.AutoSize = true;
            this.cbkterminos.BackColor = System.Drawing.Color.Transparent;
            this.cbkterminos.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbkterminos.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.cbkterminos.Location = new System.Drawing.Point(86, 361);
            this.cbkterminos.Name = "cbkterminos";
            this.cbkterminos.Size = new System.Drawing.Size(239, 24);
            this.cbkterminos.TabIndex = 4;
            this.cbkterminos.Text = "Aceptar terminos y condiciones";
            this.cbkterminos.UseVisualStyleBackColor = false;
            this.cbkterminos.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.White;
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(85, 279);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(552, 38);
            this.txtPassword.TabIndex = 3;
            // 
            // txtEnombre
            // 
            this.txtEnombre.BackColor = System.Drawing.Color.White;
            this.txtEnombre.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEnombre.ForeColor = System.Drawing.Color.Black;
            this.txtEnombre.Location = new System.Drawing.Point(85, 142);
            this.txtEnombre.Name = "txtEnombre";
            this.txtEnombre.Size = new System.Drawing.Size(552, 38);
            this.txtEnombre.TabIndex = 2;
            this.txtEnombre.TextChanged += new System.EventHandler(this.txtEnombre_TextChanged);
            this.txtEnombre.Leave += new System.EventHandler(this.txtEnombre_Leave);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1232, 773);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frmLogin";
            this.Text = "Port manager";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtEnombre;
        private System.Windows.Forms.Button btnCrear_cuenta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.CheckBox cbkterminos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnolvidocontraseña;
    }
}

