using System;
namespace Juego{
    class Program
    {
        static void Main(string[] args){

            Peleas match = new Peleas();
            Personaje Winner = new Personaje();
            List<Personaje> Jugadores  = new List<Personaje>(); 
            Console.WriteLine("Cuantos jugadores desea crear?");
            int cant = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < cant; i++)
            {
                Personaje p1 = new Personaje();
                p1.CrearPersonaje();
                Jugadores.Add(p1);
            }
            Winner = Jugadores[0];
            for (int i = 0; i < cant; i++)
            {
                
                int next = i+1;
                Console.WriteLine("Combate {0}", next);
                if (Jugadores.ElementAtOrDefault(next) != null)
                {
                    Winner = match.Pelear(Winner, Jugadores[next]);
                }
                
            }
            Console.WriteLine("//////////////////////////////////////////////////////////////////////////////////////////////////////////////////");
            Console.WriteLine("El ganador absoluto es : {0}" ,Winner.Datos1.Apodo1);
            Console.WriteLine("//////////////////////////////////////////////////////////////////////////////////////////////////////////////////");
            Console.WriteLine("Sus stats finales son: ");
            Winner.MostrarDatos();
            Winner.MostrarCarac();

            

            

            
        }
    }
}
