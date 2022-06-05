using System;
namespace Juego{

    class Peleas{

        public Personaje Pelear(Personaje Atacante , Personaje Defensor){
            Random p = new Random();
            int band = 0;
            Console.WriteLine("Tiraremos una moneda para ver quien empeiza, elege 1=Cara /2 = Cruz");
            int flip = p.Next(1,3);
            int opc = Convert.ToInt32(Console.ReadLine());
            if (flip == opc )
            {
                Console.WriteLine("Salio {0} P1 comienza",opc);

                
            }else
            {
                Console.WriteLine("Salio {0} P2 comienza",opc);
                Personaje aux;
                aux = Atacante;
                Atacante = Defensor;
                Defensor = aux;
            }
            string ApodoAtaca = Atacante.Datos1.Apodo1;
            string ApodoDef = Defensor.Datos1.Apodo1;
            for (int i = 0; i < 3; i++)
            {
                
                bool muertoAta, muertoDef;
                Console.WriteLine("{0} VS {1} ",ApodoAtaca , ApodoDef);
                Console.WriteLine("Turno {0}",i+1);
                int DAPRO = 0;
                Console.WriteLine("Casteando ataque de {0}",ApodoAtaca);
                Thread.Sleep(2000);
                DAPRO = Atacante.DañoProvocado(Defensor);
                Console.WriteLine("El daño provocado por {0} a {1} es : {2}",ApodoAtaca, ApodoDef , DAPRO);
                Defensor.ActuaizarVida(DAPRO);
                muertoDef = Defensor.GameOver();

                if (muertoDef)
                {
                    band = 1;
                    break;
                }

                Console.WriteLine("Turno de {0}", ApodoDef);
                Console.WriteLine("");
                Console.WriteLine("Casteando ataque de {0}",ApodoDef);
                Thread.Sleep(2000);
                DAPRO = 0;
                DAPRO = Defensor.DañoProvocado(Atacante);
                Console.WriteLine("El daño provocado por {0} a {1} es : {2}",ApodoDef, ApodoAtaca , DAPRO);
                Atacante.ActuaizarVida(DAPRO);
                muertoAta = Atacante.GameOver();
                if (muertoAta)
                {
                    band = 2;
                    break;
                }

                Console.WriteLine("FIN DEL TURNO");
                Console.WriteLine("STATS DE {0}",ApodoAtaca);
                Atacante.MostrarDatos();
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("STATS DE {0}",ApodoDef);
                Defensor.MostrarDatos();
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("Aprete cualquier tecla para iniciar el sig turno");
                Console.ReadKey();
                Console.WriteLine("//////////////////////////////////////////////////////////////////////////////////////////////////////////////////");
            }
            if (band == 1)
            {
                Console.WriteLine("El ganador es {0} ",ApodoAtaca);
                Console.WriteLine("Procedemos a actualizar su Status");
                Atacante.ActualizarStats();
                Console.WriteLine("//////////////////////////////////////////////////////////////////////////////////////////////////////////////////");
                
                return Atacante;
            }else
            {
                if (band == 2)
                {
                    Console.WriteLine("El ganador es {0} ",ApodoDef);
                    Console.WriteLine("Procedemos a actualizar su Status");
                    Defensor.ActualizarStats();
                    return Defensor;
                    
                }else
                {
                    if (Atacante.Datos1.Salud1 > Defensor.Datos1.Salud1)
                    {
                        Console.WriteLine("El ganador es {0} ",ApodoAtaca);
                        Console.WriteLine("Procedemos a actualizar su Status");
                        Atacante.ActualizarStats();
                        return Atacante;
                    }else
                    {
                        Console.WriteLine("El ganador es {0} ",ApodoDef);
                        Console.WriteLine("Procedemos a actualizar su Status");
                        Defensor.ActualizarStats();
                        return Defensor;
                    }
                }
                
            }

           


        }

    }
}