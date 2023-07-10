// See https://aka.ms/new-console-template for more information
using ObserverPattern.Implementaciones;
//Console.WriteLine("Hello, World!");

internal class Program
{
    private static async Task Main(string[] args)
    {
        TiendaDeHelados tiendaDeHelados = new TiendaDeHelados();

        Juan juan = new Juan(tiendaDeHelados);
        Pedro Pedro = new Pedro(tiendaDeHelados);

        var timer = new PeriodicTimer(TimeSpan.FromSeconds(2));

        int i = 0;
        while (await timer.WaitForNextTickAsync())
        {
            tiendaDeHelados.LlegoElHelado(i);
            i++;
        }
    }
}