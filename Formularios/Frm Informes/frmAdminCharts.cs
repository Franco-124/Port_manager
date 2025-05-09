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
using System.Windows.Forms.DataVisualization.Charting;

namespace Port_manager.Formularios.Frm_Informes
{
    public partial class frmAdminCharts : Form
    {
        public frmAdminCharts()
        {
            InitializeComponent();
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void frmAdminCharts_Load(object sender, EventArgs e)
        {
            CargarGraficoIncidenciasPorTipo();
            CargarGraficoUsuariosPorRol();
            CargarGraficoLineaTendencia();
        }


        private void CargarGraficoIncidenciasPorTipo()
        {
            string consulta = "SELECT tipo_incidencia, COUNT(*) AS cantidad FROM Incidencias GROUP BY tipo_incidencia";

            try
            {
                using (SqlConnection conexion = DatabaseHelper.GetConnection())
                {
                    using (SqlCommand cmd = new SqlCommand(consulta, conexion))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {

                            // Configurar el gráfico
                            chartTipoIncidencia.Series.Clear();
                            chartTipoIncidencia.Titles.Clear();
                            chartTipoIncidencia.Titles.Add("Distribución de Incidencias por Tipo");
                            chartTipoIncidencia.Titles[0].Font = new Font("Arial", 14, FontStyle.Bold);
                            chartTipoIncidencia.Titles[0].ForeColor = Color.DarkBlue;
                            chartTipoIncidencia.Titles[0].Alignment = ContentAlignment.TopCenter;

                            // Configurar el gráfico
                            Series series = new Series("Incidencias por Tipo");
                            series.ChartType = SeriesChartType.Pie;
                            series.IsValueShownAsLabel = true;
                            series.Label = "#PERCENT{P0}";
                            series.LegendText = "#VALX";
                            series.Font = new Font("Arial", 8, FontStyle.Bold);
                            series.LabelForeColor = Color.White;


                            // Agregar los datos al gráfico dinámicamente
                            while (reader.Read())
                            {
                                string tipo = reader["tipo_incidencia"].ToString();
                                int cantidad = Convert.ToInt32(reader["cantidad"]);

                                // Solo agregar al gráfico si la cantidad es mayor a 0
                                if (cantidad > 0)
                                {
                                    series.Points.AddXY(tipo, cantidad);
                                }
                            }

                            chartTipoIncidencia.Series.Add(series);

                           

                            //Personalizar el texto                           
                            chartTipoIncidencia.ChartAreas[0].BackGradientStyle = GradientStyle.TopBottom;
                            chartTipoIncidencia.ChartAreas[0].BackSecondaryColor = Color.White;

                            //Grafico 3D
                            chartTipoIncidencia.ChartAreas[0].Area3DStyle.Enable3D = true;
                            chartTipoIncidencia.ChartAreas[0].Area3DStyle.Inclination = 45;
                            chartTipoIncidencia.ChartAreas[0].Area3DStyle.Rotation = 30;
                            chartTipoIncidencia.ChartAreas[0].Area3DStyle.LightStyle = LightStyle.Realistic;

                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el gráfico: " + ex.Message);
            }
        }


        private void CargarGraficoUsuariosPorRol()
        {
            string consulta = "SELECT rol, COUNT(*) AS cantidad FROM usuarios GROUP BY rol";

            try
            {
                using (SqlConnection conexion = DatabaseHelper.GetConnection())
                {
                    using (SqlCommand cmd = new SqlCommand(consulta, conexion))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            // Configurar el gráfico
                            chartUsuariosPorRol.Series.Clear();
                            chartUsuariosPorRol.Titles.Clear();
                            chartUsuariosPorRol.Titles.Add("Distribución de Usuarios por Rol");
                            chartUsuariosPorRol.Titles[0].Font = new Font("Arial", 14, FontStyle.Bold);
                            chartUsuariosPorRol.Titles[0].ForeColor = Color.DarkBlue;
                            chartUsuariosPorRol.Titles[0].Alignment = ContentAlignment.TopCenter;

                            // Agregar una leyenda si no existe
                            chartUsuariosPorRol.Legends.Clear();
                            Legend legend = new Legend("Legend1");
                            legend.Docking = Docking.Top;
                            legend.Font = new Font("Arial", 10, FontStyle.Regular);
                            legend.BackColor = Color.Transparent;
                            chartUsuariosPorRol.Legends.Add(legend);

                            // Configurar la serie
                            Series series = new Series("Usuarios por Rol");
                            series.ChartType = SeriesChartType.Column; // Cambiar a columnas verticales
                            series.IsValueShownAsLabel = true; // Mostrar valores en las barras
                            series.Label = "#VAL"; // Mostrar el valor directamente en la barra
                            series.Font = new Font("Arial", 10, FontStyle.Bold);
                            series.LabelForeColor = Color.Black;

                            // Agregar los datos al gráfico dinámicamente
                            while (reader.Read())
                            {
                                string rol = reader["rol"].ToString();
                                int cantidad = Convert.ToInt32(reader["cantidad"]);

                                // Solo agregar al gráfico si la cantidad es mayor a 0
                                if (cantidad > 0)
                                {
                                    series.Points.AddXY(rol, cantidad);
                                }
                            }

                            chartUsuariosPorRol.Series.Add(series);

                            // Configurar el área del gráfico
                            chartUsuariosPorRol.ChartAreas[0].AxisX.Title = "Roles";
                            chartUsuariosPorRol.ChartAreas[0].AxisX.TitleFont = new Font("Arial", 12, FontStyle.Bold);
                            chartUsuariosPorRol.ChartAreas[0].AxisX.LabelStyle.Font = new Font("Arial", 10);
                            chartUsuariosPorRol.ChartAreas[0].AxisX.Interval = 1; // Mostrar todas las etiquetas en el eje X

                            chartUsuariosPorRol.ChartAreas[0].AxisY.Title = "Cantidad de Usuarios";
                            chartUsuariosPorRol.ChartAreas[0].AxisY.TitleFont = new Font("Arial", 8, FontStyle.Bold);
                            chartUsuariosPorRol.ChartAreas[0].AxisY.LabelStyle.Font = new Font("Arial", 10);

                            // Personalizar el fondo del gráfico
                            chartUsuariosPorRol.ChartAreas[0].AxisX.MajorGrid.LineWidth = 0; // Eje X
                            chartUsuariosPorRol.ChartAreas[0].AxisY.MajorGrid.LineWidth = 0; // Eje Y
                            chartUsuariosPorRol.ChartAreas[0].BackColor = Color.White;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el gráfico: " + ex.Message);
            }
        }


        private void CargarGraficoLineaTendencia()
        {
            string consulta = @"
        SELECT CONVERT(DATE, fecha_ingreso) AS Fecha, COUNT(*) AS Cantidad
        FROM IngresoBuque
        GROUP BY CONVERT(DATE, fecha_ingreso)
        ORDER BY Fecha";

            try
            {
                using (SqlConnection conexion = DatabaseHelper.GetConnection())
                {
                    using (SqlCommand cmd = new SqlCommand(consulta, conexion))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            // Crear un diccionario para almacenar los datos
                            Dictionary<DateTime, int> datos = new Dictionary<DateTime, int>();

                            // Leer los datos de la base de datos
                            while (reader.Read())
                            {
                                DateTime fecha = Convert.ToDateTime(reader["Fecha"]);
                                int cantidad = Convert.ToInt32(reader["Cantidad"]);
                                datos[fecha] = cantidad;
                            }

                            // Configurar el gráfico
                            chartLineaTendencia.Series.Clear();
                            chartLineaTendencia.Titles.Clear();
                            chartLineaTendencia.Titles.Add("Tendencia de Registros de Buques");
                            chartLineaTendencia.Titles[0].Font = new Font("Arial", 14, FontStyle.Bold);
                            chartLineaTendencia.Titles[0].ForeColor = Color.DarkBlue;
                            chartLineaTendencia.Titles[0].Alignment = ContentAlignment.TopCenter;

                            // Configurar la serie
                            Series series = new Series("Registros por Día");
                            series.ChartType = SeriesChartType.Line; // Línea simple
                            series.BorderWidth = 2; // Grosor de la línea
                            series.Color = Color.Blue; // Color de la línea

                            // Agregar los datos al gráfico
                            foreach (var dato in datos.OrderBy(d => d.Key))
                            {
                                series.Points.AddXY(dato.Key.ToString("dd/MM/yyyy"), dato.Value);
                            }

                            chartLineaTendencia.Series.Add(series);

                            // Configurar el área del gráfico
                            chartLineaTendencia.ChartAreas[0].AxisX.Title = "Fecha";
                            chartLineaTendencia.ChartAreas[0].AxisX.TitleFont = new Font("Arial", 10, FontStyle.Bold);
                            chartLineaTendencia.ChartAreas[0].AxisX.LabelStyle.Font = new Font("Arial", 8);
                            chartLineaTendencia.ChartAreas[0].AxisX.Interval = 1; // Mostrar todas las etiquetas en el eje X

                            chartLineaTendencia.ChartAreas[0].AxisY.Title = "Cantidad de Registros";
                            chartLineaTendencia.ChartAreas[0].AxisY.TitleFont = new Font("Arial", 10, FontStyle.Bold);
                            chartLineaTendencia.ChartAreas[0].AxisY.LabelStyle.Font = new Font("Arial", 8);

                            // Personalizar el fondo del gráfico
                            chartLineaTendencia.ChartAreas[0].BackColor = Color.White;

                            // Mostrar líneas de cuadrícula
                            chartLineaTendencia.ChartAreas[0].AxisX.MajorGrid.LineColor = Color.LightGray;
                            chartLineaTendencia.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.LightGray;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el gráfico: " + ex.Message);
            }
        }



        private void chartUsuariosPorRol_Click(object sender, EventArgs e)
        {

        }
    }
}
