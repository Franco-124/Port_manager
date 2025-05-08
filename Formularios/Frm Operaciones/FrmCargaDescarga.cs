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
        public frmCargaDescarga()
        {
            InitializeComponent();
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
                // Consulta para obtener los seriales de los barcos
                string consulta = "SELECT serial_buque FROM IngresoBuque";

                using (SqlConnection conexion = DatabaseHelper.GetConnection())
                {
                    using (SqlCommand cmd = new SqlCommand(consulta, conexion))
                    {
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


        private void FiltrarZonas(int capacidadBarco, string tipoCargaBarco)
        {
            cmbMuelle.Items.Clear(); // Limpiar el ComboBox antes de cargar las zonas filtradas

            foreach (var zona in zonas)
            {
                // Verificar si la zona cumple con los criterios
                if (zona.Capacidad >= capacidadBarco && zona.TipoCarga == tipoCargaBarco)
                {
                    cmbMuelle.Items.Add(zona); // Agregar el objeto Zona al ComboBox
                }
            }

            if (cmbMuelle.Items.Count == 0)
            {
                MessageBox.Show("No hay zonas disponibles para el barco seleccionado.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void frmCargaDescarga_Load(object sender, EventArgs e)
        {
            // Inicializar las zonas
            InicializarZonas();

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

        private List<Zona> zonas;

        private void InicializarZonas()
        {
            zonas = new List<Zona>
    {
        new Zona("Zona A", "Graneleros", 300),
        new Zona("Zona B", "Petroleros", 350),
        new Zona("Zona C", "Porta Contenedores", 200),
        new Zona("Zona D", "Vehiculos", 320),
        new Zona("Zona E", "Vehiculos", 380),
        new Zona("Zona F", "Frigorificos", 380),
        new Zona("Zona G", "Carga General", 250)
    };
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

                // Filtrar las zonas según la capacidad y el tipo de carga del barco
                FiltrarZonas(capacidadBarco, tipoCargaBarco);
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
    }
    }
}
