using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
            string capitan = txtCapacidad.Text;
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
    }
}
