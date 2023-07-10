using ObserverPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ObserverPattern.Implementaciones
{
    public class Pedro : IObserver
    {
        private TiendaDeHelados _tiendaDeHelados;
        public Pedro(TiendaDeHelados tiendaDeHelados)
        {  
            _tiendaDeHelados = tiendaDeHelados;
            _tiendaDeHelados.addObserver(this);
        }
        public void notify(string mensaje)
        {
            Console.WriteLine($"Hola soy Pedro : mensaje"); 
        }
    }
}    