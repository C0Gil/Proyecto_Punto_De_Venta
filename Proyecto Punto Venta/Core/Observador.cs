using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Proyecto_Punto_Venta.Core
{
    internal class Observador : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged; //En caso de error, colocar ? despues de PropertyChangedEventHandler

        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
