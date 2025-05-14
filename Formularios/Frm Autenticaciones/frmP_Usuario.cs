using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;
using FontAwesome.Sharp;
using Port_manager.Formularios.Frm_Operaciones;
using SqlConnectiondb;
using Color = System.Drawing.Color;

namespace Port_manager.Formularios
{
    public partial class frmP_Usuario : Form
    {
        //Fields
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;
        private Form formatoActual;

        public frmP_Usuario()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            panelMenu.Controls.Add(leftBorderBtn);
            pnlInformes.Controls.Add(leftBorderBtn); // Añadir leftBorderBtn al panel de informes
            //Form
            this.Text = string.Empty;
            this.ControlBox = true; // Asegúrate de que los botones de control estén visibles
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            this.FormBorderStyle = FormBorderStyle.Sizable;
            inicial();
        }

        void inicial()
        {
            pnlInformes.Visible = false;
        }

        void ocultarSubmenu()
        {
            if (pnlInformes.Visible == true)
            {
                pnlInformes.Visible = false;
            }
        }

        void mostrarSubmenu(Panel submenu)
        {
            ocultarSubmenu();
            submenu.Visible = true;
        }

        public FrmRecuperarContraseña FrmRecuperarcontraseña
        {
            get => default;
            set
            {
            }
        }

        public frmRegistroDeBuques frmRegistroDeBuques
        {
            get => default;
            set
            {
            }
        }

        public frmGestionUsuario frmGestionUsuario
        {
            get => default;
            set
            {
            }
        }

        //Structs
        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(74, 144, 226);  // Azul claro (Registro de Buques)
            public static Color color2 = Color.FromArgb(39, 174, 96);   // Verde suave (Gestión de Administrador)
            public static Color color3 = Color.FromArgb(243, 156, 18);  // Amarillo oro (Cambio de contraseña)
        }

        //Methods
        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                //Button
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(37,36,81);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage; 
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                //Left border button
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0,currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
                // Icon Current Child Form
                iconCurrentChildForm.IconChar = currentBtn.IconChar;
                iconCurrentChildForm.IconColor = color;
            }
        }
        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(31, 30, 68);
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Gainsboro;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void OpenChildForm(Form childForm)
        {
            if(currentChildForm != null)
            {
                //open only form
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitleChildForm.Text = childForm.Text;
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            OpenChildForm(new frmRegistroDeBuques());
            ocultarSubmenu();
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color2);
            OpenChildForm(new frmIngresoBuque());
            ocultarSubmenu();
        }
        // NO USAR ESTE PRIVATE VOID-----------------------------------------------//
        private void iconButton3_Click(object sender, EventArgs e)
        {
           
        }
        //------------------------------------------------------------------------//
        private void frmP_Usuario_Load(object sender, EventArgs e)
        {
            lbUDate.Text = DateTime.Now.ToString("dd/MM/yyyy");

            if (Regex.IsMatch(UsuarioSesion.NombreUsuario, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                string username = DatabaseHelper.obtener_nombre_usuario(UsuarioSesion.NombreUsuario);
                if (username != null)
                {
                    lbNombre_usuario.Text = $"                       {username} ";
                }

            }
            else
            {
                    lbNombre_usuario.Text = $"                          {UsuarioSesion.NombreUsuario}   ";
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Reset();
            if (formatoActual != null)
            {
                formatoActual.Close();
            }

        }

        private void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;
            iconCurrentChildForm.IconChar = IconChar.House;
            iconCurrentChildForm.IconColor = Color.Gainsboro;
            lblTitleChildForm.Text = "Inicio";
        }

        //Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {

            this.Hide();
            frmLogin login = new frmLogin();
            login.StartPosition = FormStartPosition.CenterScreen;
            login.Size = new System.Drawing.Size(1005, 720); // Cambiado de System.Windows.Size a System.Drawing.Size  
            login.Show();
            this.Close();
        }

        private void iconButton3_Click_1(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color3);
            OpenChildForm(new frmCambiocontraseña());
            ocultarSubmenu();
        }

        //Boton de informes
        private void btnGestionAdb_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color2);
            mostrarSubmenu(pnlInformes);
        }

        private void btnInformeIncidencias_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            OpenChildForm(new frmInformeIncidencias());
        }

        private void btnInformeBuque_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            OpenChildForm(new frmInformeBuqueUsuario());
        }

        private void lblTitleChildForm_Click(object sender, EventArgs e)
        {

        }

        public frmInformeBuqueUsuario frmInformeBuqueUsuario
        {
            get => default;
            set
            {
            }
        }

        public frmInformeIncidencias frmInformeIncidencias
        {
            get => default;
            set
            {
            }
        }

        public frmIngresoBuque frmIngresoBuque
        {
            get => default;
            set
            {
            }
        }

        public frmCambiocontraseña frmCambiocontraseña
        {
            get => default;
            set
            {
            }
        }

        private void btnClasificacion_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            OpenChildForm(new frmAsignacionMuelleUsuario());
        }

        public frmAsignacionMuelleUsuario frmAsignacionMuelleUsuario
        {
            get => default;
            set
            {
            }
        }
    }
}
