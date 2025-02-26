using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Port_manager.Formularios;
using SqlConnectiondb;

namespace Port_manager
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string nombre = txtEnombre.Text;
            string email = txtEnombre.Text; 
            string contraseña = txtPassword.Text;

            
            if (string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(email) ||
                string.IsNullOrWhiteSpace(contraseña))
            {
                MessageBox.Show("❌ Por favor, rellene todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


           
            if (!cbkterminos.Checked)
            {
                MessageBox.Show("❌ Por favor, acepte los términos y condiciones.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


           
            if (DatabaseHelper.VerificarLogin(nombre, email, contraseña))
            {
                MessageBox.Show("✅ Inicio de sesión exitoso.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Hide(); // Ocultar formulario actual
                UsuarioSesion.NombreUsuario = nombre;
                frmMain mainForm = new frmMain();
                mainForm.Show();
            }
            else
            {
                MessageBox.Show("❌ Usuario o contraseña incorrectos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }

        private void btnCrear_cuenta_Click(object sender, EventArgs e)
        {
            try
            {
                frmCrear_cuenta frmCrear_Cuenta = new frmCrear_cuenta();
                frmCrear_Cuenta.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al abrir el formulario: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtEnombre_Leave(object sender, EventArgs e)
        {
           
           

        }

        private void txtEnombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnolvidocontraseña_Click(object sender, EventArgs e)
        {
            frmRecuperacion frmRecuperacion = new frmRecuperacion();
            frmRecuperacion.Show();
            this.Hide();

        }
    }
    public static class UsuarioSesion
    {
        public static string NombreUsuario { get; set; }
    }
}