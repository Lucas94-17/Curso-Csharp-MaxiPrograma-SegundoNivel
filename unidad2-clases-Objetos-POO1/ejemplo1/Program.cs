using System;

//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace ejemplo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int edad1;
            ////float sueldo;
            ////string nombre;
            ////int[] edades = new int[10];
            ////float[] sueldos = new float[10];
            ////string[] nombres = new string[10];

            //edad1 = int.Parse(Console.ReadLine());

            //string nombre = Console.ReadLine();
            //Persona Lucas = new Persona(nombre);
            //Persona persona = new Lucas(nombre);

            //Lucas.setEdad(edad1);

            //Console.WriteLine(Lucas.Saludar());
            //Console.WriteLine(Lucas.Saludar("Maxi"));

            //Console.WriteLine("La edad de la persona es :" + Lucas.getEdad());

            //int capacidad = int.Parse(Console.ReadLine());

            Botella botella1 = new Botella("Rojo", "plastico");

            //botella1.Capacidad = capacidad;

            Console.WriteLine("La capacidad de la botella es : " + botella1.Capacidad);
            Console.WriteLine("La cantidad actual es  :" + botella1.CantidadActual);

            botella1.recargar(50);
            botella1.recargar(20);
            //Console.WriteLine(botella1.CantidadActual);
            Console.WriteLine("Luego de recargar , la cantidad actual es : " + botella1.CantidadActual);

            botella1.recargar();
            Console.WriteLine("Luego de recargar , la cantidad actual es : " + botella1.CantidadActual);

            Console.WriteLine("El monto total es : " + botella1.)
            //Perro perro = new Perro();

            //string color = (Console.ReadLine());

            //perro.Color = color;
            //Console.WriteLine("El color del perro es :" + perro.Color);


            Console.Read();

            //4:27

        }
    }
}
