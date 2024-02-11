using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia_Ejemplo3
{
    internal class Animal
    {
        //METODO ( LO HACEMOS VIRTUAL PARA PODER SOBREESCRIBIRLO
        public virtual string Comunicarse()
        {
            return "Ruido ... Ruido...";
        }
    }
}
