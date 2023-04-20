using MahApps.Metro.Controls.Dialogs;
using Microsoft.Win32;
using Proyecto_Punto_Venta.Core;
using ServiceReferenceCrud;
using ServiceReferenceReportes;
using System;
using System.Collections.Generic;
using System.Data;
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
            int mesActual = DateTime.Now.Month;
            string url = $"http://localhost/webService_tienda/ws/GeneradorReportes.asmx?op=MostrarVentasPorMes={mesActual}";

            try
            {
                HttpClient client = new HttpClient();
                HttpResponseMessage response = await client.GetAsync(url);
                response.EnsureSuccessStatusCode();

                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "PDF file";
                saveFileDialog.FileName = $"ReporteVentas-{mesActual}.pdf";

                if (saveFileDialog.ShowDialog() == true)
                {
                    using Stream stream = await response.Content.ReadAsStreamAsync();
                    byte[] buffer = new byte[16 * 1024];
                    int bytesRead;
                    int totalBytesRead = 0;
                    while ((bytesRead = await stream.ReadAsync(buffer, 0, buffer.Length)) > 0)
                    {
                        totalBytesRead += bytesRead;
                        using FileStream fileStream = new FileStream(saveFileDialog.FileName, FileMode.Append, FileAccess.Write);
                        await fileStream.WriteAsync(buffer, 0, bytesRead);
                    }

                    if (totalBytesRead > 0)
                    {
                        MessageBox.Show("Reporte descargado exitosamente.");
                    }
                    else
                    {
                        MessageBox.Show("El archivo descargado está vacío o es corrupto.");
                        File.Delete(saveFileDialog.FileName);
                    }
                }
            }
            catch (HttpRequestException ex)
            {
                MessageBox.Show($"Ha ocurrido un error al descargar el reporte: {ex.Message}");
            }




        }
    }
}
