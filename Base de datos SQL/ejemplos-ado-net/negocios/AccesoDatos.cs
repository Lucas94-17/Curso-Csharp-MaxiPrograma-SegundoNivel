using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace negocios
{
    public class AccesoDatos
    {
        public SqlConnection conexion;
        public SqlCommand comando;
        public SqlDataReader lector;

        public AccesoDatos()
        {
            conexion = new SqlConnection("server=.\\SQLEXPRESS; database=POKEDEX_DB; integrated security= true;");
            comando = new SqlCommand();
        }
        //ACA SE ENCAPSULA EL CONTROL DE LA CONSULTA
        public void setearConsulta(string consulta)
        {
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = consulta;
        }

        public void ejecutarLectura()
        {
            comando.Connection = conexion;
            try
            {
                conexion.Open();
                lector = comando.ExecuteReader();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void ejecturaAccion()
        {
            comando.Connection = conexion;
            try
            {
                conexion.Open();
                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void setearParametros(string nombre , object valor)
        {
            comando.Parameters.AddWithValue(nombre,valor);
        }

        public void cerrarConexion()
        {
            if (lector != null)
            {
                lector.Close();
                
            }
            conexion.Close();
        }
    }
}
