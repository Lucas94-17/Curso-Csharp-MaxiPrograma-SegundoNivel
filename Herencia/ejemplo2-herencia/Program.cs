using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo2_herencia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vehiculo v1 = new Vehiculo();
            Camioneta c1 = new Camioneta();
            Camioneta c2 = new Camioneta();
            Camioneta c3 = new Camioneta();

            c1.Motor = "1.8 Diesel";
            c1.Color = "Blanca";
            c2.Color = "Roja";
            c3.Color = "Verde";

            Console.WriteLine("El motor de la camioneta es : "+c1.Motor);

            Console.ReadLine();

            List<Camioneta> listaCamionetas = new List<Camioneta>();
            listaCamionetas.Add(c1);
            listaCamionetas.Add(c2);
            listaCamionetas.Add(c3);

            //Console.WriteLine("La cantidad de camionetas es : " + listaCamionetas.Count);
            ////listaCamionetas[1].Motor = "Negro";
            //c2.Color = "Verde";

            //Console.WriteLine("El color de la camioneta 2 es : " + listaCamionetas[1].Color);

            //listaCamionetas.Remove(c3);

            //foreach (Camioneta item in listaCamionetas)
            //{
            //    Console.WriteLine("Color : " + item.Color);
            //}

            Auto a1 = new Auto();
            a1.Motor = new Motor();

            Console.ReadLine();
        }
    }
}
