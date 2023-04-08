using Proyecto_Punto_Venta.Core;
using ServiceReferenceCrud;
using System;
using System.Collections.Generic;
using System.Linq;
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
            string direccionServicioWeb1 = "http://localhost/WebService_PuntoVenta/ws/CrudProductos.asmx";

            BasicHttpBinding basicHttp = new();
            EndpointAddress endpoint = new(direccionServicioWeb1);
            CrudProductosSoapClient clientBusqueda1 = new(basicHttp, endpoint);

            try
            {
                string resultadoBusqueda = null;
                if(txtBusqueda.Text.Length > 0) {
                    resultadoBusqueda = clientBusqueda1.BuscarProducto(int.Parse(txtBusqueda.Text.ToString()));
                    MessageBox.Show(resultadoBusqueda);
                }
                else
                {
                    resultadoBusqueda = "Ingresa el id de un producto para buscarlo";
                    MessageBox.Show(resultadoBusqueda);
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar producto: " + ex.Message);
                throw;
            }
        }

        private void txtBusqueda_TextChanged(object sender, TextChangedEventArgs e)
        {
           
        }
    }
}
