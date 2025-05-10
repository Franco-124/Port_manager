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

namespace Port_manager.Formularios
{
   
    public partial class frmClasificacionAsignacion: Form
    {
        private ToolTip toolTipZonas = new ToolTip();
        public frmClasificacionAsignacion()
        {
            InitializeComponent();
            toolTipZonas = new ToolTip();
            CargarInfoZonas();
        }

        public FrmInformeMuelle FrmInformeMuelle
        {
            get => default;
            set
            {
            }
        }

        public Frm_Operaciones.frmAsignacionMuelleUsuario frmAsignacionMuelleUsuario
        {
            get => default;
            set
            {
            }
        }

        private void frmClasificacionAsignacion_Load(object sender, EventArgs e)
        {

        }


        private DataTable ObtenerInfoZonas()
        {
            string query = @"
        SELECT id_muelle, serial_buque, tipo_carga, capacidad, accion, descripcion, fecha_operacion
        FROM Registro_Operacion";

            using (SqlConnection conn = DatabaseHelper.GetConnection())
            using (SqlDataAdapter da = new SqlDataAdapter(query, conn))
            {
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }



        private void CargarInfoZonas()
        {
            DataTable zonas = ObtenerInfoZonas();

            // Agrupa los registros por id_muelle exactamente como están en la base de datos
            var zonasAgrupadas = zonas.AsEnumerable()
                .GroupBy(row =>
                {
                    var val = row["id_muelle"]?.ToString()?.Trim();
                    return string.IsNullOrEmpty(val) ? "" : val;
                })
                .ToDictionary(
                    g => g.Key,
                    g => g.Select(row =>
                        $"Buque: {row["serial_buque"]}\n" +
                        $"Carga: {row["tipo_carga"]}\n" +
                        $"Capacidad: {row["capacidad"]}\n" +
                        $"Acción: {row["accion"]}"
                    ).ToList()
                );

            // Para cada letra de la A a la G
            foreach (char letra in "ABCDEFG")
            {
                string idMuelle = $"Zona {letra}";
                string nombreBoton = $"btnZona{letra}";
                Button btn = this.Controls.Find(nombreBoton, true).FirstOrDefault() as Button;
                if (btn != null)
                {
                    btn.Text = $"Zona {letra}";
                    btn.BackColor = Color.LightGray;

                    if (zonasAgrupadas.ContainsKey(idMuelle))
                    {
                        string tooltipText = string.Join("\n\n", zonasAgrupadas[idMuelle]);
                        toolTipZonas.SetToolTip(btn, tooltipText);
                        btn.BackColor = Color.LightGreen;
                    }
                    else
                    {
                        toolTipZonas.SetToolTip(btn, "Sin información registrada.");
                    }
                }
            }
        }




    }
}
