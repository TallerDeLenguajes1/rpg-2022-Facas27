using System;
namespace Juego{

    public class CA
    {
        private int Velocidad;


        private int Destreza;
        private int Fuerza;
        private int Nivel;
        private int Armadura;

        public int Velocidad1 { get => Velocidad; set => Velocidad = value; }
        public int Destreza1 { get => Destreza; set => Destreza = value; }
        public int Fuerza1 { get => Fuerza; set => Fuerza = value; }
        public int Nivel1 { get => Nivel; set => Nivel = value; }
        public int Armadura1 { get => Armadura; set => Armadura = value; }

        public CA()
        {
        }

        public CA(int velocidad, int destreza, int fuerza, int nivel, int armadura)
        {
            
           this.Velocidad =  velocidad ;
           this.Destreza = destreza ;
           this.Fuerza  = fuerza;
           this.Nivel = nivel;
           this.Armadura  = armadura;
            
        }
        public void CrearCa(){
            Random numRandom = new Random();
            this.Velocidad = numRandom.Next(1,11);
            this.Fuerza = numRandom.Next(1,11);
            this.Destreza = numRandom.Next(1,6);
            this.Armadura = numRandom.Next(1,11);
            this.Nivel = numRandom.Next(1,11);



            
        }
    }
}