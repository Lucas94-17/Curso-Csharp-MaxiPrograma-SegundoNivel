using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo2_herencia
{
    internal class Auto : Vehiculo
    {
        public Auto() 
        { 
            Chasis = new Chasis();
        }
        public int Anio { get; set; }
        public string Modelo { get; set; }
        //public string Color { get; set; }


        //Una composicion es lo que TIENE el objeto , en cambio una herencia es lo que ES el objeto
        //COMPOSICION
        public Chasis Chasis { get; }

        //AGREGACION
        public Motor Motor {  get; set; }

    }
}
