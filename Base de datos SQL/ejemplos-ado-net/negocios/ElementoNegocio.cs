﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dominio;

namespace negocios
{
    public class ElementoNegocio
    {
        public List<Elemento> listar()
        {
            List<Elemento> lista = new List<Elemento>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("Select Id , Descripcion from ELEMENTOS");
                datos.ejecutarLectura();

                while (datos.lector.Read())
                {
                    Elemento aux = new Elemento();
                    aux.Id = (int)datos.lector["Id"];
                    aux.Descripcion = (string)datos.lector["Descripcion"];

                    lista.Add(aux);
                }
                return lista;
            }
            catch (Exception error)
            {

                throw error;
            }
        }
    }
}
