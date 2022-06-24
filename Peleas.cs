using System.Net;
using System.Text.Json.Serialization;
namespace Juego
{

    class Peleas{

        public Personaje Pelear(Personaje Atacante , Personaje Defensor){
            Random p = new Random();
            int band = 0;
            Console.WriteLine("Tiraremos una moneda para ver quien empieza, elige 1=Cara /2 = Cruz");
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

                Console.WriteLine("\n");
                Countrys();
                Console.WriteLine("\n");
                Thread.Sleep(2000);
                Console.ResetColor();
                bool muertoAta, muertoDef;
                Console.WriteLine("{0} VS {1} ",ApodoAtaca , ApodoDef);
                Console.WriteLine("Turno {0}",i+1);
                int DAPRO = 0;
                Console.WriteLine("{0} ataca con {1}",ApodoAtaca, Ataques());
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
                Console.WriteLine("{0} ataca con {1}",ApodoDef,Ataques());
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
        static public void Countrys(){
            Random p = new Random();
            string[] Urls = {$"http://www.geognos.com/api/en/countries/info/AR.json" , $"http://www.geognos.com/api/en/countries/info/US.json", $"http://www.geognos.com/api/en/countries/info/AF.json" , $"http://www.geognos.com/api/en/countries/info/DZ.json" , $"http://www.geognos.com/api/en/countries/info/JP.json", $"http://www.geognos.com/api/en/countries/info/BR.json" , $"http://www.geognos.com/api/en/countries/info/CH.json" ,$"http://www.geognos.com/api/en/countries/info/CL.json", $"http://www.geognos.com/api/en/countries/info/EG.json", $"http://www.geognos.com/api/en/countries/info/IE.json", $"http://www.geognos.com/api/en/countries/info/MX.json", $"http://www.geognos.com/api/en/countries/info/ES.json", $"http://www.geognos.com/api/en/countries/info/RS.json", $"http://www.geognos.com/api/en/countries/info/TR.json", $"http://www.geognos.com/api/en/countries/info/QA.json", $"http://www.geognos.com/api/en/countries/info/RU.json", $"http://www.geognos.com/api/en/countries/info/ZA.json", $"http://www.geognos.com/api/en/countries/info/NZ.json", $"http://www.geognos.com/api/en/countries/info/PT.json" , $"http://www.geognos.com/api/en/countries/info/SO.json", $"http://www.geognos.com/api/en/countries/info/CN.json", $"http://www.geognos.com/api/en/countries/info/FK.json", $"http://www.geognos.com/api/en/countries/info/DE.json", $"http://www.geognos.com/api/en/countries/info/GR.json", $"http://www.geognos.com/api/en/countries/info/KP.json" , $"http://www.geognos.com/api/en/countries/info/KR.json", $"http://www.geognos.com/api/en/countries/info/LS.json", $"http://www.geognos.com/api/en/countries/info/IT.json", $"http://www.geognos.com/api/en/countries/info/AF.json",$"http://www.geognos.com/api/en/countries/info/PE.json"};
            int count = Urls.Count();
            int i  = p.Next(0,count-1);
            Console.WriteLine(i);
            string url = Urls[i]; 
            var request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";
            request.ContentType = "application/json";
            request.Accept = "application/json";
            try
            {
                using (WebResponse response = request.GetResponse())
                {
                    using (Stream strReader = response.GetResponseStream())
                    {
                        if (strReader == null) return;
                        using (StreamReader objReader = new StreamReader(strReader))
                        {
                            string responseBody = objReader.ReadToEnd();
                            var ListC = System.Text.Json.JsonSerializer.Deserialize<Root>(responseBody);
                            
                            Console.WriteLine("El combate se realizara en "+ ListC.Results.Name + ", "+ListC.Results.Capital.Name);

                        }
                    }
                }
            }
            catch (WebException ex)
            {
                Console.WriteLine("Problemas de acceso a la API");
            }


        }
        static public string Ataques(){
            Random p = new Random();
            string url = $"https://www.dnd5eapi.co/api/spells";    
            var request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";
            request.ContentType = "application/json";
            request.Accept = "application/json";
            try
            {
                using (WebResponse response = request.GetResponse())
                {
                    using (Stream strReader = response.GetResponseStream())
                    {
                        if (strReader == null);
                        using (StreamReader objReader = new StreamReader(strReader))
                        {
                            string responseBody = objReader.ReadToEnd();
                            var ListC = System.Text.Json.JsonSerializer.Deserialize<RaizAtaque>(responseBody);
                            List<string>ListaAta = new List<string>();
                            
                            foreach (ResultadoAtaque i in ListC.Results)
                            {
                                ListaAta.Add(i.Name);
                                
                                
                            }
                            string name  = ListaAta[p.Next(0,318)];  
                            return name;

                        }
                    }
                }
            }
            catch (WebException ex)
            {
                Console.WriteLine("Problemas de acceso a la API");
            }
            string l = "";
            return l;


        }

    }
}