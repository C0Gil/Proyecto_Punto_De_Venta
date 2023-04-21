using MahApps.Metro.Controls.Dialogs;
using Microsoft.Win32;
using Proyecto_Punto_Venta.Core;
using ServiceReferenceCrud;
using ServiceReferenceReportes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Policy;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

namespace Proyecto_Punto_Venta.Vista
{
    /// <summary>
    /// Lógica de interacción para HistorialVentas.xaml
    /// </summary>
    public partial class HistorialVentas : UserControl
    {
        public HistorialVentas()
        {
            InitializeComponent();
            Tabla();
        }

        public void Tabla()
        {
            DataAccess dataAccess = new DataAccess();
            DataTable dataTable = dataAccess.ExecuteQuery("SELECT * FROM [tienda].[dbo].[VistaVentaVendedor]");
            gvHistorialVenta.ItemsSource = dataTable.DefaultView;
        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            string rutaDescargas = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\Downloads\\";

            iTextSharp.text.Document document = new iTextSharp.text.Document(iTextSharp.text.PageSize.A4, 50, 50, 25, 25);

            MemoryStream stream = new MemoryStream();


            PdfWriter writer = PdfWriter.GetInstance(document, stream);

            document.Open();


            iTextSharp.text.Paragraph titulo = new iTextSharp.text.Paragraph("Ventas por mes");
            titulo.Alignment = iTextSharp.text.Element.ALIGN_CENTER;
            titulo.Font = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 18, iTextSharp.text.Font.BOLD);
            document.Add(titulo);

            document.Add(new iTextSharp.text.Paragraph("\n"));

            iTextSharp.text.pdf.PdfPTable tabla = new iTextSharp.text.pdf.PdfPTable(4);
            tabla.WidthPercentage = 100;
            tabla.SetWidths(new float[] { 3, 3, 3, 3 });

            tabla.AddCell(new iTextSharp.text.Phrase("Fecha de venta"));
            tabla.AddCell(new iTextSharp.text.Phrase("Producto"));
            tabla.AddCell(new iTextSharp.text.Phrase("Monto"));
            tabla.AddCell(new iTextSharp.text.Phrase("Precio de venta"));

            string cadenaConexion = "Data Source=JONATHAN\\SQLEXPRESS; Initial Catalog=PCSG1JHON; User ID= sa; Password=aaa";
            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {

                SqlCommand comando = new SqlCommand("MostrarVentasPorMes", conexion);
                comando.CommandType = CommandType.StoredProcedure;


                comando.Parameters.AddWithValue("@Mes", 1);


                conexion.Open();
                SqlDataReader reader = comando.ExecuteReader();


                while (reader.Read())
                {
                    tabla.AddCell(new iTextSharp.text.Phrase(reader.GetDateTime(0).ToString()));
                    tabla.AddCell(new iTextSharp.text.Phrase(reader.GetString(1)));
                    tabla.AddCell(new iTextSharp.text.Phrase(reader.GetDecimal(2).ToString()));
                    tabla.AddCell(new iTextSharp.text.Phrase(reader.GetDecimal(3).ToString()));
                }


                reader.Close();
                conexion.Close();
            }


            document.Add(tabla);

            document.Close();

            DataTable dtVentas = new DataTable();
            using (SqlConnection connection = new SqlConnection(cadenaConexion))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("MostrarVentasPorMes", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@Mes", 4); // Aquí se puede cambiar el mes a consultar
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dtVentas);
            }


            PdfPTable table = new PdfPTable(dtVentas.Columns.Count);
            for (int i = 0; i < dtVentas.Columns.Count; i++)
            {
                PdfPCell cell = new PdfPCell(new Phrase(dtVentas.Columns[i].ColumnName));
                cell.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240);
                table.AddCell(cell);
            }

            for (int i = 0; i < dtVentas.Rows.Count; i++)
            {
                for (int j = 0; j < dtVentas.Columns.Count; j++)
                {
                    table.AddCell(dtVentas.Rows[i][j].ToString());
                }
            }

            document = new iTextSharp.text.Document(iTextSharp.text.PageSize.A4, 50, 50, 25, 25);


            stream = new MemoryStream();


            writer = PdfWriter.GetInstance(document, stream);


            document.Open();


            document.Add(table);

            document.Close();

            File.WriteAllBytes(rutaDescargas + "ventas_mes_4.pdf", stream.ToArray());

            MessageBox.Show("El PDF se ha generado correctamente en la ruta de descargas por defecto.");



        }
    }
}
