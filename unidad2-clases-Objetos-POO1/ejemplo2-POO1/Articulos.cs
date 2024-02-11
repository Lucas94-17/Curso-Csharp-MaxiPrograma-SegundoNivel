using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo2_POO1
{
    internal class Articulos
    {
        //Primer lote con 10 registros de productos , cada producto tiene:
        //  -Codigo Artículo (3 dígitos no correlativos)
        //  -Precio
        //  -Código de Marca (1 a 10)
        //private int codigoArticulo;
        //Esta es la manera corta de definir una propiedad
        public int CodigoArticulo { get; set; }
        //private float precio;
        public float Precio { get; set; }
        // En este caso se usa la forma larga para modificar el set y el get
        private int CodigoMarca;
        public int CodMarca
        {
            get { return CodigoMarca; }
            set
            {
                if (value > 0 && value < 11)
                {
                    CodigoMarca = value;
                }
                else
                {
                    CodigoMarca = -1;
                }
            }
        }
    }
}
