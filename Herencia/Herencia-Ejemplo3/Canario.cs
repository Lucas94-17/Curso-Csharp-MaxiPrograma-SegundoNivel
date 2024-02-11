using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia_Ejemplo3
{
    internal class Canario : AnimalDomestico , Flyable
    {
        //public override string Comunicarse()
        //{
        //    return "Pio... Pio...";
        //}
        public string volar()
        {
            return "Vuela como un canario ";
        }
    }
}
