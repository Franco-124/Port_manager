﻿namespace Port_manager.Formularios
{
    partial class frmRecuperacion
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnVolverlogin = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Tomato;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-1, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(914, 74);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(274, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(383, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Recuperación de contraseña";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.btnVolverlogin);
            this.panel2.Location = new System.Drawing.Point(-1, 84);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(914, 428);
            this.panel2.TabIndex = 1;
            // 
            // btnVolverlogin
            // 
            this.btnVolverlogin.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnVolverlogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolverlogin.ForeColor = System.Drawing.Color.Black;
            this.btnVolverlogin.Location = new System.Drawing.Point(795, 3);
            this.btnVolverlogin.Name = "btnVolverlogin";
            this.btnVolverlogin.Size = new System.Drawing.Size(116, 30);
            this.btnVolverlogin.TabIndex = 0;
            this.btnVolverlogin.Text = "Volver";
            this.btnVolverlogin.UseVisualStyleBackColor = false;
            this.btnVolverlogin.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmRecuperacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 517);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmRecuperacion";
            this.Text = "Recuperación de contraseña";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnVolverlogin;
    }
}