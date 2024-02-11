using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo1
{
    internal class Botella
    {

        //Capacidad máxima : 100
        //cantidadActual : inicia en cero.
        //Método recarga : carga al 100 y devuelve el costo de recargar . 50 cada 100.

        //Constructor
        public Botella(string color , string material){
            this.color = color;
            this.material = material;
            capacidad = 100;
            cantidadActual = 0;
        }

        //Sobrecargar el contructor
        public Botella() { }

        //Destructor
        ~Botella() { 
            //La logica va acá
        }

        //Botella : Capacidad , Color , Material (PROPERTY)
        private int capacidad;
        private string color;
        private string material;
        private int cantidadActual;

        public string Material
        {
            get { return material;}
        }
        public int Capacidad
        {
            get { return capacidad;}
        }
        public int CantidadActual
        {
            get { return cantidadActual;}
        }
        //Propiedad
        //public int Capacidad
        //{
        //    get { return capacidad; }
        //    set { capacidad = value; }
        //}

        //Métodos
        public float recargar()
        {
            //cantidadActual = 100;
            //return 50;
            if (cantidadActual > 0)
            {
                int dif = capacidad - cantidadActual;
                float monto = dif * 50 / 100;
                cantidadActual += dif;
                return monto;
            }
            cantidadActual = 100;
            return 50;
        }

        public float recargar(int cantidad)
        {
            cantidadActual += cantidad;
            float monto = cantidad * 50 / 100;
            return monto;
        }
    }
}
