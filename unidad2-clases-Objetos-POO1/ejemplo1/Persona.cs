using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo1
{
    internal class Persona
    {
        //Persona :  Edad , Sueldo, Nombre
        //Atributos o miembros
        private int edad;
        private float sueldo;
        private string nombre;
        //En este caso no le pongo get ni set , ya que no le cambiaré el nombre a la persona
        //Constructor
        public Persona(string nombre)
        {
            this.nombre = nombre;
        }

        public void setEdad(int e)
        {
            edad = e;
        }

        public int getEdad()
        {
            return edad;
        }
        // Metodo - string - saludar
        public string Saludar()
        {
            return "Hola soy " + nombre; 
        }

        //Sobre cargar un método
        public string Saludar(string personaje)
        {
            return "Hola " +  personaje + ", soy ..." + this.nombre;
        }
    }
}
