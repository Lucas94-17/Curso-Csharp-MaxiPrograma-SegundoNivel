using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo2_POO1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Primer lote con 10 registros de productos , cada producto tiene:
            //  -Codigo Artículo (3 dígitos no correlativos)
            //  -Precio
            //  -Código de Marca (1 a 10)
            //Segundo lote con las ventas de la semana . Cada venta tiene:
            //  -Codigo Artículo
            //  -Cantidad
            //  -Código Cliente
            //Este lote corta con código de cliente cero.

            //Articulos a1 = new Articulos();
            Articulos[] a1 = new Articulos[10];

            for (int i = 0; i < 2; i++)
            {
                //Se usa esto porque el vector está vacío
                //¿Por qué? Porque el vector está vacío.Es decir,
                //yo reservo espacio de memoria para guardar 10 artículos,
                //pero en cada espacio de memoria no hay nada,
                //entonces antes de poder guardar un dato a un artículo i,
                //tengo que crear ese artículo invocando al constructor con NEW.
                //Esto se debe a que los objetos son tipos referenciales,
                //pero esto lo charlaremos en la siguiente unidad.
                a1[i] = new Articulos();
                
                Console.WriteLine("Ingrese los datos del producto : ");
                Console.WriteLine("Código : ");
                a1[i].CodigoArticulo = int.Parse(Console.ReadLine());
                Console.WriteLine("Precio : ");
                a1[i].Precio = float.Parse(Console.ReadLine());
                Console.WriteLine("Código de marca : ");
                a1[i].CodMarca = int.Parse(Console.ReadLine());
            }


            // Tengo el vector cargado
            Venta venta = new Venta();
            Console.WriteLine("Ingrese la venta ");
            Console.WriteLine("Codigo del cliente : ");
            venta.CodigoCliente = int.Parse(Console.ReadLine());

            while (venta.CodigoCliente != 0)
            {
                Console.WriteLine("Codigo art. ");
                venta.CodigoArticulo = int.Parse(Console.ReadLine());
                Console.WriteLine("Cantidad : ");
                venta.cantidad = int.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese la venta ");
                Console.WriteLine("Codigo del cliente : ");
                venta.CodigoCliente = int.Parse(Console.ReadLine());
            }
        }
    }
}
