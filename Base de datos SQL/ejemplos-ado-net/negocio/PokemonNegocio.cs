using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using dominio;

namespace ejemplos_ado_net
{
    internal class PokemonNegocio
    {
        public List<Pokemon> Listar()//Declaramos una lista
        {
            //Creamos la lista
            List<Pokemon> lista = new List<Pokemon>();
            //Este codigo es para crear la instacia de base de datos
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;

            try
            {
                //Cadena de conexion
                conexion.ConnectionString = "server=.\\SQLEXPRESS; database=POKEDEX_DB; integrated security= true;";
                //Comando , sirve para realizar la accion
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "Select Numero, Nombre , P.Descripcion,UrlImagen , E.Descripcion as Tipo , D.Descripcion as Debilidad from POKEMONS P, ELEMENTOS E , ELEMENTOS D Where E.Id = P.IdTipo AND D.Id = P.IdDebilidad";
                comando.Connection = conexion;

                //Abro la conexion
                conexion.Open();
                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    Pokemon aux = new Pokemon();
                    aux.Numero = lector.GetInt32(0);
                    aux.Nombre = (string)lector["Nombre"];
                    aux.Descripcion = (string)lector["Descripcion"];
                    aux.UrlImagen = (string)lector["UrlImagen"];
                    // ACA TIPO NO TIENE UNA INSTANCIA , ENTONCES HAGO LO SIGUIENTE PARA NO TENER UNA REFERENCIA NULA
                    aux.Tipo = new Elemento();
                    aux.Tipo.Descripcion = (string)lector["Tipo"];
                    aux.Debilidad = new Elemento();
                    aux.Debilidad.Descripcion = (string)lector["Debilidad"];

                    lista.Add(aux);
                }

                conexion.Close();

                return lista;

            }
            catch (Exception ex)
            {

                throw ex;
            }


        }
    }
}
