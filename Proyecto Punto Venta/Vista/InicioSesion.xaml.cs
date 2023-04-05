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
            // Obtener usuario y contraseña de los campos de texto
            string usuario = txtUser.Text;
            string contrasena = txtPsw.Text;

            // Crear cliente del servicio web
            string direccionServicioWeb = "http://localhost/WebService_PuntoVenta/ws/login.asmx";
            ServiceReferenceLogin.login1SoapClient client = new ServiceReferenceLogin.login1SoapClient(new System.ServiceModel.BasicHttpBinding(), new System.ServiceModel.EndpointAddress(direccionServicioWeb));

            // Llamar a la función de inicio de sesión del servicio web
            ServiceReferenceLogin.ValidacionSesion resultado = client.ValidarSesion(usuario, contrasena);

            // Verificar el resultado de la validación de sesión
            if (resultado.Resultado)
            {
                // Iniciar sesión exitosa
                MessageBox.Show("Inicio de sesión exitoso");
                // Aquí puedes abrir la ventana principal de tu aplicación
            }
            else
            {
                // Iniciar sesión fallida
                MessageBox.Show("Inicio de sesión fallido");
            }



        }
    }
}
    