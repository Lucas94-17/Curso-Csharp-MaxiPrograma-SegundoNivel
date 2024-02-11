using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo1
{
    internal class Perro
    {
        //Perro : Nombre ,color , origen
        private int Nombre;
        private string color;
        private string origen;

        //Propiedad 

        public string Color
        {
            get { return color; }
            set { color = value; }
        }
    }
}
