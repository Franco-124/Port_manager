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
        }

        private void frmAsignacionMuelleUsuario_Load(object sender, EventArgs e)
        {

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



    }
}
