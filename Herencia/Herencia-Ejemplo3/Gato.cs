using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia_Ejemplo3
{
    internal class Gato : AnimalDomestico
    {
        //SOBREESCRIBIR EL METODO COMUNICARSE ( TIENE QUE SER VIRTUAL ) 

        public override string Comunicarse()
        {
            return "MIAU"; 
        }
    }
}
