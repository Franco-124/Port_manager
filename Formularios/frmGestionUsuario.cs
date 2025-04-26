using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SqlConnectiondb;

namespace Port_manager.Formularios
{
    public partial class frmGestionUsuario : Form
    {
        public frmGestionUsuario()
        {
            InitializeComponent();
            cargar_datos();
        }

        
        //Metodo para cargar valores al Datagrid de informe de usuarios.
        public void cargar_datos()
        {
            string consulta = "select id_usuario, nombre_usuario, email, rol from usuarios";
            using (SqlConnection conexion = DatabaseHelper.GetConnection()) 
            {
                SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion);
                DataTable tabla = new DataTable();
                adaptador.Fill(tabla);

                dtgUsuarios.AutoGenerateColumns = false; 
                dtgUsuarios.DataSource = tabla;

                
                dtgUsuarios.Columns["id_usuario"].DataPropertyName = "id_usuario";
                dtgUsuarios.Columns["nombre_usuario"].DataPropertyName = "nombre_usuario";
                dtgUsuarios.Columns["email"].DataPropertyName = "email";
                dtgUsuarios.Columns["rol"].DataPropertyName = "rol";

            }
        }
    }
}
