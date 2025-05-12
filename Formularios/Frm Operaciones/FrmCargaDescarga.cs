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
    public partial class frmCargaDescarga: Form
    {
        int contador = 0;
        public frmCargaDescarga()
        {
            InitializeComponent();
            NroOperacion();
        }

        public frmInformePendientes frmInformePendientes
        {
            get => default;
            set
            {
            }
        }


        private (int capacidad, string tipoCarga) ObtenerDatosBarco(string serialBuque)
        {
            try
            {
                // Consulta para obtener la capacidad y el tipo de carga del barco
                string consulta = @"
            SELECT rl.capacidad, rl.tipo_carga
            FROM RegistroLlegadaBuque rl
            JOIN IngresoBuque ib ON rl.origen = ib.origen
            WHERE ib.serial_buque = @serial_buque";

                using (SqlConnection conexion = DatabaseHelper.GetConnection())
                {
                    using (SqlCommand cmd = new SqlCommand(consulta, conexion))
                    {
                        cmd.Parameters.AddWithValue("@serial_buque", serialBuque);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                int capacidad = Convert.ToInt32(reader["capacidad"]);
                                string tipoCarga = reader["tipo_carga"].ToString();
                                return (capacidad, tipoCarga);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener los datos del barco: " + ex.Message);
            }

            return (0, string.Empty); // Retornar valores por defecto si ocurre un error
        }

        private void CargarSerialesBarcos()
        {
            try
            {
                // Consulta para obtener los seriales de los barcos filtrados por usuario
                string consulta = "SELECT serial_buque FROM IngresoBuque";

                using (SqlConnection conexion = DatabaseHelper.GetConnection())
                {
                    using (SqlCommand cmd = new SqlCommand(consulta, conexion))
                    {
                        // Agregar el parámetro para filtrar por usuario
                     

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            cmbSerialBarco.Items.Clear();

                            while (reader.Read())
                            {
                                cmbSerialBarco.Items.Add(reader["serial_buque"].ToString());
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los seriales de los barcos: " + ex.Message);
            }
        }

        private void FiltrarZonasDesdeBaseDatos(int capacidadBarco, string tipoCargaBarco)
        {
            try
            {
                // Consulta SQL para obtener las zonas disponibles
                string consulta = @"
            SELECT id_muelle, capacidad_muelle, tipo_muelle
            FROM Muelle
            WHERE capacidad_muelle >= @capacidadBarco
              AND tipo_muelle = @tipoCargaBarco
              AND estado = 0"; // Solo muelles disponibles

                using (SqlConnection conexion = DatabaseHelper.GetConnection())
                {
                    using (SqlCommand cmd = new SqlCommand(consulta, conexion))
                    {
                        // Agregar parámetros a la consulta
                        cmd.Parameters.AddWithValue("@capacidadBarco", capacidadBarco);
                        cmd.Parameters.AddWithValue("@tipoCargaBarco", tipoCargaBarco);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            cmbMuelle.Items.Clear(); // Limpiar el ComboBox antes de cargar las zonas

                            while (reader.Read())
                            {
                                // Crear un objeto Zona con los datos obtenidos
                                Zona zona = new Zona(
                                    reader["id_muelle"].ToString(),
                                    reader["tipo_muelle"].ToString(),
                                    Convert.ToInt32(reader["capacidad_muelle"])
                                );

                                cmbMuelle.Items.Add(zona); // Agregar la zona al ComboBox
                            }
                        }
                    }
                }

                if (cmbMuelle.Items.Count == 0)
                {
                    MessageBox.Show("No hay zonas disponibles para el barco seleccionado.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al filtrar las zonas: " + ex.Message);
            }
        }

        private void frmCargaDescarga_Load(object sender, EventArgs e)
        {
           

            // Cargar los seriales de los barcos en el ComboBox
            CargarSerialesBarcos();

            // Asociar el evento al ComboBox de seriales
            cmbSerialBarco.SelectedIndexChanged += cmbSerialBarco_SelectedIndexChanged;


            // Asociar el evento al ComboBox de muelles
            cmbMuelle.SelectedIndexChanged += cmbMuelle_SelectedIndexChanged;
        }

        public class Zona
        {
            public string Nombre { get; set; }
            public string TipoCarga { get; set; }
            public int Capacidad { get; set; }

            public Zona(string nombre, string tipoCarga, int capacidad)
            {
                Nombre = nombre;
                TipoCarga = tipoCarga;
                Capacidad = capacidad;
            }

            public override string ToString()
            {
                return Nombre; // Esto es lo que se mostrará en el ComboBox
            }
        }

        private void cmbMuelle_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbMuelle.SelectedItem is Zona zonaSeleccionada)
            {
                // Actualizar los campos de tipo de carga y capacidad
                txtTipocarga.Text = zonaSeleccionada.TipoCarga;
                txtCapacidad.Text = zonaSeleccionada.Capacidad.ToString();
            }
        }

     
        private void cmbSerialBarco_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSerialBarco.SelectedItem != null)
            {
                string serialBuque = cmbSerialBarco.SelectedItem.ToString();

                // Cargar la acción del buque
                CargarAccionBuque(serialBuque);

                // Obtener la capacidad y el tipo de carga del barco
                var (capacidadBarco, tipoCargaBarco) = ObtenerDatosBarco(serialBuque);

                // Filtrar las zonas desde la base de datos
                FiltrarZonasDesdeBaseDatos(capacidadBarco, tipoCargaBarco);
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

        private void label8_Click(object sender, EventArgs e)
        {

        }

        void CargarAccionBuque(string serial)
        {
            try
            {
                // Validar que el serial no esté vacío
                if (string.IsNullOrEmpty(serial))
                {
                    txtAccion.Clear();
                    return;
                }

                // Consulta para obtener la acción del buque según el serial
                string consulta = "SELECT accion FROM RegistroLlegadaBuque WHERE serial_buque = @serial_buque";

                using (SqlConnection conexion = DatabaseHelper.GetConnection())
                {
                    using (SqlCommand cmd = new SqlCommand(consulta, conexion))
                    {
                        cmd.Parameters.AddWithValue("@serial_buque", serial);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                txtAccion.Text = reader["accion"].ToString();
                            }
                            else
                            {
                                txtAccion.Clear();
                                MessageBox.Show("No se encontró una acción para el serial seleccionado.");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la acción del buque: " + ex.Message);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string serial_buque = cmbSerialBarco.SelectedItem?.ToString();
            float capacidad = txtCapacidad.Text == "" ? 0 : float.Parse(txtCapacidad.Text);
            string id_muelle  = cmbMuelle.SelectedItem?.ToString();
            string descripcion = txtDescripcion.Text;
            DateTime fecha_operacion = dtTimePicker.Value;
            string tipo_carga = txtTipocarga.Text;
            string accion = txtAccion.Text;



            txtCapacidad.Clear();
            cmbMuelle.SelectedIndex = -1;
            cmbSerialBarco.SelectedIndex = -1;
            txtTipocarga.Clear();
            txtAccion.Clear();
            txtDescripcion.Clear();

            if (string.IsNullOrEmpty(serial_buque))
            {
                MessageBox.Show("Debe seleccionar un serial de buque válido.");
                return;
            }




            if (string.IsNullOrEmpty(serial_buque) || string.IsNullOrEmpty(descripcion) || string.IsNullOrEmpty(tipo_carga) || string.IsNullOrEmpty(accion))
            {
                MessageBox.Show("Por favor, complete todos los campos.");

                return;
            }




            if (DatabaseHelper.agregar_operacion_registro(serial_buque, id_muelle, descripcion, fecha_operacion ,capacidad, tipo_carga, accion))
            {
                MessageBox.Show("Operación Ingresada correctamente.");
                NroOperacion();

            }


            else
            {
                MessageBox.Show("Error al ingresar operación. Por favor, inténtelo de nuevo.");
            }
        }
        void NroOperacion()
        {
            try
            {
                // Consulta para contar las filas en la tabla Incidencias
                string consulta = "SELECT COUNT(*) FROM Registro_Operacion";

                using (SqlConnection conexion = DatabaseHelper.GetConnection()) // Obtener la conexión
                {


                    using (SqlCommand cmd = new SqlCommand(consulta, conexion))
                    {
                        // Ejecutar la consulta y obtener el número de filas
                        int numeroFilas = (int)cmd.ExecuteScalar();

                        // Incrementar el contador
                        contador = numeroFilas + 1;

                        // Actualizar el texto del label
                        txtOperacion.Text = contador.ToString();

                    }

                }

            }
            catch (Exception ex)
            {
                // Manejar errores y mostrar un mensaje
                MessageBox.Show("Error al obtener el número de incidencia: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtCapacidad.Clear();
            cmbMuelle.SelectedIndex = -1;
            cmbSerialBarco.SelectedIndex = -1;
            txtTipocarga.Clear();
            txtAccion.Clear();
            txtDescripcion.Clear();
        }
    }

}
