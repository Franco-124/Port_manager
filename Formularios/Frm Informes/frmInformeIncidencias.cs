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
using Word = Microsoft.Office.Interop.Word;
using System.IO;
namespace Port_manager.Formularios
{
    public partial class frmInformeIncidencias : Form
    {
        public frmInformeIncidencias()
        {
            InitializeComponent();
            cargar_datos();

        }

        public void cargar_datos()
        {
            string consulta = "select numero_incidencia, serial_buque, tipo_incidencia, ubicacion, descripcion,  estado, nombre_admin from Incidencias";
            using (SqlConnection conexion = DatabaseHelper.GetConnection())
            {
                SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion);
                DataTable tabla = new DataTable();
                adaptador.Fill(tabla);

                dtgIncidencias.AutoGenerateColumns = false;


                dtgIncidencias.DataSource = tabla;

                dtgIncidencias.Columns["numero_incidencia"].DataPropertyName = "numero_incidencia";
                dtgIncidencias.Columns["serial_buque"].DataPropertyName = "serial_buque";
                dtgIncidencias.Columns["tipo_incidencia"].DataPropertyName = "tipo_incidencia";
                dtgIncidencias.Columns["ubicacion"].DataPropertyName = "ubicacion";
                dtgIncidencias.Columns["descripcion"].DataPropertyName = "descripcion";
                dtgIncidencias.Columns["estado"].DataPropertyName = "estado";
                dtgIncidencias.Columns["nombre_admin"].DataPropertyName = "nombre_admin";
            }
        }

        private void dtgIncidencias_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dtgIncidencias_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

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
            ObjWord.Selection.TypeText("Informe de Incidencias Registradas");
            ObjWord.Selection.TypeParagraph();

            // Fecha de impresión
            ObjWord.Selection.Font.Size = 12;
            ObjWord.Selection.Font.Bold = 0;
            ObjWord.Selection.TypeText("Fecha de impresión: " + DateTime.Now.ToString("dddd, dd MMMM yyyy"));
            ObjWord.Selection.TypeParagraph();
            ObjWord.Selection.TypeParagraph();

            // Tabla
            int filas = dtgIncidencias.Rows.Count;
            int columnas = 7;

            Word.Table tabla = ObjDoc.Tables.Add(ObjWord.Selection.Range, filas, columnas, ref ObjMiss, ref ObjMiss);
            tabla.Borders.Enable = 1;
            tabla.Range.Font.Size = 11;
            tabla.Range.Font.Name = "Calibri";

            string[] encabezados = { "Numero Incidencia", "Serial Buque", "Incidencia", "Ubicación", "Descripción", "Estado","Nombre de Administrador" };
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
                    string texto = dtgIncidencias.Rows[i].Cells[j].Value?.ToString() ?? "";
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
                string fileName = $"Informe_Incidencias_{DateTime.Now:yyyyMMdd_HHmm}.pdf";
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
    }
}
