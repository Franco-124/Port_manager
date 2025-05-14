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

        public frmP_Usuario frmP_Usuario
        {
            get => default;
            set
            {
            }
        }

        public frmCrear_cuenta frmCrear_cuenta
        {
            get => default;
            set
            {
            }
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

            int id_usuario = DatabaseHelper.obtener_id_usuario(nombre, contraseña);
            UsuarioSesion.id_usuario = id_usuario;

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
                UsuarioSesion.contraseña = contraseña;
                this.Hide();

                //Redirijimos al panel de usuario
                if (role.Equals("Usuario", StringComparison.OrdinalIgnoreCase))
                {
                    MessageBox.Show("Bienvenido al sistema " + nombre);
                    new frmP_Usuario().Show();
                }
                //redirijimos al panel de administrador
                else if (role.Equals("Administrador", StringComparison.OrdinalIgnoreCase))
                {
                    MessageBox.Show("Bienvenido al sistema " + nombre);
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
                this.Hide();
                frmCrear_cuenta login = new frmCrear_cuenta();
                login.StartPosition = FormStartPosition.CenterScreen;
                login.Size = new System.Drawing.Size(1005, 720); // Cambiado de System.Windows.Size a System.Drawing.Size  
                login.Show();
                
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
            FrmRecuperarContraseña  frmRecuperarcontraseña = new FrmRecuperarContraseña();
            frmRecuperarcontraseña.Show();
            this.Hide();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
    public static class UsuarioSesion
    {
      
        public static string NombreUsuario { get; set; }
        public static string contraseña { get; set; }

        public static string email { get; set; }

        public static int id_usuario { get; set; }

    }
}