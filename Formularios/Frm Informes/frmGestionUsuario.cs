﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
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
    public partial class frmGestionUsuario : Form
    {
        public frmGestionUsuario()
        {
            InitializeComponent();
            cargar_datos();
        }

        
        //Metodo para cargar valores al Datagrid de informe de usuarios.
        public void cargar_datos()
        {
            string consulta = "select id_usuario, nombre_usuario, email, rol from usuarios";
            using (SqlConnection conexion = DatabaseHelper.GetConnection()) 
            {
                SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion);
                DataTable tabla = new DataTable();
                adaptador.Fill(tabla);

                dtgUsuarios.AutoGenerateColumns = false; 
                dtgUsuarios.DataSource = tabla;

                
                dtgUsuarios.Columns["id_usuario"].DataPropertyName = "id_usuario";
                dtgUsuarios.Columns["nombre_usuario"].DataPropertyName = "nombre_usuario";
                dtgUsuarios.Columns["email"].DataPropertyName = "email";
                dtgUsuarios.Columns["rol"].DataPropertyName = "rol";

            }
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
            ObjWord.Selection.TypeText("Informe de Usuarios");
            ObjWord.Selection.TypeParagraph();

            // Fecha de impresión
            ObjWord.Selection.Font.Size = 12;
            ObjWord.Selection.Font.Bold = 0;
            ObjWord.Selection.TypeText("Fecha de impresión: " + DateTime.Now.ToString("dddd, dd MMMM yyyy"));
            ObjWord.Selection.TypeParagraph();
            ObjWord.Selection.TypeParagraph();

            // Tabla
            int filas = dtgUsuarios.Rows.Count;
            int columnas = 4;

            Word.Table tabla = ObjDoc.Tables.Add(ObjWord.Selection.Range, filas, columnas, ref ObjMiss, ref ObjMiss);
            tabla.Borders.Enable = 1;
            tabla.Range.Font.Size = 11;
            tabla.Range.Font.Name = "Calibri";

            string[] encabezados = { "ID", "Usuario", "Email", "Rol" };
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
                    string texto = dtgUsuarios.Rows[i].Cells[j].Value?.ToString() ?? "";
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
                string fileName = $"Informe_Usuarios_{DateTime.Now:yyyyMMdd_HHmm}.pdf";
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

        private void dtgUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
