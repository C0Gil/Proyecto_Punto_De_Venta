using ServiceReferenceCrud;
using System.ServiceModel;
using System.Windows;


namespace Proyecto_Punto_Venta.Vista
{
    /// <summary>
    /// Lógica de interacción para EliminarProducto.xaml
    /// </summary>
    public partial class EliminarProducto : Window
    {
        public EliminarProducto()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string direccionServicioWeb1 = "http://localhost/WebService_PuntoVenta/ws/CrudProductos.asmx";

            BasicHttpBinding basicHttp = new();
            EndpointAddress endpoint = new(direccionServicioWeb1);
            CrudProductosSoapClient client2 = new(basicHttp, endpoint);

            client2.EliminarProducto(int.Parse(txtCodigo.Text));
            MessageBox.Show("Producto Eliminado");
            LimpiarFormulario();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            string direccionServicioWeb1 = "http://localhost/WebService_PuntoVenta/ws/CrudProductos.asmx";

            BasicHttpBinding basicHttp = new();
            EndpointAddress endpoint = new(direccionServicioWeb1);
            CrudProductosSoapClient client2 = new(basicHttp, endpoint);
            string producto, precioVenta, precioCompra, fechaCadu, stock, disponibilidad, idcategoria;

            producto = client2.BuscarProducto(int.Parse(txtCodigo.Text)).Item1;
            precioVenta = client2.BuscarProducto(int.Parse(txtCodigo.Text)).Item2;
            precioCompra = client2.BuscarProducto(int.Parse(txtCodigo.Text)).Item3;
            fechaCadu = client2.BuscarProducto(int.Parse(txtCodigo.Text)).Item4;
            stock = client2.BuscarProducto(int.Parse(txtCodigo.Text)).Item5;
            disponibilidad = client2.BuscarProducto(int.Parse(txtCodigo.Text)).Item6;
            idcategoria = client2.BuscarProducto(int.Parse(txtCodigo.Text)).Item7;

            txtProducto.Text = producto;
            txtPrecio.Text = precioVenta;
            txtCosto.Text = precioCompra;
            dtpckFechaCad.Text = fechaCadu;
            txtStock.Text = stock;
            if (disponibilidad == "False"){ rbtnNoDisp.IsChecked = true; }
            else { rbtnDisp.IsChecked = true; }
            if(idcategoria == "1") { fV.IsSelected= true; }
        }

        public void LimpiarFormulario()
        {
            txtCodigo.Text = "";
            txtProducto.Text = "";
            txtPrecio.Text = "";
            txtCosto.Text = "";
            dtpckFechaCad.Text = "";
            txtStock.Text = "";
            rbtnDisp.IsChecked = false;
            rbtnNoDisp.IsChecked = false;
            cmbCategoria.ItemsSource = null;
        }
    }
}
