using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto_Punto_Venta.Core;
namespace Proyecto_Punto_Venta.VistaModelo
{
    internal class VistaModeloPrincipal :Observador 
    {

        public RelayCommand VentasVMCommand { get; set; }

        public RelayCommand InventarioVMCommand { get; set; }

        public VistaModeloVentas VentasVM { get; set; }

        public VistaModeloInventario InventarioVM { get; set; }

        private object _currentView;

        public object CurrentView
        {
            get { return _currentView; }
            set 
            { 
                _currentView = value;
                OnPropertyChanged();
            }
        }


        public VistaModeloPrincipal()
        {
            VentasVM= new VistaModeloVentas();
            InventarioVM= new VistaModeloInventario();

            CurrentView = VentasVM;

            VentasVMCommand = new RelayCommand(o => 
            {
                CurrentView = VentasVM;
            });
            InventarioVMCommand = new RelayCommand(o =>
            {
                CurrentView = InventarioVM;
            });
        }
    }
}
