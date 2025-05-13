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

    public partial class frmClasificacionAsignacion : Form
    {
        private ToolTip toolTipZonas = new ToolTip();
        public frmClasificacionAsignacion()
        {
            InitializeComponent();
            toolTipZonas = new ToolTip();
            CargarInfoZonas();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
        }

        public FrmInformeMuelle FrmInformeMuelle
        {
            get => default;
            set
            {
            }
        }

        public Frm_Operaciones.frmAsignacionMuelleUsuario frmAsignacionMuelleUsuario
        {
            get => default;
            set
            {
            }
        }

        private void frmClasificacionAsignacion_Load(object sender, EventArgs e)
        {
            
            pictureBox1.Controls.Add(btnZonaA);
            pictureBox1.Controls.Add(btnZonaB);
            pictureBox1.Controls.Add(btnZonaC);
            pictureBox1.Controls.Add(btnZonaD);
            pictureBox1.Controls.Add(btnZonaE);
            pictureBox1.Controls.Add(btnZonaF);
            pictureBox1.Controls.Add(btnZonaG);

            ReubicarBotones(); // Ajustar posiciones iniciales
        }


        private DataTable ObtenerInfoZonas()
        {
            string query = @"
        SELECT id_muelle, serial_buque, tipo_carga, capacidad, accion, descripcion, fecha_operacion
        FROM Registro_Operacion";

            using (SqlConnection conn = DatabaseHelper.GetConnection())
            using (SqlDataAdapter da = new SqlDataAdapter(query, conn))
            {
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }



        private void CargarInfoZonas()
        {
            DataTable zonas = ObtenerInfoZonas();

            // Agrupa los registros por id_muelle exactamente como están en la base de datos
            var zonasAgrupadas = zonas.AsEnumerable()
                .GroupBy(row =>
                {
                    var val = row["id_muelle"]?.ToString()?.Trim();
                    return string.IsNullOrEmpty(val) ? "" : val;
                })
                .ToDictionary(
                    g => g.Key,
                    g => g.Select(row =>
                        $"Buque: {row["serial_buque"]}\n" +
                        $"Carga: {row["tipo_carga"]}\n" +
                        $"Capacidad: {row["capacidad"]}\n" +
                        $"Acción: {row["accion"]}"
                    ).ToList()
                );

            // Para cada letra de la A a la G
            foreach (char letra in "ABCDEFG")
            {
                string idMuelle = $"Zona {letra}";
                string nombreBoton = $"btnZona{letra}";
                Button btn = this.Controls.Find(nombreBoton, true).FirstOrDefault() as Button;
                if (btn != null)
                {
                    btn.Text = $"Zona {letra}";
                    btn.BackColor = Color.LightGray;

                    // Consultar el estado del muelle
                    string estadoMuelle = "";
                    try
                    {
                        using (SqlConnection conn = DatabaseHelper.GetConnection())
                        {
                            string consultaEstado = "SELECT estado FROM Muelle WHERE id_muelle = @idMuelle";
                            using (SqlCommand cmd = new SqlCommand(consultaEstado, conn))
                            {
                                cmd.Parameters.AddWithValue("@idMuelle", idMuelle);
                                object result = cmd.ExecuteScalar();
                                if (result != null)
                                    estadoMuelle = result.ToString();
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        // Si hay error, dejar el color por defecto y continuar
                    }

                    if (estadoMuelle == "ocupado")
                    {
                        btn.BackColor = Color.Red;
                    }
                    else if (zonasAgrupadas.ContainsKey(idMuelle))
                    {
                        string tooltipText = string.Join("\n\n", zonasAgrupadas[idMuelle]);
                        toolTipZonas.SetToolTip(btn, tooltipText);
                        btn.BackColor = Color.LightGreen;
                    }
                    else
                    {
                        toolTipZonas.SetToolTip(btn, "Sin información registrada.");
                    }
                }
            }
        }

        private void ReubicarBotones()
        {
            int baseWidth = 900;
            int baseHeight = 407;

            float scaleX = (float)pictureBox1.Width / baseWidth;
            float scaleY = (float)pictureBox1.Height / baseHeight;

            btnZonaA.Left = (int)(290 * scaleX);
            btnZonaA.Top = (int)(24 * scaleY);

            btnZonaB.Left = (int)(400 * scaleX);
            btnZonaB.Top = (int)(113 * scaleY);

            btnZonaC.Left = (int)(520 * scaleX);
            btnZonaC.Top = (int)(113 * scaleY);

            btnZonaD.Left = (int)(650 * scaleX);
            btnZonaD.Top = (int)(113 * scaleY);

            btnZonaE.Left = (int)(160 * scaleX);
            btnZonaE.Top = (int)(232 * scaleY);

            btnZonaF.Left = (int)(400 * scaleX);
            btnZonaF.Top = (int)(232 * scaleY);

            btnZonaG.Left = (int)(650 * scaleX);
            btnZonaG.Top = (int)(232 * scaleY);

            buttonEntrada.Left = (int)(160 * scaleX);
            buttonEntrada.Top = (int)(42 * scaleY);
        }

        private void frmClasificacionAsignacion_Resize(object sender, EventArgs e)
        {
            ReubicarBotones();
        }

        private void pictureBox1_Resize(object sender, EventArgs e)
        {
            ReubicarBotones();
        }

        private DataTable ObtenerBarcosEnMuelles()
        {
            string consulta = @"
            SELECT serial_buque, id_muelle, capacidad
            FROM Registro_Operacion";

            using (SqlConnection conexion = DatabaseHelper.GetConnection())
            using (SqlDataAdapter da = new SqlDataAdapter(consulta, conexion))
            {
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }


        private void iconButton9_Click(object sender, EventArgs e)
        {
            // Mostrar una lista de barcos en los muelles
            DataTable barcosEnMuelles = ObtenerBarcosEnMuelles();
            if (barcosEnMuelles.Rows.Count == 0)
            {
                MessageBox.Show("No hay barcos en los muelles para despachar.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Crear un formulario para seleccionar el barco
            using (Form seleccionBarcoForm = new Form())
            {
                seleccionBarcoForm.Text = "Seleccionar Barco para Despachar";
                seleccionBarcoForm.Size = new Size(400, 300);

                ListBox listBoxBarcos = new ListBox
                {
                    Dock = DockStyle.Fill,
                    DisplayMember = "DisplayText",
                    ValueMember = "serial_buque",
                    DataSource = barcosEnMuelles.AsEnumerable().Select(row => new
                    {
                        serial_buque = row["serial_buque"].ToString(),
                        DisplayText = $"Buque: {row["serial_buque"]}, Muelle: {row["id_muelle"]}"
                    }).ToList()
                };

                Button btnAceptar = new Button
                {
                    Text = "Aceptar",
                    Dock = DockStyle.Bottom
                };

                seleccionBarcoForm.Controls.Add(listBoxBarcos);
                seleccionBarcoForm.Controls.Add(btnAceptar);

                string serialBuqueSeleccionado = null;
                string idMuelleSeleccionado = null;
                float capacidadBuque = 0;

                btnAceptar.Click += (s, args) =>
                {
                    if (listBoxBarcos.SelectedItem != null)
                    {
                        var seleccionado = (dynamic)listBoxBarcos.SelectedItem;
                        serialBuqueSeleccionado = seleccionado.serial_buque;
                        idMuelleSeleccionado = barcosEnMuelles.AsEnumerable()
                            .First(row => row["serial_buque"].ToString() == serialBuqueSeleccionado)["id_muelle"].ToString();
                        seleccionBarcoForm.DialogResult = DialogResult.OK;
                        seleccionBarcoForm.Close();
                    }
                    else
                    {
                        MessageBox.Show("Debe seleccionar un barco.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                };

                if (seleccionBarcoForm.ShowDialog() != DialogResult.OK)
                {
                    return;
                }

                // Obtener la capacidad del buque desde la tabla IngresoBuque
                try
                {
                    string consultaCapacidadBuque = @"
                    SELECT capacidad
                    FROM IngresoBuque
                    WHERE serial_buque = @serial_buque";

                    using (SqlConnection conexion = DatabaseHelper.GetConnection())
                    {
                        using (SqlCommand cmd = new SqlCommand(consultaCapacidadBuque, conexion))
                        {
                            cmd.Parameters.AddWithValue("@serial_buque", serialBuqueSeleccionado);

                            using (SqlDataReader reader = cmd.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    capacidadBuque = Convert.ToSingle(reader["capacidad"]);
                                }
                                else
                                {
                                    MessageBox.Show("No se encontró la capacidad del buque en la tabla IngresoBuque.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    return;
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al obtener la capacidad del buque: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Eliminar el registro del barco en Registro_Operacion
                try
                {
                    string consultaEliminarRegistro = @"
                    DELETE FROM Registro_Operacion
                    WHERE serial_buque = @serial_buque";

                    using (SqlConnection conexion = DatabaseHelper.GetConnection())
                    {
                        using (SqlCommand cmd = new SqlCommand(consultaEliminarRegistro, conexion))
                        {
                            cmd.Parameters.AddWithValue("@serial_buque", serialBuqueSeleccionado);
                            int filasEliminadas = cmd.ExecuteNonQuery();
                            if (filasEliminadas > 0)
                            {
                                MessageBox.Show("Registro del barco eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("No se encontró el registro del barco para eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar el registro del barco: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Restablecer la capacidad original del muelle sumando la capacidad del barco
                try
                {
                    string consultaActualizarCapacidad = @"
                    UPDATE Muelle
                    SET capacidad_muelle = capacidad_muelle +          @capacidadBuque
                    WHERE id_muelle = @id_muelle";

                    using (SqlConnection conexion = DatabaseHelper.GetConnection())
                    {
                        using (SqlCommand cmd = new SqlCommand(consultaActualizarCapacidad, conexion))
                        {
                            cmd.Parameters.AddWithValue("@capacidadBuque", capacidadBuque); // Capacidad del barco
                            cmd.Parameters.AddWithValue("@id_muelle", idMuelleSeleccionado); // ID del muelle
                            int filasAfectadas = cmd.ExecuteNonQuery();
                            if (filasAfectadas > 0)
                            {
                                MessageBox.Show("Capacidad del muelle restablecida correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                // Actualizar el estado del muelle a 'disponible'
                                try
                                {
                                    string consultaActualizarEstado = @"
                                    UPDATE Muelle
                                    SET estado = 'disponible'
                                    WHERE id_muelle = @id_muelle";

                                    using (SqlCommand cmdEstado = new SqlCommand(consultaActualizarEstado, conexion))
                                    {
                                        cmdEstado.Parameters.AddWithValue("@id_muelle", idMuelleSeleccionado);
                                        cmdEstado.ExecuteNonQuery();
                                    }
                                }
                                catch (Exception exEstado)
                                {
                                    MessageBox.Show("Error al actualizar el estado del muelle: " + exEstado.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            else
                            {
                                MessageBox.Show("No se pudo restablecer la capacidad del muelle.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al restablecer la capacidad del muelle: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            // Recargar la información de las zonas
            CargarInfoZonas();


        }



    }
}
