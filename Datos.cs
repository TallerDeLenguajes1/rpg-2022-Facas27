using System.Net;
namespace Juego
{
    public class Datos
    {
        private string Tipo;
        private string Nombre;
        private string Apodo;
        private DateTime FechaNac;

        private int Edad;
        private int Salud;
        private int Partidasg = 0;

        public Datos()
        {
        }

        public Datos(string tipo, string nombre, string apodo, DateTime fechaNac, int edad, int salud)
        {
            this.Tipo = tipo;
            this.Nombre = nombre ;
            this.Apodo = apodo;
            this.FechaNac = fechaNac;
            this.Edad = edad;
            this.Salud = salud;
            
            
        }

        public string Tipo1 { get => Tipo; set => Tipo = value; }
        public string Nombre1 { get => Nombre; set => Nombre = value; }
        public string Apodo1 { get => Apodo; set => Apodo = value; }
        public DateTime FechaNac1 { get => FechaNac; set => FechaNac = value; }
        public int Edad1 { get => Edad; set => Edad = value; }
        public int Salud1 { get => Salud; set => Salud = value; }
        public int Partidasg1 { get => Partidasg; set => Partidasg = value; }

        public void LlenarDatos(){
            Random p  = new Random();
           string[] nombre = new string[]{"Buster", "Jack", "Kaisa","Phantom", "Artemis", "Dasai", "Kansai"};
           string[] apodos = new string[]{"Facas27","Arequima","Logi","Dias","Zwei","Yorch","BusterBlader","Yuichi","FacetoFace","ToEasy", "Ishigami" , "Aracbela" , "Disaster" , "DeathMachine", "Kiyotaka" , "S1mple", "Gintoki" , "Kun Lao" , "Kumoko","Akane", "Dishi" , "Kazuma" , "Aqua", "27"};
           this.Tipo = Razas();
           this.Nombre = nombre[p.Next(0,7)];
           this.Apodo = apodos[p.Next(0,23)];
           this.Edad =p.Next(0,301);
           this.Salud = 3000;
           DateTime f = new DateTime(p.Next(1968,2056),p.Next(1,12),p.Next(1,30));
           this.FechaNac = f;
          
        }
        static public string Razas(){
            Random p = new Random();
            string url = $"https://www.dnd5eapi.co/api/races";    
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
                            var ListC = System.Text.Json.JsonSerializer.Deserialize<RaizRazas>(responseBody);
                            List<string>ListaRazas = new List<string>();
                            
                            foreach (ResultadosRaza i in ListC.Results)
                            {
                                ListaRazas.Add(i.Name);
                                
                                
                            }
                            string name  = ListaRazas[p.Next(0,8)];  
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