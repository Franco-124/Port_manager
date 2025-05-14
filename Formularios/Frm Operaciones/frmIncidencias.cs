using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using SqlConnectiondb;

namespace Port_manager.Formularios
{
    public partial class frmIncidencias: Form
    {
        int contador = 0;
        public frmIncidencias()
        {
            InitializeComponent();
            

            NroIncidencia();

        }     

        void CargarSerialBarco()
        {
            cmbSerialBarco.Items.Clear();
            try
            {
                string consulta = "SELECT serial_buque FROM IngresoBuque";
                using (SqlConnection conexion = DatabaseHelper.GetConnection())
                {
                    using (SqlCommand cmd = new SqlCommand(consulta, conexion))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                cmbSerialBarco.Items.Add(new ComboBoxItem(reader["serial_buque"].ToString()));
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el serial de los buques: " + ex.Message);
            }
        }


        public class ComboBoxItem
        {
            public string Serial_Buque { get; set; }

            public ComboBoxItem(string serial_buque)
            {
                Serial_Buque = serial_buque;
            }
            public override string ToString()
            {
                return Serial_Buque; // Esto es lo que se mostrará en el ComboBox
            }
        }

        void NroIncidencia()
        {
            try
            {
                // Consulta para contar las filas en la tabla Incidencias
                string consulta = "SELECT COUNT(*) FROM Incidencias";

                using (SqlConnection conexion = DatabaseHelper.GetConnection()) // Obtener la conexión
                {
                    

                    using (SqlCommand cmd = new SqlCommand(consulta, conexion))
                    {
                        // Ejecutar la consulta y obtener el número de filas
                        int numeroFilas = (int)cmd.ExecuteScalar();

                        // Incrementar el contador
                        contador = numeroFilas + 1;

                        // Actualizar el texto del label
                        txtNumeroIncidencia.Text = contador.ToString();

                    }
                    
                }

            }
            catch (Exception ex)
            {
                // Manejar errores y mostrar un mensaje
                MessageBox.Show("Error al obtener el número de incidencia: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbSerialBarco_Leave(object sender, EventArgs e)
        {
            
        }

        private void cmbSerialBarco_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void frmIncidencias_Load(object sender, EventArgs e)
        {
            CargarSerialBarco();
        }

        public frmInformeIncidencias frmInformeIncidencias
        {
            get => default;
            set
            {
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            string serial_buque = cmbSerialBarco.SelectedItem?.ToString();
            string Ubicacion = cmbUbicacion.SelectedItem?.ToString();
            string Descripcion = txtDescripcion.Text;
            string tipo_Incidencia = cmbTipo.SelectedItem?.ToString();
            string estado = cmbEstado.SelectedItem?.ToString();


            txtDescripcion.Clear();
            cmbSerialBarco.SelectedIndex=-1;
            cmbUbicacion.SelectedIndex = -1;
            cmbTipo.SelectedIndex = -1;
            cmbEstado.Items.Clear();



            if (string.IsNullOrEmpty(serial_buque) || string.IsNullOrEmpty(Ubicacion) ||
                string.IsNullOrEmpty(Descripcion) || string.IsNullOrEmpty(tipo_Incidencia) || string.IsNullOrEmpty(estado) )
            {
                MessageBox.Show("Por favor, complete todos los campos.");
                return;
            }
                    

         

            if (DatabaseHelper.agregar_Incidencia(serial_buque,Ubicacion,Descripcion,tipo_Incidencia, estado,UsuarioSesion.NombreUsuario, UsuarioSesion.id_usuario))
            {
                MessageBox.Show("Incidencia ingresada correctamente.");
                
                NroIncidencia();


            }


            else
            {
                MessageBox.Show("Error al ingresar la incidencia. Por favor, inténtelo de nuevo.");
            }
        }

        private void btnCamcelar_Click(object sender, EventArgs e)
        {

        }
    }
}
