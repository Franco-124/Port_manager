﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SqlConnectiondb;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Port_manager.Formularios
{
    public partial class frmCambiocontraseña: Form
    {
        public frmCambiocontraseña()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnVolverlogin_Click(object sender, EventArgs e)
        {
           
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                string contraseña = txtContraseña.Text;
                string nueva_contraseña = txtNuevacontraseña.Text;
                string conf_contraseña = txtCnuevacontraseña.Text;

                if (string.IsNullOrWhiteSpace(contraseña) || string.IsNullOrWhiteSpace(nueva_contraseña) ||
                    string.IsNullOrWhiteSpace(conf_contraseña))
                {
                    MessageBox.Show("❌ No ha completado todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (nueva_contraseña != conf_contraseña)
                {
                    MessageBox.Show("⚠ Las contraseñas nuevas no coinciden.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (contraseña != UsuarioSesion.contraseña)
                {
                    MessageBox.Show("⚠ Contraseña actual incorrecta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (nueva_contraseña == UsuarioSesion.contraseña)
                {
                    MessageBox.Show("⚠ La nueva contraseña no puede ser igual a la actual", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DialogResult dialogResult = MessageBox.Show("¿Está seguro de que desea cambiar su contraseña?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.No)
                {
                    txtNuevacontraseña.Clear();
                    txtCnuevacontraseña.Clear();
                    txtContraseña.Clear();
                    return;
                }

              
                string result = DatabaseHelper.cambiar_contraeña(contraseña, nueva_contraseña, UsuarioSesion.NombreUsuario);

                MessageBox.Show(result, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtNuevacontraseña.Clear();
                txtCnuevacontraseña.Clear();
                txtContraseña.Clear();


            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
