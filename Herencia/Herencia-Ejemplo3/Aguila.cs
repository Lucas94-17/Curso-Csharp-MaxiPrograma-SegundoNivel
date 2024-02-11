using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia_Ejemplo3
{
    internal class Aguila : AnimalSalvaje
    {
        public override string Comunicarse()
        {
            return "SONIDO DE AGUILA ... SONIDO DE AGUILA ...";
        }
        public string volar()
        {
            return "Vuela como un ágila ";
        }
    }
}
