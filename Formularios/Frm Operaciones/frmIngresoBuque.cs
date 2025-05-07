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
    public partial class frmIngresoBuque: Form
    {
        public frmIngresoBuque()
        {
            InitializeComponent();
        }

        public frmInformeBuqueUsuario frmInformeBuqueUsuario
        {
            get => default;
            set
            {
            }
        }

        public frmInformeBuque frmInformeBuque
        {
            get => default;
            set
            {
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string serial_buque = txtSerial.Text;
            string capitan = txtCapitan.Text;
            string empresa = txtEmpresa.Text;
            string origen = txtOrigen.Text;
            DateTime fecha_ingreso = dateIngreso.Value;
            double capacidad = Convert.ToDouble(txtCapacidad.Text);

            serial_buque = serial_buque.Trim();
            capitan = capitan.Trim();
            empresa = empresa.Trim();
            origen = origen.Trim();

            if (string.IsNullOrEmpty(serial_buque) || string.IsNullOrEmpty(capitan) ||
                string.IsNullOrEmpty(empresa) || string.IsNullOrEmpty(origen))
            {
                MessageBox.Show("Por favor, complete todos los campos.");
                return;
            }

            // Validar que la capacidad sea un número positivo
            if (capacidad <= 0)
            {
                MessageBox.Show("La capacidad debe ser un número mayor a 0.");
                return;
            }

            // Validar que la fecha de ingreso no sea en el futuro
            if (fecha_ingreso > DateTime.Now)
            {
                MessageBox.Show("La fecha de ingreso no puede ser una fecha futura.");
                return;
            }

            if (DatabaseHelper.agregar_buque(serial_buque, capitan, empresa, origen, fecha_ingreso, capacidad, UsuarioSesion.id_usuario))
            {
                MessageBox.Show("Buque ingresado correctamente.");
                txtSerial.Clear();
                txtCapacidad.Clear();
                txtCapitan.Clear();
                txtEmpresa.Clear();
                txtOrigen.Clear();
            }
            else
            {
                MessageBox.Show("Error al ingresar el buque. Por favor, inténtelo de nuevo.");
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        private void CargarDatosPorSerial(string serial)
        {
            try
            {
                // Validar que el serial no esté vacío
                if (string.IsNullOrEmpty(serial))
                {
                    MessageBox.Show("Por favor, ingrese un serial válido.");
                    return;
                }

                // Consulta para obtener los datos del buque
                string consulta = "SELECT capitan, empresa, origen, fecha_ingreso, capacidad FROM IngresoBuque WHERE serial_buque = @serial_buque";

                using (SqlConnection conexion = DatabaseHelper.GetConnection())
                {
                    using (SqlCommand cmd = new SqlCommand(consulta, conexion))
                    {
                        cmd.Parameters.AddWithValue("@serial_buque", serial);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Llenar los campos del formulario con los datos obtenidos
                                txtCapitan.Text = reader["capitan"].ToString();
                                txtEmpresa.Text = reader["empresa"].ToString();
                                txtOrigen.Text = reader["origen"].ToString();
                                dateIngreso.Value = Convert.ToDateTime(reader["fecha_ingreso"]);
                                txtCapacidad.Text = reader["capacidad"].ToString();
                            }
                            else
                            {
                                MessageBox.Show("No se encontró un buque con el serial especificado.");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos del buque: " + ex.Message);
            }
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                // Validar que el campo Serial no esté vacío
                if (string.IsNullOrEmpty(txtSerial.Text.Trim()))
                {
                    MessageBox.Show("El campo 'Serial Barco' es obligatorio para actualizar.");
                    return;
                }

                string serial_buque = txtSerial.Text.Trim();
                string capitan = txtCapitan.Text.Trim();
                string empresa = txtEmpresa.Text.Trim();
                string origen = txtOrigen.Text.Trim();
                DateTime fecha_ingreso = dateIngreso.Value;
                double capacidad;

                // Validar que la capacidad sea un número válido
                if (!double.TryParse(txtCapacidad.Text.Trim(), out capacidad) || capacidad <= 0)
                {
                    MessageBox.Show("La capacidad debe ser un número mayor a 0.");
                    return;
                }

                // Validar que la fecha de ingreso no sea futura
                if (fecha_ingreso > DateTime.Now)
                {
                    MessageBox.Show("La fecha de ingreso no puede ser una fecha futura.");
                    return;
                }

                // Crear la consulta SQL dinámica para actualizar solo los campos modificados
                string consulta = "UPDATE IngresoBuque SET ";
                List<string> campos = new List<string>();
                List<SqlParameter> parametros = new List<SqlParameter>();

                if (!string.IsNullOrEmpty(capitan))
                {
                    campos.Add("capitan = @capitan");
                    parametros.Add(new SqlParameter("@capitan", capitan));
                }
                if (!string.IsNullOrEmpty(empresa))
                {
                    campos.Add("empresa = @empresa");
                    parametros.Add(new SqlParameter("@empresa", empresa));
                }
                if (!string.IsNullOrEmpty(origen))
                {
                    campos.Add("origen = @origen");
                    parametros.Add(new SqlParameter("@origen", origen));
                }
                if (fecha_ingreso != null)
                {
                    campos.Add("fecha_ingreso = @fecha_ingreso");
                    parametros.Add(new SqlParameter("@fecha_ingreso", fecha_ingreso));
                }
                if (capacidad > 0)
                {
                    campos.Add("capacidad = @capacidad");
                    parametros.Add(new SqlParameter("@capacidad", capacidad));
                }

                if (campos.Count == 0)
                {
                    MessageBox.Show("No hay cambios para actualizar.");
                    return;
                }

                consulta += string.Join(", ", campos) + " WHERE serial_buque = @serial_buque";
                parametros.Add(new SqlParameter("@serial_buque", serial_buque));

                // Ejecutar la consulta
                using (SqlConnection conexion = DatabaseHelper.GetConnection())
                {
                    using (SqlCommand cmd = new SqlCommand(consulta, conexion))
                    {
                        cmd.Parameters.AddRange(parametros.ToArray());

                        int filasAfectadas = cmd.ExecuteNonQuery();

                        if (filasAfectadas > 0)
                        {
                            MessageBox.Show("Los datos del buque se actualizaron correctamente.");
                        }
                        else
                        {
                            MessageBox.Show("No se encontró un buque con el serial especificado.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar los datos del buque: " + ex.Message);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtSerial.Clear();
            txtCapacidad.Clear();
            txtCapitan.Clear();
            txtEmpresa.Clear();
            txtOrigen.Clear();
        }

        private void btnCargarDatos_Click(object sender, EventArgs e)
        {
            string serial = txtSerial.Text.Trim();
            CargarDatosPorSerial(serial);
        }

        private void txtCapitan_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmIngresoBuque_Load(object sender, EventArgs e)
        {

        }
    }
}
