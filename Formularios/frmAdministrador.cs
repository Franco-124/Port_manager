using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using System.Windows.Media;
using FontAwesome.Sharp;
using SqlConnectiondb;
using Color = System.Drawing.Color;

namespace Port_manager.Formularios
{
    public partial class frmAdministrador : Form
    {
        //campos
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form formatoActual;

        //constructores
        public frmAdministrador()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new System.Drawing.Size(7, 60);
            panelMenu.Controls.Add(leftBorderBtn);
        }

        //colores botones
        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(74, 144, 226);  // Azul claro (Clasificación y Asignación de Muelles)
            public static Color color2 = Color.FromArgb(94, 96, 206);   // Azul violeta (Carga/Descarga de Carga)
            public static Color color3 = Color.FromArgb(230, 126, 34);  // Naranja fuerte (Registro de incidencias)
            public static Color color4 = Color.FromArgb(39, 174, 96);   // Verde suave (Gestión de Administrador)
            public static Color color5 = Color.FromArgb(243, 156, 18);  // Amarillo oro (Cambio de contraseña)

        }

        //metodos
        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                //boton
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(37, 36, 81);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;

                //boton izquierdo
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new System.Drawing.Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();

                

                //icono inicio
                IcnHome.IconChar = currentBtn.IconChar;
                IcnHome.IconColor = color;


            }
        }

        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(31, 30, 68);
                currentBtn.ForeColor = Color.White;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.White;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnClasificacion_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            AbrirFormularioHijo(new frmClasificacionAsignacion());
        }

        private void btnCargaDescarga_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color2);
            AbrirFormularioHijo(new frmCargaDescarga());
        }

        private void btnIncidencias_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color3);
            AbrirFormularioHijo(new frmIncidencias());
        }

        private void btnGestionAdb_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color4);
            AbrirFormularioHijo(new frmGestionAdmin());
        }

        private void btnCambioContra_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color5);
            AbrirFormularioHijo(new frmCambiocontraseña());
        }

        private void frmAdministrador_Load(object sender, EventArgs e)
        {
            lbDate.Text = DateTime.Now.ToString("dd/MM/yyyy");

            if (Regex.IsMatch(UsuarioSesion.NombreUsuario, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                string username = DatabaseHelper.obtener_nommbre_usuario(UsuarioSesion.NombreUsuario);
                if (username != null)
                {
                    lblBienvenida.Text = $"                       {username} ";
                }

            }
            else
            {
                lblBienvenida.Text = $"                          {UsuarioSesion.NombreUsuario}   ";
            }
        }

        private void pnlDesktop_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AbrirFormularioHijo(Form formHijo)
        {
            if(formatoActual!= null)
            {
                formatoActual.Close();
            }
            formatoActual = formHijo;
            formHijo.TopLevel = false;
            formHijo.FormBorderStyle = FormBorderStyle.None;
            formHijo.Dock = DockStyle.Fill;
            pnlDesktop.Controls.Add(formHijo);
            pnlDesktop.Tag = formHijo;
            formHijo.BringToFront();
            formHijo.Show();
            lblInicio.Text = formHijo.Text;

        }


        private void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;
            IcnHome.IconChar = currentBtn.IconChar;
            IcnHome.IconColor = Color.White;
            lblInicio.Text = "Inicio";
        }

        private void panelLogo_Click_1(object sender, EventArgs e)
        {
            Reset();
            formatoActual.Close();
        }

        private void IcnHome_Click(object sender, EventArgs e)
        {

        }

        private void pnlTitleBar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();
            login.Show();
            this.Close();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            

        }

        private void lblBienvenida_Click(object sender, EventArgs e)
        {

        }
    }
}
