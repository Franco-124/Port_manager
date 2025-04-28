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
using SqlConnectiondb;

namespace Port_manager.Formularios
{
    public partial class frmInformeIncidencias : Form
    {
        public frmInformeIncidencias()
        {
            InitializeComponent();
            cargar_datos();

        }

        public void cargar_datos()
        {
            string consulta = "select numero_incidencia, serial_buque, tipo_incidencia, ubicacion, descripcion, estado, from Incidencias";
            using (SqlConnection conexion = DatabaseHelper.GetConnection())
            {
                SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion);
                DataTable tabla = new DataTable();
                adaptador.Fill(tabla);

                dtgIncidencias.AutoGenerateColumns = false;


                dtgIncidencias.DataSource = tabla;

                dtgIncidencias.Columns["numero_incidencia"].DataPropertyName = "numero_incidencia";
                dtgIncidencias.Columns["serial_buque"].DataPropertyName = "buque";
                dtgIncidencias.Columns["tipo_incidencia"].DataPropertyName = "tipo_incidencia";
                dtgIncidencias.Columns["ubicacion"].DataPropertyName = "ubicacion";
                dtgIncidencias.Columns["descripcion"].DataPropertyName = "descripcion";
                dtgIncidencias.Columns["estado"].DataPropertyName = "estado";
            }
        }
    }
}
