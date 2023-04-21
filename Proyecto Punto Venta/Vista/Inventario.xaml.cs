using Proyecto_Punto_Venta.Core;
using ServiceReferenceCrud;
using System;
using System.Data;
using System.ServiceModel;
using System.Windows;
using System.Windows.Controls;


namespace Proyecto_Punto_Venta.Vista
{
    /// <summary>
    /// Lógica de interacción para Inventario.xaml
    /// </summary>
    public partial class Inventario : UserControl
    {
        public Inventario()
        {
            InitializeComponent();
            Tabla();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            InsertarProductos insertar = new InsertarProductos();
            insertar.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

            EliminarProducto eliminar= new EliminarProducto();
            eliminar.Show();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            ModificarProducto modificar = new ModificarProducto();
            modificar.Show();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            string direccionServicioWeb1 = "http://localhost/webService_tienda/ws/CrudProductos.asmx";
            string id, producto, pVenta, pCompra, stock, disponibilidad, categoria;

            BasicHttpBinding basicHttp = new();
            EndpointAddress endpoint = new(direccionServicioWeb1);
            CrudProductosSoapClient clientBusqueda1 = new(basicHttp, endpoint);

            try
            {

                if (txtBusqueda.Text.Length > 0) {

                    id = clientBusqueda1.BuscarProducto(int.Parse(txtBusqueda.Text.ToString())).Item1;
                    producto = clientBusqueda1.BuscarProducto(int.Parse(txtBusqueda.Text.ToString())).Item2;
                    pVenta = clientBusqueda1.BuscarProducto(int.Parse(txtBusqueda.Text.ToString())).Item3;
                    pCompra = clientBusqueda1.BuscarProducto(int.Parse(txtBusqueda.Text.ToString())).Item4;
                    stock = clientBusqueda1.BuscarProducto(int.Parse(txtBusqueda.Text.ToString())).Item5;
                    disponibilidad = clientBusqueda1.BuscarProducto(int.Parse(txtBusqueda.Text.ToString())).Item6;
                    categoria = clientBusqueda1.BuscarProducto(int.Parse(txtBusqueda.Text.ToString())).Item7;

                    MessageBox.Show("ID: " + id + "\nNombre: " + producto + "\nPrecio de Venta: " + 
                        pVenta + "\nPrecio de Venta" + pCompra + "\nStock" + stock + "\nDisponible: " + 
                        disponibilidad + "\nCategoria: " + categoria);
                }
                else
                {
                    MessageBox.Show("Ingresa el id de un producto para buscarlo");
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar producto: " + ex.Message);
                throw;
            }
        }

        public void Tabla()
        {
            DataAccess dataAccess = new DataAccess();
            DataTable dataTable = dataAccess.ExecuteQuery("SELECT * FROM [tienda].[dbo].[VistaProductoCategoria]");
            gvInventario.ItemsSource = dataTable.DefaultView;
        }

        private void gvInventario_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
