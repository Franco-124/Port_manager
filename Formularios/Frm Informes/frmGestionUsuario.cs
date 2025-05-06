using System;
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
            //permite no pasar un valor explícito y que Word use el valor predeterminado
            object ObjMiss = System.Reflection.Missing.Value;
            //ObjWord es una nueva instancia de Microsoft Word.
            Word.Application ObjWord = new Word.Application();
            //Se crea un nuevo documento de Word en blanco.
            Word.Document ObjDoc = ObjWord.Documents.Add(ref ObjMiss);
            //Activa el documento recién creado
            ObjDoc.Activate();

            Word.Section section = ObjDoc.Sections[1];
            Word.HeaderFooter header = section.Headers[Word.WdHeaderFooterIndex.wdHeaderFooterPrimary];

            // Insertar imagen en el encabezado
            Word.InlineShape logo = ObjWord.Selection.InlineShapes.AddPicture(@"C:\Users\Lenovo\Downloads\Universidad de Antioquia.jpg");

            // Redimensionar el logo
            logo.Width = 80; // Ancho
            logo.Height = 50; // Alto

            // alinear a la derecha
            ObjWord.Selection.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphRight;

            //Cambiar el color del texto a azul grisáceo.
            ObjWord.Selection.Font.Color = Word.WdColor.wdColorBlueGray;
            ObjWord.Selection.Font.Size = 14;
            
            ObjWord.Selection.TypeParagraph();//salto de linea
                                              //Centrar el texto del párrafo en la página.
            ObjWord.Selection.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
            ObjWord.Selection.TypeText("Informe de Usuario");

            ObjWord.Selection.TypeParagraph();
            ObjWord.Selection.TypeParagraph();
            ObjWord.Selection.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft;
            ObjWord.Selection.Font.Color = Word.WdColor.wdColorBlack;           
            ObjWord.Selection.TypeParagraph();
            ObjWord.Selection.TypeParagraph();

            int filas = dtgUsuarios.Rows.Count; // creamos el numero de filas
            int columnas = 4; // ISBN, Titulo, Fecha Entrega

            // Crear la tabla
            Word.Table tabla = ObjDoc.Tables.Add(ObjWord.Selection.Range, filas, columnas, ref ObjMiss, ref ObjMiss);

            // Formato de tabla
            tabla.Borders.Enable = 1;
            tabla.Range.Font.Size = 10;

            // Agregar encabezados
            tabla.Cell(1, 1).Range.Text = "ID";
            tabla.Cell(1, 2).Range.Text = "Usuario";
            tabla.Cell(1, 3).Range.Text = "Email";
            tabla.Cell(1, 4).Range.Text = "Rol";

            tabla.Rows[1].Range.Bold = 1;
            tabla.Rows[1].Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;

            // Agregamos datos del DataGridView
            for (int i = 0; i < filas - 1; i++) // Restamos 1 porque la última fila del DataGridView está vacía
            {
                //El signo de interrogación se usa para evitar errores por si no hay nada en la celda
                tabla.Cell(i + 2, 1).Range.Text = dtgUsuarios.Rows[i].Cells[0].Value?.ToString() ?? "";
                tabla.Cell(i + 2, 2).Range.Text = dtgUsuarios.Rows[i].Cells[1].Value?.ToString() ?? "";
                tabla.Cell(i + 2, 3).Range.Text = dtgUsuarios.Rows[i].Cells[2].Value?.ToString() ?? "";
                tabla.Cell(i + 2, 4).Range.Text = dtgUsuarios.Rows[i].Cells[3].Value?.ToString() ?? "";

            }

            ObjWord.Visible = true;
        }

        private void dtgUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
