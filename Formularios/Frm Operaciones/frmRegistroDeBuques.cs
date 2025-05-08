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
    public partial class frmRegistroDeBuques : Form
    {
        int contador = 0;
        
        public frmRegistroDeBuques()
        {
            InitializeComponent();
            NroRegistro();
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

        void NroRegistro()
        {
            try
            {
                // Consulta para contar las filas en la tabla Incidencias
                string consulta = "SELECT COUNT(*) FROM RegistroLlegadaBuque";

                using (SqlConnection conexion = DatabaseHelper.GetConnection()) // Obtener la conexión
                {


                    using (SqlCommand cmd = new SqlCommand(consulta, conexion))
                    {
                        // Ejecutar la consulta y obtener el número de filas
                        int numeroFilas = (int)cmd.ExecuteScalar();

                        // Incrementar el contador
                        contador = numeroFilas + 1;

                        // Actualizar el texto del label
                        txtRegistro.Text = contador.ToString();

                    }

                }

            }
            catch (Exception ex)
            {
                // Manejar errores y mostrar un mensaje
                MessageBox.Show("Error al obtener el número de incidencia: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void LlbIncidencia_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string serial_buque = cmbSerialBarco.SelectedItem?.ToString();
            float capacidad = txtCapacidad.Text == "" ? 0 : float.Parse(txtCapacidad.Text);
            string tipo_carga = cmbCarga.SelectedItem?.ToString();
            string responsable = txtResponsable.Text;
            DateTime fecha = dateLlegada.Value;
            string origen = txtOrigen.Text;
            string accion = cmbArribo.SelectedItem?.ToString();



            txtCapacidad.Clear();
            cmbArribo.SelectedIndex = -1;
            cmbCarga.SelectedIndex = -1;
            cmbSerialBarco.SelectedIndex = -1;
            txtOrigen.Clear();
            



            if (string.IsNullOrEmpty(serial_buque) || string.IsNullOrEmpty(origen))                
            {
                MessageBox.Show("Por favor, complete todos los campos.");
                
                return;
            }




            if (DatabaseHelper.Registro_llegada_buque(capacidad, tipo_carga, fecha, origen,UsuarioSesion.id_usuario,accion))
            {
                MessageBox.Show("Ingresado correctamente.");
                NroRegistro();


            }


            else
            {
                MessageBox.Show("Error al ingresar. Por favor, inténtelo de nuevo.");
            }
        }

        void CargarCapacidadBuque(String serial)
        {
            try
            {
                // Validar que el serial no esté vacío
                if (string.IsNullOrEmpty(serial))
                {
                    txtCapacidad.Clear();
                    return;
                }
                // Consulta para obtener la capacidad del buque según el serial
                string consulta = "SELECT capacidad FROM IngresoBuque WHERE serial_buque = @serial_buque";

                using (SqlConnection conexion = DatabaseHelper.GetConnection())
                {
                    using (SqlCommand cmd = new SqlCommand(consulta, conexion))
                    {
                        cmd.Parameters.AddWithValue("@serial_buque", serial);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                txtCapacidad.Text = reader["capacidad"].ToString();
                            }
                            else
                            {
                                txtCapacidad.Clear();
                                MessageBox.Show("No se encontró capacidad para el serial seleccionado.");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la capacidad del buque: " + ex.Message);
            }
        }

        void CargarOrigenBuque(String serial)
        {
            try
            {
                // Validar que el serial no esté vacío
                if (string.IsNullOrEmpty(serial))
                {
                    txtOrigen.Clear();
                    return;
                }
                // Consulta para obtener el origen del buque según el serial
                string consulta = "SELECT origen FROM IngresoBuque WHERE serial_buque = @serial_buque";

                using (SqlConnection conexion = DatabaseHelper.GetConnection())
                {
                    using (SqlCommand cmd = new SqlCommand(consulta, conexion))
                    {
                        cmd.Parameters.AddWithValue("@serial_buque", serial);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                txtOrigen.Text = reader["origen"].ToString();
                            }
                            else
                            {
                                txtOrigen.Clear();
                                MessageBox.Show("No se encontró origen para el serial seleccionado.");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el origen del buque: " + ex.Message);
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbSerial_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Obtener el serial seleccionado
            string serialSeleccionado = (cmbSerialBarco.SelectedItem as frmRegistroDeBuques.ComboBoxItem)?.ToString();

            // Cargar la capacidad y el origen del buque según el serial seleccionado
            CargarCapacidadBuque(serialSeleccionado);
            CargarOrigenBuque(serialSeleccionado);
            txtResponsable.Text = UsuarioSesion.NombreUsuario;
        }

        private void frmRegistroDeBuques_Load(object sender, EventArgs e)
        {
            txtResponsable.Enabled = false;
            txtCapacidad.Enabled = false;
            txtOrigen.Enabled = false;

            // Cargar los seriales en el ComboBox
            CargarSerialBarco();

            // Asociar el evento al ComboBox
            cmbSerialBarco.SelectedIndexChanged += cmbSerial_SelectedIndexChanged;
        }

        private void cmbResponsable_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtResponsable_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

            txtCapacidad.Clear();
            cmbArribo.SelectedIndex = -1;
            cmbCarga.SelectedIndex = -1;
            cmbSerialBarco.SelectedIndex = -1;
            txtResponsable.Clear();
            txtOrigen.Clear();

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
          
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
