using System;
namespace Juego{
    class Program
    {
        static void Main(string[] args){
            
            Personaje p1 = new Personaje();
            Personaje p2 = new Personaje();
            Peleas match = new Peleas();

            p1.CrearPersonaje();
            p2.CrearPersonaje();
            match.Pelear(p1, p2);

            
        }
    }
}
