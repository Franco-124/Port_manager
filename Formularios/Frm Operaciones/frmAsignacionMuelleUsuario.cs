using SqlConnectiondb;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Port_manager.Formularios.Frm_Operaciones
{
    public partial class frmAsignacionMuelleUsuario : Form
    {
        private ToolTip toolTipZonas = new ToolTip();
        public frmAsignacionMuelleUsuario()
        {
            InitializeComponent();
            toolTipZonas = new ToolTip();
            CargarInfoZonas();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;

        }

        private void frmAsignacionMuelleUsuario_Load(object sender, EventArgs e)
        {
            // Asegúrate de que estos botones existen en el formulario
            pictureBox1.Controls.Add(btnZonaA);
            pictureBox1.Controls.Add(btnZonaB);
            pictureBox1.Controls.Add(btnZonaC);
            pictureBox1.Controls.Add(btnZonaD);
            pictureBox1.Controls.Add(btnZonaE);
            pictureBox1.Controls.Add(btnZonaF);
            pictureBox1.Controls.Add(btnZonaG);

            ReubicarBotones(); // Ajustar posiciones iniciales// Asegúrate de que estos botones existen en el formulario
        }



        private DataTable ObtenerInfoZonas(int idUsuarioActual)
        {
            string query = @"
            SELECT ro.id_muelle, ro.serial_buque, ro.tipo_carga, ro.capacidad, ro.accion, ro.descripcion, ro.fecha_operacion
            FROM Registro_Operacion ro
            INNER JOIN IngresoBuque ib ON ro.serial_buque = ib.serial_buque
            WHERE ib.id_usuario = @idUsuario
            ";

            using (SqlConnection conn = DatabaseHelper.GetConnection())
            using (SqlDataAdapter da = new SqlDataAdapter(query, conn))
            {
                da.SelectCommand.Parameters.AddWithValue("@idUsuario", idUsuarioActual);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }


        private void CargarInfoZonas()
        {
            int idUsuarioActual = UsuarioSesion.id_usuario; // Ajusta según tu implementación
            DataTable zonas = ObtenerInfoZonas(idUsuarioActual);

            // Obtén la lista de zonas (id_muelle) asignadas al usuario
            var zonasUsuario = zonas.AsEnumerable()
                .Select(row => row["id_muelle"]?.ToString()?.Trim())
                .Where(val => !string.IsNullOrEmpty(val))
                .Distinct()
                .ToList();

            foreach (char letra in "ABCDEFG")
            {
                string idMuelle = $"Zona {letra}";
                string nombreBoton = $"btnZona{letra}";
                Button btn = this.Controls.Find(nombreBoton, true).FirstOrDefault() as Button;
                if (btn != null)
                {
                    btn.Text = $"Zona {letra}";
                    if (zonasUsuario.Contains(idMuelle))
                    {
                        toolTipZonas.SetToolTip(btn, "Esta es tu zona asignada.");
                        btn.BackColor = Color.LightGreen;
                    }
                    else
                    {
                        toolTipZonas.SetToolTip(btn, "No tienes asignación en esta zona.");
                        btn.BackColor = Color.LightGray;
                    }
                }
            }
        }

        private void ReubicarBotones()
        {
            int baseWidth = 900;
            int baseHeight = 407;

            float scaleX = (float)pictureBox1.Width / baseWidth;
            float scaleY = (float)pictureBox1.Height / baseHeight;

            btnZonaA.Left = (int)(290 * scaleX);
            btnZonaA.Top = (int)(24 * scaleY);

            btnZonaB.Left = (int)(400 * scaleX);
            btnZonaB.Top = (int)(113 * scaleY);

            btnZonaC.Left = (int)(520 * scaleX);
            btnZonaC.Top = (int)(113 * scaleY);

            btnZonaD.Left = (int)(650 * scaleX);
            btnZonaD.Top = (int)(113 * scaleY);

            btnZonaE.Left = (int)(160 * scaleX);
            btnZonaE.Top = (int)(232 * scaleY);

            btnZonaF.Left = (int)(400 * scaleX);
            btnZonaF.Top = (int)(232 * scaleY);

            btnZonaG.Left = (int)(650 * scaleX);
            btnZonaG.Top = (int)(232 * scaleY);

            buttonEntrada.Left = (int)(160 * scaleX);
            buttonEntrada.Top = (int)(42 * scaleY);
        }

        private void frmAsignacionMuelleUsuario_Resize(object sender, EventArgs e)
        {
            ReubicarBotones();
        }

        private void pictureBox1_Resize(object sender, EventArgs e)
        {
            ReubicarBotones();
        }

        private void lblRegistro_Click(object sender, EventArgs e)
        {

        }
    }
}
