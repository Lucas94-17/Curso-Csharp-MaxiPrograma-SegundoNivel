using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio
{
    internal class Telefono
    {
        //ATRIBUTOS
        private string modelo;
        private string marca;
        private string numeroTelefonico;
        private int codigoOperador;
        
        //PROPIEDADES
        public string Modelo
        {
            get { return modelo; }
        }
        public string Marca
        {
            get { return marca; }
        }
        public string NumeroTelefonico
        {
            get { return numeroTelefonico;}
            set { numeroTelefonico = value; }
        }
        public int CodigoOperador
        {
            get { return codigoOperador; }
            set
            {
                if ((value >= 1) && (value <= 3))
                {
                    codigoOperador = value;
                }
                else
                {
                    codigoOperador = 0;
                }
            }
        }

        //CONSTRUCTOR

        public Telefono(string modelo, string marca)
        {
            this.modelo = modelo;
            this.marca = marca;
        }


        //METODOS
        public string Llamada()
        {
            return "Realizando llamada";
        }

        public string Llamada(string contacto)
        {
            return "Llamando a " + contacto;
        }
    }
}
