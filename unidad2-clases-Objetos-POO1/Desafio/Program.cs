using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //OBJETO : TELEFONO
            //Telefono telefono = new Telefono("G9 play", "Motorola");
            //Console.WriteLine("Las propiedades son : " + telefono.Marca);

            //telefono.NumeroTelefonico = "10";
            //Console.WriteLine(telefono.NumeroTelefonico);

            //telefono.CodigoOperador = int.Parse(Console.ReadLine());

            //Console.WriteLine(telefono.CodigoOperador);

            //Console.WriteLine(telefono.Llamada());

            //string contacto = Console.ReadLine();
            //Console.WriteLine(telefono.Llamada(contacto));

            //Console.ReadLine();

            //OBJETO : Gato
            string color1 = Console.ReadLine();

            Gato cat1 = new Gato();

            cat1.Color = color1;
            Console.WriteLine(cat1.Patas + cat1.Color  + " \n ");



            // gato 2
            Gato cat2 = new Gato();


            Console.WriteLine(cat2.Patas + cat2.Color);

            Console.ReadLine();




        }
    }
}
