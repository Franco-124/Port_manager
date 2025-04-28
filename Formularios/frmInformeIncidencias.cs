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
            string consulta = "select serial_buque,capitan,empresa,origen,fecha_ingreso,capacidad from ingresoBuque";
            using (SqlConnection conexion = DatabaseHelper.GetConnection())
            {
                SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion);
                DataTable tabla = new DataTable();
                adaptador.Fill(tabla);

                dtgIncidencias.AutoGenerateColumns = false;


                dtgIncidencias.DataSource = tabla;

                dtgIncidencias.Columns["serial_buque"].DataPropertyName = "serial_buque";
                dtgIncidencias.Columns["capitan"].DataPropertyName = "capitan";
                dtgIncidencias.Columns["empresa"].DataPropertyName = "empresa";
                dtgIncidencias.Columns["origen"].DataPropertyName = "origen";
                dtgIncidencias.Columns["fecha_ingreso"].DataPropertyName = "fecha_ingreso";
                dtgIncidencias.Columns["capacidad"].DataPropertyName = "capacidad";



            }
        }
    }
}
