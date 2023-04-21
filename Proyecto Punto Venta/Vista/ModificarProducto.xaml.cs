using ServiceReferenceCrud;
using System;
using System.ServiceModel;
using System.Windows;


namespace Proyecto_Punto_Venta.Vista
{
    /// <summary>
    /// Lógica de interacción para ModificarProducto.xaml
    /// </summary>
    public partial class ModificarProducto : Window
    {
        public ModificarProducto()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {        
            string direccionServicioWeb1 = "http://localhost/WebService_PuntoVenta/ws/CrudProductos.asmx";

            BasicHttpBinding basicHttp = new();
            EndpointAddress endpoint = new(direccionServicioWeb1);
            CrudProductosSoapClient client2 = new(basicHttp, endpoint);

            try
            {
                bool disponibilidad;
                if (rbtnDisp.IsChecked == false || rbtnNoDisp.IsChecked == true) { disponibilidad = false; }
                else { disponibilidad = true; }

                DateTime? fechaSeleccionada = dtpckFechaCad.SelectedDate;
                DateTime fechaCaducidad = fechaSeleccionada.Value.Date;

                string categoria = cmbCategoria.SelectedItem.ToString();
                string cadenaCMB = "System.Windows.Controls.ComboBoxItem: ";
                int categoriaReal = 0;

                if (categoria == cadenaCMB + "Frutas y Verduras") { categoriaReal = 1; }
                else if (categoria == cadenaCMB + "Carnes") { categoriaReal = 2; }
                else if (categoria == cadenaCMB + "Semillas") { categoriaReal = 3; }

                client2.ModificarProducto(int.Parse(txtCodigo.Text), txtProducto.Text.ToString(), double.Parse(txtPrecio.Text.ToString()), double.Parse(txtCosto.Text.ToString()), fechaCaducidad, int.Parse(txtStock.Text.ToString()), disponibilidad, categoriaReal);

                MessageBox.Show("Cambios Guardados");
                LimpiarFormulario();
            }


            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar producto: " + ex.Message);
                throw;
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
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
            if (disponibilidad == "False") { rbtnNoDisp.IsChecked = true; }
            else { rbtnDisp.IsChecked = true; }
            if (idcategoria == "1") { fV.IsSelected = true; }
        }
    }
}
