using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;
using System.IO;
using SqlConnectiondb;
using System.Data.SqlClient;
namespace Port_manager.Formularios
{
    public partial class FrmInformeMuelle : Form
    {
        private DataTable tablaOriginal;
        public FrmInformeMuelle()
        {
            InitializeComponent();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            object ObjMiss = System.Reflection.Missing.Value;
            Word.Application ObjWord = new Word.Application();
            Word.Document ObjDoc = ObjWord.Documents.Add(ref ObjMiss);
            ObjDoc.Activate();

            // Fuente general
            ObjWord.Selection.Font.Name = "Calibri";

            // Título principal
            ObjWord.Selection.Font.Size = 20;
            ObjWord.Selection.Font.Bold = 1;
            ObjWord.Selection.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
            ObjWord.Selection.TypeText("Informe de Muelles");
            ObjWord.Selection.TypeParagraph();

            // Fecha de impresión
            ObjWord.Selection.Font.Size = 12;
            ObjWord.Selection.Font.Bold = 0;
            ObjWord.Selection.TypeText("Fecha de impresión: " + DateTime.Now.ToString("dddd, dd MMMM yyyy"));
            ObjWord.Selection.TypeParagraph();
            ObjWord.Selection.TypeParagraph();

            // Tabla
            int filas = dtgMuelles.Rows.Count;
            int columnas = 4;

            Word.Table tabla = ObjDoc.Tables.Add(ObjWord.Selection.Range, filas, columnas, ref ObjMiss, ref ObjMiss);
            tabla.Borders.Enable = 1;
            tabla.Range.Font.Size = 11;
            tabla.Range.Font.Name = "Calibri";

            string[] encabezados = { "Id Muelle", "Capacidad De Muelle", "Tipo de Muelle", "Estado"};
            for (int col = 0; col < columnas; col++)
            {
                tabla.Cell(1, col + 1).Range.Text = encabezados[col];
                tabla.Cell(1, col + 1).Range.Shading.BackgroundPatternColor = Word.WdColor.wdColorGray25;
                tabla.Cell(1, col + 1).Range.Bold = 1;
                tabla.Cell(1, col + 1).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
            }

            for (int i = 0; i < filas - 1; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    string texto = dtgMuelles.Rows[i].Cells[j].Value?.ToString() ?? "";
                    tabla.Cell(i + 2, j + 1).Range.Text = texto;
                    tabla.Cell(i + 2, j + 1).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft;
                }

                if (i % 2 == 0)
                {
                    for (int j = 0; j < columnas; j++)
                    {
                        tabla.Cell(i + 2, j + 1).Shading.BackgroundPatternColor = Word.WdColor.wdColorGray10;
                    }
                }
            }

            // Espacio antes del cierre
            ObjWord.Selection.MoveDown(Word.WdUnits.wdLine, filas + 5);
            ObjWord.Selection.TypeParagraph();
            ObjWord.Selection.TypeParagraph();

            // Texto final
            ObjWord.Selection.Font.Italic = 1;
            ObjWord.Selection.Font.Size = 12;
            ObjWord.Selection.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
            ObjWord.Selection.TypeText("Expedido por la compañía Dock Master ®");

            // Exportar a PDF
            try
            {
                string fileName = $"Informe_Muelle_{DateTime.Now:yyyyMMdd_HHmm}.pdf";
                string pdfPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), fileName);

                ObjDoc.ExportAsFixedFormat(
                    pdfPath,
                    Word.WdExportFormat.wdExportFormatPDF,
                    OpenAfterExport: true,
                    OptimizeFor: Word.WdExportOptimizeFor.wdExportOptimizeForPrint,
                    Range: Word.WdExportRange.wdExportAllDocument,
                    From: 0,
                    To: 0,
                    Item: Word.WdExportItem.wdExportDocumentContent,
                    IncludeDocProps: true,
                    KeepIRM: true,
                    CreateBookmarks: Word.WdExportCreateBookmarks.wdExportCreateWordBookmarks,
                    DocStructureTags: true,
                    BitmapMissingFonts: true,
                    UseISO19005_1: false
                );
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al exportar PDF: " + ex.Message);
            }
            finally
            {
                ObjDoc.Close(false);
                ObjWord.Quit(false);
            }
        }
     

        public DataTable cargar_datos()
        {
            string consulta = "select id_muelle,capacidad_muelle,tipo_muelle,estado from Muelle";
            using (SqlConnection conexion = DatabaseHelper.GetConnection())
            {
                SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion);
                DataTable tabla = new DataTable();
                adaptador.Fill(tabla);

                dtgMuelles.AutoGenerateColumns = false;


                dtgMuelles.DataSource = tabla;

                dtgMuelles.Columns["id_muelle"].DataPropertyName = "id_muelle";
                dtgMuelles.Columns["capacidad_muelle"].DataPropertyName = "capacidad_muelle";
                dtgMuelles.Columns["tipo_muelle"].DataPropertyName = "tipo_muelle";
                dtgMuelles.Columns["estado"].DataPropertyName = "estado";
            

                return tabla;



            }
        }

        private void FrmInformeMuelle_Load(object sender, EventArgs e)
        {
            tablaOriginal = cargar_datos();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            cargar_datos();
        }

        private void cmbEstado_SelectedValueChanged(object sender, EventArgs e)
        {
            string estado = cmbEstado.SelectedItem?.ToString();


            try
            {
                var tablaFiltrada = tablaOriginal.AsEnumerable()
                    .Where(row => row.Field<string>("estado").Equals(estado));

                if (tablaFiltrada.Any())
                {
                    dtgMuelles.DataSource = tablaFiltrada.CopyToDataTable();
                }
                else
                {
                    dtgMuelles.DataSource = tablaOriginal.Clone(); // Muestra tabla vacía con columnas
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al filtrar la tabla: " + ex.Message);

            }
        }
    }


}
