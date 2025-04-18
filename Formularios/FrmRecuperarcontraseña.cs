using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Port_manager.Clases;
using SqlConnectiondb;

namespace Port_manager.Formularios
{
    public partial class FrmRecuperarcontraseña: Form
    {
        public FrmRecuperarcontraseña()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmLogin frmLogin = new frmLogin();
            frmLogin.Show();
            this.Close();
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            string Email = txtEmail.Text;
            string User_name = txtNombre_usuario.Text;

            if (string.IsNullOrWhiteSpace(Email))
            {
                MessageBox.Show("Por favor, ingrese su correo electrónico.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(User_name))
            {
                MessageBox.Show("Por favor, ingrese su nombre de usuario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string Temp_password = Enviar_email.GenerarContraseñaTemporal();

            if (string.IsNullOrEmpty(Temp_password))
            {
                MessageBox.Show("Error al generar la contraseña temporal.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            bool update_password = DatabaseHelper.actualizar_contraseña(Temp_password, User_name, Email);
            if (!update_password)
            {
                MessageBox.Show("Error al actualizar la contraseña en la base de datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string enviar = Enviar_email.EnviarCorreo(Email, Temp_password);
            if (enviar == "correcto")
            {
                MessageBox.Show("Correo enviado con éxito, inicie sesion con su contraseña temporal", "Correo enviado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frmLogin frmLogin = new frmLogin();
                frmLogin.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Error al enviar el correo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

            

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            frmLogin frmLogin = new frmLogin();
            frmLogin.Show();
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }
    }
}
