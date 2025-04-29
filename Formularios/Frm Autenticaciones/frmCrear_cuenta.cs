using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using Port_manager.Clases;
using SqlConnectiondb;

namespace Port_manager.Formularios
{

    // Hola
    public partial class frmCrear_cuenta : Form
    {
        public frmCrear_cuenta()
        {
            InitializeComponent();
        }

        private void frmCrear_cuenta_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmLogin frm = new frmLogin();
            frm.Show();
            this.Hide();
            System.Windows.Forms.Application.Exit();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            string nombre = txtNombre.Text;
            string email = txtEmail.Text;
            string contraseña = txtContraseña.Text;
            string confirmar_contraseña = txtCcontraseña.Text;
            string codigo_admin = txtCodigo.Text;
            string rol= cmbRol_user.SelectedItem?.ToString();

            try
            {
             
                nombre = nombre.Trim();
                email = email.Trim();
                contraseña = contraseña.Trim();
                confirmar_contraseña = confirmar_contraseña.Trim();



                if (string.IsNullOrWhiteSpace(nombre) ||
                    string.IsNullOrWhiteSpace(email) ||
                    string.IsNullOrWhiteSpace(contraseña) ||
                    string.IsNullOrWhiteSpace(confirmar_contraseña)
                    || string.IsNullOrWhiteSpace(rol))
                {
                    MessageBox.Show("❌ Por favor, rellene todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; 
                }

                if (!Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
                {
                    MessageBox.Show("❌ El formato del correo electrónico no es válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }


                if (contraseña != confirmar_contraseña)
                {
                    MessageBox.Show("❌ Las contraseñas no coinciden.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!chkTerminoC.Checked)
                {
                    MessageBox.Show("❌ Por favor, acepte los términos y condiciones.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if(rol == "Administrador")
                {
                    if (codigo_admin != Credentials.admin_code)
                    {
                        MessageBox.Show("❌ No tenes permiso mamahuevo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                
                if (DatabaseHelper.agregar_usuario_(nombre, email, contraseña, rol))
                {
                    MessageBox.Show("✅ Usuario agregado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmLogin frm = new frmLogin();
                    frm.Show();
                    this.Close();

                }
                else
                {
                    MessageBox.Show("❌ Error al agregar el usuario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Error inesperado: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }




        private void txtContraseña_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtNombre_Leave(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text.Trim();

            if (!string.IsNullOrEmpty(nombre))
            {
                bool existe = DatabaseHelper.verificar_nombre_usuario(nombre);

                if (existe)
                {
                    MessageBox.Show("❌ El nombre de usuario ya está en uso. Por favor, elige otro.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtNombre.Focus(); 
                }
            }


        }

        private void cmbRol_user_SelectedIndexChanged(object sender, EventArgs e)
        {
            string rol = cmbRol_user.SelectedItem?.ToString();
            if (rol.Equals("Usuario", StringComparison.OrdinalIgnoreCase))
            {
                txtCodigo.Visible = false;
                return; 
            }
            else
            {
                txtCodigo.Visible = true;
            }
        }
    }
}