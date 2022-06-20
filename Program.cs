using System;
using System.Text.Json;
using System.Text;
namespace Juego{
    class Program
    {
        static void Main(string[] args){
            int cant , flag = 0;
            Peleas match = new Peleas();
            Personaje Winner = new Personaje();
            Console.WriteLine("Desea volver a jugar con los personajes de la partidas anterior? 1- Si o 2 - No");
            int opcion14 = Convert.ToInt32(Console.ReadLine());
            List<Personaje> Jugadores  = new List<Personaje>(); 
            if (opcion14 == 1)
            {
                string path = @"C:\Users\facun\OneDrive\Escritorio\RPG\rpg-2022-Facas27\Personajes.json";
                if(!File.Exists(path)){
                    File.Create(path);
                    File.Create(path).Close();
                    Console.WriteLine("No se puede cargar partida porque no existe");
                    flag = 1;

                }else
                {
                    string jsonread = File.ReadAllText(path);
                    Jugadores = JsonSerializer.Deserialize<List<Personaje>>(jsonread);

                }
                cant = Jugadores.Count();
                
            }else
            {
                Console.WriteLine("Cuantos jugadores desea crear?");
               cant = Convert.ToInt32(Console.ReadLine());
                for (int i = 0; i < cant; i++)
                {
                    Personaje p1 = new Personaje();
                    p1.CrearPersonaje();
                    Jugadores.Add(p1);
                }
                
            }
            if (flag == 1)
            {
                Console.WriteLine("Cuantos jugadores desea crear?");
               cant = Convert.ToInt32(Console.ReadLine());
                for (int i = 0; i < cant; i++)
                {
                    Personaje p1 = new Personaje();
                    p1.CrearPersonaje();
                    Jugadores.Add(p1);
                }
                
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
            Console.WriteLine("Subiendo SCORE del ganador");
            Winner.UploadScore(cant);
            Console.WriteLine("Desea ver el Score de los campeones ganadores?(1= SI , 2=NO)");
            int opc12 = Convert.ToInt32(Console.ReadLine());
            if (opc12 == 1)
            {
                MostrarScore();
            }
            Console.WriteLine("Desea guardar los datos de la partida? 1- Si// 2- NO");
            opcion14 = Convert.ToInt32(Console.ReadLine());
            if (opcion14 == 1)
            {
                string path = @"C:\Users\facun\OneDrive\Escritorio\RPG\rpg-2022-Facas27\Personajes.json";
                string json = JsonSerializer.Serialize(Jugadores);
                File.WriteAllText(path, json);
                
            }


            

            

            
        }
        public static void MostrarScore(){
             string path = @"C:\Users\facun\OneDrive\Escritorio\RPG\rpg-2022-Facas27\score.csv";
            if (File.Exists(path))
            {
                string[]leer = File.ReadAllLines(path);
                foreach (string item in leer)
                {
                    Console.WriteLine(item);
                }
                
            }else
            {
                Console.Write("El archivo que desea abrir no existe o no se pudo abrir");
            }
        }
        
    }
    
}
