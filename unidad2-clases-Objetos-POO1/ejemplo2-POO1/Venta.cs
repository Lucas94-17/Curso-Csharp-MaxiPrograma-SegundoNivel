using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo2_POO1
{
    internal class Venta
    {
        //Segundo lote con las ventas de la semana . Cada venta tiene:
        //  -Codigo Artículo
        //  -Cantidad
        //  -Código Cliente
        public int CodigoArticulo { get; set; }
        public int cantidad { get; set; }
        public int CodigoCliente { get; set; }
    }
}
