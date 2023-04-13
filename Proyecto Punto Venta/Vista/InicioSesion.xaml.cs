using ServiceReferenceLogin;
using System;
using System.Collections.Generic;
using System.DirectoryServices;
using System.Linq;
using System.Security.Policy;
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


namespace Proyecto_Punto_Venta.Vista
{
    /// <summary>
    /// Lógica de interacción para InicioSesion.xaml
    /// </summary>
    public partial class InicioSesion : Window
    {
        public InicioSesion()
        {
            InitializeComponent();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string usuario = txtUser.Text;
            //string contrasena = txtPsw.Text;
            string contrasena = txtPsw.Password;

            string direccionServicioWeb = "http://localhost/webService_tienda/ws/login.asmx";
            ServiceReferenceLogin.login1SoapClient client = new ServiceReferenceLogin.login1SoapClient(new System.ServiceModel.BasicHttpBinding(), new System.ServiceModel.EndpointAddress(direccionServicioWeb));
            ServiceReferenceLogin.ValidacionSesion resultado = client.ValidarSesion(usuario, contrasena);
            if (resultado.Resultado)
            {
                string rol = resultado.TipoUsuario;
                if (rol == "empleado")
                {
                    MessageBox.Show("Bienvenido Empleado");
                }
                else if (rol == "admin")
                {
                    MessageBox.Show("Bienvenido Administrador");
                    MainWindow mainWindow = new MainWindow();
                    this.Close();
                    mainWindow.Show();
                }
            }
            else
            {
                MessageBox.Show("Inicio de sesión fallido");
            }
        }
    }
}
    