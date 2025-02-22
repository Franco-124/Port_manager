using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;

using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using SqlConnectiondb;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;



namespace Port_manager.Formularios
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {


            if (Regex.IsMatch(UsuarioSesion.NombreUsuario, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                string username = DatabaseHelper.obtener_nommbre_usuario(UsuarioSesion.NombreUsuario);
                if (username  != null)
                {
                    lbbienvenida.Text = $"                               ✨ Bienvenido al sistema, {username} ✨      ";
                }

            }
            else
            {
            lbbienvenida.Text = $"                               ✨ Bienvenido al sistema, {UsuarioSesion.NombreUsuario} ✨      ";
            }
           
        }

        private void btnCerrar_sesion_Click(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();
            login.Show();
            this.Close();
        }
    }
}
