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

                // Obtener el rol del usuario
                string role = DatabaseHelper.obtener_rol_current_user(nombre, contraseña);

                

                if (string.IsNullOrWhiteSpace(role))
                {
                    MessageBox.Show("❌ Error al obtener el rol del usuario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                
                UsuarioSesion.NombreUsuario = nombre;
                this.Hide();

                //Redirijimos al panel de usuario
                if (role.Equals("Usuario", StringComparison.OrdinalIgnoreCase))
                {
                    new frmP_Usuario().Show();
                }
                //redirijimos al panel de administrador
                else if (role.Equals("Administrador", StringComparison.OrdinalIgnoreCase))
                {
                    new frmAdministrador().Show();
                }
                else
                {
                    MessageBox.Show("❌ Rol desconocido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.Show(); 
                }
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
            frmCambiocontraseña frmCambiocontraseña = new frmCambiocontraseña();
            frmCambiocontraseña.Show();
            this.Hide();


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
    public static class UsuarioSesion
    {
        public static string NombreUsuario { get; set; }
    }
}