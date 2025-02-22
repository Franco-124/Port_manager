namespace Port_manager.Formularios
{
    partial class frmMain
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
            this.btnCerrar_sesion = new System.Windows.Forms.Button();
            this.lbbienvenida = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCerrar_sesion
            // 
            this.btnCerrar_sesion.BackColor = System.Drawing.Color.IndianRed;
            this.btnCerrar_sesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar_sesion.ForeColor = System.Drawing.Color.Black;
            this.btnCerrar_sesion.Location = new System.Drawing.Point(1014, 688);
            this.btnCerrar_sesion.Name = "btnCerrar_sesion";
            this.btnCerrar_sesion.Size = new System.Drawing.Size(181, 37);
            this.btnCerrar_sesion.TabIndex = 0;
            this.btnCerrar_sesion.Text = "Cerrar sesión";
            this.btnCerrar_sesion.UseVisualStyleBackColor = false;
            this.btnCerrar_sesion.Click += new System.EventHandler(this.btnCerrar_sesion_Click);
            // 
            // lbbienvenida
            // 
            this.lbbienvenida.AutoSize = true;
            this.lbbienvenida.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbbienvenida.Location = new System.Drawing.Point(3, 0);
            this.lbbienvenida.Name = "lbbienvenida";
            this.lbbienvenida.Size = new System.Drawing.Size(96, 38);
            this.lbbienvenida.TabIndex = 1;
            this.lbbienvenida.Text = "label1";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.IndianRed;
            this.panel1.Controls.Add(this.lbbienvenida);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1207, 44);
            this.panel1.TabIndex = 2;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1207, 746);
            this.Controls.Add(this.btnCerrar_sesion);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frmMain";
            this.Text = "Port manager";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCerrar_sesion;
        private System.Windows.Forms.Label lbbienvenida;
        private System.Windows.Forms.Panel panel1;
    }
}