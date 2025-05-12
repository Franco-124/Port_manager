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
using Word = Microsoft.Office.Interop.Word;
using System.IO;
namespace Port_manager.Formularios
{
    public partial class frmInformeBuqueUsuario : Form
    {
        public frmInformeBuqueUsuario()
        {
            InitializeComponent();
            cargar_datos();
        }

        public void cargar_datos()
        {
            string consulta = $"select serial_buque,capitan,empresa,origen,fecha_ingreso,capacidad from ingresoBuque where id_usuario = {UsuarioSesion.id_usuario}";
            using (SqlConnection conexion = DatabaseHelper.GetConnection())
            {
                SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion);
                DataTable tabla = new DataTable();
                adaptador.Fill(tabla);

                dtgBuque.AutoGenerateColumns = false;


                dtgBuque.DataSource = tabla;

                dtgBuque.Columns["serial_buque"].DataPropertyName = "serial_buque";
                dtgBuque.Columns["capitan"].DataPropertyName = "capitan";
                dtgBuque.Columns["empresa"].DataPropertyName = "empresa";
                dtgBuque.Columns["origen"].DataPropertyName = "origen";
                dtgBuque.Columns["fecha_ingreso"].DataPropertyName = "fecha_ingreso";
                dtgBuque.Columns["capacidad"].DataPropertyName = "capacidad";



            }
        }

        private void frmInformeBuqueUsuario_Load(object sender, EventArgs e)
        {

        }
    }
}
