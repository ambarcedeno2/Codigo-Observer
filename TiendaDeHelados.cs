using ObserverPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.Implementaciones
{
    public class TiendaDeHelados : IPublisher
    {
        public string nombreDeHelado = "Cono"; 
        private List<IObserver> _listaDeObservadores;
        public TiendaDeHelados()
        {
            _listaDeObservadores= new List<IObserver>();  
        }
        public void addObserver(IObserver observer)
        {
            _listaDeObservadores.Add(observer);
        }

        public void notifyAll()
        {
            foreach (var observador in _listaDeObservadores)
            {
                observador.notify($"El helado llego! {nombreDeHelado}");
            }
        }

        public void removeObserver(IObserver observer)
        {
            _listaDeObservadores.Remove(observer);
        }

        public void LlegoElHelado(int numero)
        {
            Console.WriteLine($"Tienda: Mi helado llego...{numero} "); 
            nombreDeHelado = "magnum";     
            notifyAll();   
        }
    }
}