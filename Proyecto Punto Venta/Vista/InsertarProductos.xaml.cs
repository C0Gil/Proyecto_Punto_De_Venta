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
using System.Windows.Shapes;
using System.Globalization;
using System.Text.RegularExpressions;

namespace Proyecto_Punto_Venta.Vista
{
    /// <summary>
    /// Lógica de interacción para InsertarProductos.xaml
    /// </summary>
    public partial class InsertarProductos : Window
    {
        public InsertarProductos()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // Dirección del servicio web
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

                if(categoria == cadenaCMB + "Frutas y Verduras") { categoriaReal = 1; }
                else if(categoria == cadenaCMB + "Carnes") { categoriaReal = 2; }
                else if(categoria == cadenaCMB + "Semillas") { categoriaReal = 3;}

                client2.InsertarProducto(int.Parse(txtCodigo.Text), txtProducto.Text.ToString(), double.Parse(txtPrecio.Text.ToString()), double.Parse(txtCosto.Text.ToString()), fechaCaducidad, int.Parse(txtStock.Text.ToString()), disponibilidad, categoriaReal);
                
                MessageBox.Show("Producto agregado con exito");
                LimpiarFormulario();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar producto: " + ex.Message );
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

        private void cmbCategoria_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        
    }
}
