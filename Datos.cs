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
           string[] tipos = new string[]{"Elfo","Ogro","Humano","Hechizero","Gigante"};
           string[] nombre = new string[]{"Buster", "Jack", "Kaisa","Phantom", "Artemis", "Dasai", "Kansai"};
           string[] apodos = new string[]{"Facas27","Arequima","Logi","Dias","Zwei","Yorch","BusterBlader","Yuichi","FacetoFace","ToEasy", "Ishigami" , "Aracbela" , "Disaster" , "DeathMachine", "Kiyotaka" , "S1mple", "Gintoki" , "Kun Lao" , "Kumoko","Akane", "Dishi" , "Kazuma" , "Aqua", "27"};
           this.Tipo = tipos[p.Next(0,5)];
           this.Nombre = nombre[p.Next(0,7)];
           this.Apodo = apodos[p.Next(0,23)];
           this.Edad =p.Next(0,301);
           this.Salud = 3000;
           DateTime f = new DateTime(p.Next(1968,2056),p.Next(1,12),p.Next(1,30));
           this.FechaNac = f;
          
        }
    }
}