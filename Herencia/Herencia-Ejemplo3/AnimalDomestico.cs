using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia_Ejemplo3
{
    internal class AnimalDomestico : Animal
    {
        public string Nombre { get; set; }

        //SOBREESCRITURA DE METODO

        public override string ToString()
        {
            return "Animal : " + Nombre;
        }
    }
    
}
