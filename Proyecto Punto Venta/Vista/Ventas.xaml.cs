using ServiceReferenceVentas;
using System;
using ServiceReferenceCrud;
using System.Windows;
using System.Windows.Controls;
using System.ServiceModel;
using System.Data.SqlClient;
using System.Data;
using System.Net;
using iTextSharp.text.pdf;
using System.IO;

namespace Proyecto_Punto_Venta.Vista
{
    /// <summary>
    /// Lógica de interacción para Ventas.xaml
    /// </summary>
    public partial class Ventas : UserControl
    {
        public Ventas()
        {
            InitializeComponent();
            Obtener_IdVenta();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string direccionServicioWeb1 = "http://localhost/WebService_PuntoVenta/ws/CrudProductos.asmx";

            BasicHttpBinding basicHttp = new();
            EndpointAddress endpoint = new(direccionServicioWeb1);
            CrudProductosSoapClient client2 = new(basicHttp, endpoint);
            
            string producto =  client2.BuscarProducto(int.Parse(txtBuscarInsertar.Text)).Item1;
            string precio = client2.BuscarProducto(int.Parse(txtBuscarInsertar.Text)).Item2;
            string cantidad;
            Double precioAuxiliar;
            
            if (string.IsNullOrEmpty(txtCantidadProducto.Text)) { cantidad = "1"; }
            else { cantidad = txtCantidadProducto.Text; }

            if(int.Parse(cantidad) > 1) 
            { precioAuxiliar = Double.Parse(precio) * Double.Parse(cantidad); precio = precioAuxiliar.ToString();}

            Agregar_ProductoVenta(lblIdVenta.Content.ToString(), txtBuscarInsertar.Text, cantidad);
            gdTablaVentas.Items.Add(new {Codigo = txtBuscarInsertar.Text, Producto = producto, Cantidad = cantidad, Precio = precio });
           
            lblSubtotal.Content = Double.Parse(lblSubtotal.Content.ToString()) + Double.Parse(precio);
            lblIva.Content = (Double.Parse(precio) * 0.16) + Double.Parse(lblIva.Content.ToString());
            lblTotal.Content = Double.Parse(lblSubtotal.Content.ToString()) + Double.Parse(lblIva.Content.ToString());

            txtBuscarInsertar.Text = "";
            txtCantidadProducto.Text = "";

            
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (gdTablaVentas.Items.Count > 0)
            {
                MessageBox.Show("Por el momento esta funcionalidad ha sido suspendidad :(");
                /*int index = gdTablaVentas.Items.Count - 1;
                gdTablaVentas.Items.RemoveAt(index);

                Eliminar_UltimosRegistros();*/
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Limpiar_Pantalla();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {                        
            string direccionServicioWeb2 = "http://localhost/WebService_PuntoVenta/ws/CrudVentas.asmx";

            BasicHttpBinding basicHttp2 = new();
            EndpointAddress endpoint2 = new(direccionServicioWeb2);
            CrudVentasSoapClient clienteVentas = new(basicHttp2, endpoint2);

            clienteVentas.InsertarVenta(DateTime.Now, Double.Parse(lblTotal.Content.ToString()));
            clienteVentas.IsertarUsuarioVenta("3", lblIdVenta.Content.ToString());
            //GenerarTicket(int.Parse(lblIdVenta.Content.ToString()));
            Limpiar_Pantalla();
        }

        public void Limpiar_Pantalla()
        {
            gdTablaVentas.Items.Clear();
            lblSubtotal.Content = "000.00";
            lblIva.Content = "000.00";
            lblTotal.Content = "000.00";
            lblDescuento.Content = "000.00";
            txtBuscarInsertar.Text = "";
            txtCantidadProducto.Text = "";
        }

        public void Obtener_IdVenta()
        {
            string connectionString = "Data Source=DESKTOP-H08JMC2\\SQLEXPRESS; Initial Catalog=tienda; User ID=sa; Password=1234.abcd";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT TOP (1) [idVenta] FROM [tienda].[dbo].[Ventas] ORDER BY [idVenta] DESC";
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    int i = reader.GetInt32(0) + 1;
                    lblIdVenta.Content = i.ToString();
                }
                reader.Close();
            }
        }

