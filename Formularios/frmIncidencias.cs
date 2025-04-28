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
        public frmIncidencias()
        {
            InitializeComponent();
        }

        bool datosSerialCargados = false;

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
    }
}
