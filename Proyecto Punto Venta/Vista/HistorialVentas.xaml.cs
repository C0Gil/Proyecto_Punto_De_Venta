using Proyecto_Punto_Venta.Core;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
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
    }
}