        public void Eliminar_UltimosRegistros()
        {
            // Creamos una conexión a la base de datos
            string connectionString = "Data Source=DESKTOP-H08JMC2\\SQLEXPRESS; Initial Catalog=tienda; User ID=sa; Password=1234.abcd";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string consulta = "DELETE FROM [tienda].[dbo].[VentaProducto] WHERE [idVentaProducto] = ( SELECT TOP 1 [idVentaProducto] FROM [tienda].[dbo].[VentaProducto] ORDER BY [idVentaProducto] DESC)";

                SqlCommand command = new SqlCommand(consulta, connection);

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
        }
    
        public void Agregar_ProductoVenta(string idVenta, string idProducto, string cantidad)
        {
            string direccionServicioWeb2 = "http://localhost/WebService_PuntoVenta/ws/CrudVentas.asmx";

            BasicHttpBinding basicHttp2 = new();
            EndpointAddress endpoint2 = new(direccionServicioWeb2);
            CrudVentasSoapClient clienteVentas = new(basicHttp2, endpoint2);

            clienteVentas.IsertarVentaProducto(idVenta, idProducto, cantidad);
        }

        public void GenerarTicket(int venta)
        {
            string rutaDescargas = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\Downloads\\";

            iTextSharp.text.Document document = new iTextSharp.text.Document(iTextSharp.text.PageSize.A4, 50, 50, 25, 25);

            MemoryStream stream = new MemoryStream();


            PdfWriter writer = PdfWriter.GetInstance(document, stream);

            document.Open();


            iTextSharp.text.Paragraph titulo = new iTextSharp.text.Paragraph("Ticket de venta");
            titulo.Alignment = iTextSharp.text.Element.ALIGN_CENTER;
            titulo.Font = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 18, iTextSharp.text.Font.BOLD);
            document.Add(titulo);

            document.Add(new iTextSharp.text.Paragraph("\n"));

            string inputVenta = Microsoft.VisualBasic.Interaction.InputBox("Introduzca el número de venta:", "Ticket de venta", "");
            if (!Int32.TryParse(inputVenta, out venta))
            {
                MessageBox.Show("Número de venta inválido");
                return;
            }

            string cadenaConexion = "Data Source=DESKTOP-H08JMC2\\SQLEXPRESS; Initial Catalog=tienda; User ID=sa; Password=1234.abcd";
            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {

                SqlCommand comando = new SqlCommand("ticket", conexion);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@venta", venta);

                conexion.Open();
                SqlDataReader reader = comando.ExecuteReader();

                PdfPTable tabla = new PdfPTable(5);
                tabla.WidthPercentage = 100;
                tabla.SetWidths(new float[] { 3, 3, 3, 3, 3 });

                while (reader.Read())
                {
                    tabla.AddCell(new iTextSharp.text.Phrase(reader.GetString(0)));
                    tabla.AddCell(new iTextSharp.text.Phrase(reader.GetDateTime(1).ToString()));
                    tabla.AddCell(new iTextSharp.text.Phrase(reader.GetString(2)));
                    tabla.AddCell(new iTextSharp.text.Phrase(reader.GetDecimal(3) == null ? "" : reader.GetDecimal(3).ToString()));
                    tabla.AddCell(new iTextSharp.text.Phrase(reader.GetDecimal(4) == null ? "" : reader.GetDecimal(4).ToString()));
                }

                reader.Close();
                conexion.Close();

                document.Add(tabla);

                document.Close();

                File.WriteAllBytes(rutaDescargas + "ticket_venta_" + venta + ".pdf", stream.ToArray());

                MessageBox.Show("El PDF se ha generado correctamente en la ruta de descargas por defecto.");
            }


        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            lblDescuento.Content = Double.Parse(lblSubtotal.Content.ToString()) * 0.10;
            lblTotal.Content = Double.Parse(lblTotal.Content.ToString()) - Double.Parse(lblDescuento.Content.ToString());
        }
    }
}
