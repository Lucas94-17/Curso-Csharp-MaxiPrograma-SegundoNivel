using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia_Ejemplo3
{
    internal class Perro : AnimalDomestico
    {
        public override string Comunicarse()
        {
            return "Guau ... Guau...";
        }
    }
}
