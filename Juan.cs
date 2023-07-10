using ObserverPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.Implementaciones
{
    public class Juan : IObserver
    {
        private TiendaDeHelados _tiendaDeHelados;
        public Juan(TiendaDeHelados tiendaDeHelados)
        {  
            _tiendaDeHelados = tiendaDeHelados;
            _tiendaDeHelados.addObserver(this);
        }
        
        public void notify(string mensaje)
        {
            Console.WriteLine($"Hola soy Juan : mensaje"); 
        }
    }
}  