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

        public void LlenarDatos(){
            Random p  = new Random();
           string[] tipos = new string[]{"Elfo","Ogro","Humano","Hechizero","Gigante"};
           string[] nombre = new string[]{"Buster", "Jack", "Kaisa","Phantom", "Artemis", "Dasai", "Kansai"};
           string[] apodos = new string[]{"Facas27","Arequima","Logi","Dias","Zwei","Yorch","BusterBlader"};
           this.Tipo = tipos[p.Next(0,5)];
           this.Nombre = nombre[p.Next(0,7)];
           this.Apodo = apodos[p.Next(0,7)];
           this.Edad =p.Next(0,301);
           this.Salud = 3000;
           int dia = p.Next(1,32);
           int mes = p.Next(1,13);
           int year = p.Next(1962,2068);
           DateTime f = new DateTime(year,mes,dia);
           this.FechaNac = f;
          
        }
    }
}