using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using dominio;
using negocios;

namespace ejemplos_ado_net
{
    public class PokemonNegocio
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
                comando.CommandText = "Select Numero, Nombre , P.Descripcion,UrlImagen , E.Descripcion as Tipo , D.Descripcion as Debilidad , P.IdTipo, P.IdDebilidad,P.Id from POKEMONS P, ELEMENTOS E , ELEMENTOS D Where E.Id = P.IdTipo AND D.Id = P.IdDebilidad AND P.Activo = 1";
                comando.Connection = conexion;

                //Abro la conexion
                conexion.Open();
                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    Pokemon aux = new Pokemon();
                    aux.Id = (int)lector["Id"];
                    aux.Numero = lector.GetInt32(0);
                    aux.Nombre = (string)lector["Nombre"];
                    aux.Descripcion = (string)lector["Descripcion"];

                    //if (!(lector.IsDBNull(lector.GetOrdinal("UrlImagen")))) ;
                    //    aux.UrlImagen = (string)lector["UrlImagen"];

                    if (!(lector["UrlImagen"] is DBNull))
                        aux.UrlImagen = (string)lector["UrlImagen"];



                    // ACA TIPO NO TIENE UNA INSTANCIA , ENTONCES HAGO LO SIGUIENTE PARA NO TENER UNA REFERENCIA NULA
                    aux.Tipo = new Elemento();
                    aux.Tipo.Id = (int)lector["IdTipo"];
                    aux.Tipo.Descripcion = (string)lector["Tipo"];
                    aux.Debilidad = new Elemento();
                    aux.Debilidad.Id = (int)lector["IdDebilidad"];
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

        public void agregar(Pokemon pokemon_nuevo)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("  Insert into POKEMONS (Numero , Nombre , Descripcion ,Activo ,IdTipo,IdDebilidad , UrlImagen) values (" + pokemon_nuevo.Numero + ",'" + pokemon_nuevo.Nombre + "','" + pokemon_nuevo.Descripcion + "',1,@IdTipo,@IdDebilidad,@UrlImagen)");
                datos.setearParametros("@IdTipo", pokemon_nuevo.Tipo.Id);
                datos.setearParametros("@IdDebilidad", pokemon_nuevo.Debilidad.Id);
                datos.setearParametros("@UrlImagen", pokemon_nuevo.UrlImagen);
                datos.ejecturaAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }

        public void modificar(Pokemon pokemon_modificar) {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("update POKEMONS set Numero = @numero, Nombre = @nombre, Descripcion = @desc, UrlImagen = @img, IdTipo = @idTipo, IdDebilidad = @idDebilidad Where Id = @id");
                datos.setearParametros("@numero", pokemon_modificar.Numero);
                datos.setearParametros("@nombre", pokemon_modificar.Nombre);
                datos.setearParametros("@desc", pokemon_modificar.Descripcion);
                datos.setearParametros("@img", pokemon_modificar.UrlImagen);
                datos.setearParametros("@idTipo", pokemon_modificar.Tipo.Id);
                datos.setearParametros("@idDebilidad", pokemon_modificar.Debilidad.Id);
                datos.setearParametros("@id", pokemon_modificar.Id);

                datos.ejecturaAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }

        public void eliminar(int Id)
        {
            try
            {
                AccesoDatos datos = new AccesoDatos();
                datos.setearConsulta("Delete from POKEMONS Where Id = @Id");
                datos.setearParametros("@Id", Id);
                datos.ejecturaAccion();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void eliminarLogico(int id)
        {
            try
            {
                AccesoDatos datos = new AccesoDatos();
                datos.setearConsulta("update POKEMONS set Activo = 0 Where Id = @Id");
                datos.setearParametros("@Id", id);
                datos.ejecturaAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Pokemon> filtrar(string campo, string criterio, string filtro)
        {
            List<Pokemon> lista = new List<Pokemon>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                string consulta = "Select Numero, Nombre, P.Descripcion, UrlImagen, E.Descripcion Tipo, D.Descripcion Debilidad, P.IdTipo, P.IdDebilidad, P.Id From POKEMONS P, ELEMENTOS E, ELEMENTOS D Where E.Id = P.IdTipo And D.Id = P.IdDebilidad And P.Activo = 1 AND    ";
                if (campo == "Número")
                {
                    switch (criterio)
                    {

                        case "Mayor a":
                            consulta += "Numero > " + filtro;
                            break;
                        case "Menor a":
                            consulta += "Numero < " + filtro;
                            break;
                        default:
                            consulta += "Numero = " + filtro;
                            break;
                    }
                }
                else if (campo == "Nombre")
                {
                    switch (criterio)
                    {
                        case "Comienza con":
                            consulta += "Nombre like '" + filtro + "%' ";
                            break;
                        case "Termina con":
                            consulta += "Nombre like '%" + filtro + "'";
                            break;
                        default:
                            consulta += "Nombre like '%" + filtro + "%'";
                            break;
                    }
                }
                else
                {
                    switch (criterio)
                    {
                        case "Comienza con":
                            consulta += "P.Descripcion like '" + filtro + "%' ";
                            break;
                        case "Termina con":
                            consulta += "P.Descripcion like '%" + filtro + "'";
                            break;
                        default:
                            consulta += "P.Descripcion like '%" + filtro + "%'";
                            break;
                    }
                }

                datos.setearConsulta(consulta);
                datos.ejecutarLectura();
                while (datos.lector.Read())
                {
                    Pokemon aux = new Pokemon();
                    aux.Id = (int)datos.lector["Id"];
                    aux.Numero = datos.lector.GetInt32(0);
                    aux.Nombre = (string)datos.lector["Nombre"];
                    aux.Descripcion = (string)datos.lector["Descripcion"];
                    if (!(datos.lector["UrlImagen"] is DBNull))
                        aux.UrlImagen = (string)datos.lector["UrlImagen"];

                    aux.Tipo = new Elemento();
                    aux.Tipo.Id = (int)datos.lector["IdTipo"];
                    aux.Tipo.Descripcion = (string)datos.lector["Tipo"];
                    aux.Debilidad = new Elemento();
                    aux.Debilidad.Id = (int)datos.lector["IdDebilidad"];
                    aux.Debilidad.Descripcion = (string)datos.lector["Debilidad"];

                    lista.Add(aux);
                }

                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
