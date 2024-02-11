using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio
{
    internal class Gato
    {
        //ATRIBUTOS
        private int patas;
        private string color;
        private int numeroManchas;
        private string nombre;
        private string raza;

        //PROPIEDADES
        public int Patas
        {
            get { return patas; }
        }
        public string Color 
        { 
            get { return color; } 
            set { color =  value ; }
        }
        public int NumeroManchas {
            get { return numeroManchas; }
            set { numeroManchas = value; } 
        }
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public string Raza
        {
            get { return raza; }
            set { raza = value; }
        }

        //CONSTRUCTOR
        public Gato()
        {
            
            patas = 4;
        }


        //METODOS


    }
}
