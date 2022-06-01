using System;
namespace Juego
{
    public class Personaje{
        private CA Carac;
        private Datos Datos;

        public Personaje(CA Carac, Datos Datos)
        {
            this.Carac = Carac;
            this.Datos = Datos;
            
        }
        public Personaje(){
            
        }

        public CA Carac1 { get => Carac; set => Carac = value; }
        public Datos Datos1 { get => Datos; set => Datos = value; }

        public void CrearPersonaje(){
            CA c = new CA();
            c.CrearCa();
            Datos d = new Datos();
            d.LlenarDatos();

            this.Carac = c;
            this.Datos = d;
        }
        public int PD(){
            int pd;
            pd = this.Carac.Destreza1 * this.Carac.Fuerza1 * this.Carac.Nivel1;
            return pd; 
        }
        public int ED(){
            Random p  = new Random();
            int alt = p.Next(1,101);
            return alt;
        }
        public int VDA(){
            int va;
            va = this.ED() * this.PD();
            return va;
        }
        public int PowerDefense(){
            int PD = this.Carac.Armadura1 * this.Carac.Velocidad1;
            return PD;
        }
        public int DañoProvocado(Personaje p2Def){
            int DP = (((this.VDA() * this.ED())-p2Def.PowerDefense())/50000) * 100;
            return DP;
        }
        public void ActuaizarVida(int DañoProvocado){
            this.Datos.Salud1 = this.Datos.Salud1 - DañoProvocado;
        }
        public void ActualizarStats(){
            this.Carac.Velocidad1 += 10;
            this.Carac.Destreza1 +=7;
            this.Carac.Fuerza1 += 5;
            this.Carac.Nivel1++;
            this.Carac.Armadura1 += 8;
        }
        public void MostrarDatos(){
            Console.WriteLine("Los datos son:");
            Console.WriteLine("Tipo {0}",this.Datos.Tipo1);
            Console.WriteLine("Nombre: {0}", this.Datos.Nombre1);
            Console.WriteLine("Apodo: {0}", this.Datos.Apodo1);
            Console.WriteLine("Salud: {0}", this.Datos.Salud1);
            Console.WriteLine("");
         

        }
        public void MostrarCarac(){
            Console.WriteLine("Sus Datos son:");
            Console.WriteLine("Velocidad: {0}", this.Carac.Velocidad1);
            Console.WriteLine("Destreza: {0}", this.Carac.Destreza1);
            Console.WriteLine("Fuerza: {0}", this.Carac.Fuerza1);
            Console.WriteLine("Nivel: {0}", this.Carac.Nivel1);
            Console.WriteLine("Armadura: {0}", this.Carac.Armadura1);
        }
        public bool GameOver(){
            if (this.Datos.Salud1<= 0)
            {
                return true;
            }
            return false;
        }
    }
    
}