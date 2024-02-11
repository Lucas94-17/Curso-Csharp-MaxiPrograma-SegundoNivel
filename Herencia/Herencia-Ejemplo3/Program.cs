using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia_Ejemplo3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Gato g1 = new Gato();
            g1.Nombre = "PEPE";

            Pez p1 = new Pez();
            p1.Nombre = "Nemo";

            //CREA UNA NUEVA LISTA DE ANIMALES :
            //List<Animal> animales = new List<Animal>();
            //AGREGO ANIMALES A LA LISTA
            //animales.Add(g1);
            //animales.Add(new Aguila());
            //animales.Add(new Perro());
            //animales.Add(new Canario());
            //animales.Add(p1 );

            //Animal a1 = g1;

            //Gato g8 = (Gato)a1;

            //g8.Nombre = "Colita";

            //Console.WriteLine(g8.Nombre);

            //Console.WriteLine(g1.Comunicarse());
            //foreach (Animal item in animales)
            //{
            //    Console.WriteLine(item.Comunicarse());
            //}

            //ACA ESTOY HACIENDO UNA LISTA DE ANIMALES VOLARES , MEDIANTE LA INTERFAZ FLYABLE

            List<Flyable> listaVoladores = new List<Flyable>();



            Console.ReadKey();
        }
    }
}
