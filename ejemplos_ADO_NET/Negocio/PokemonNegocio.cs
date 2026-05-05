using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Dominio;

namespace Negocio
{
    public class PokemonNegocio
    {
        public List<Pokemon> listar()
        {
            List<Pokemon> lista = new List<Pokemon>();

            //Desde acá arranca clase AccesoDatos...

            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;

            try
            {
                conexion.ConnectionString = "server=PCBOX\\SQLEXPRESS; database=POKEDEX_DB; integrated security=true";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "Select Numero, Nombre, P.Descripcion, UrlImagen, E.Descripcion as Tipo, D.Descripcion Debilidad from POKEMONS P, ELEMENTOS E, ELEMENTOS D where E.Id = P.IdTipo and D.Id = P.IdDebilidad";
                comando.Connection = conexion;

                conexion.Open();
                lector = comando.ExecuteReader();
        
                //Hasta acá llega clase AccesoDatos

                while (lector.Read())
                {
                    Pokemon aux = new Pokemon();
                    aux.Numero = lector.GetInt32(0); //Version en la que hay que indicar el tipo de int y el indice en el que está señalado arriba
                    aux.Nombre = (string)lector["Nombre"]; //Version con casteo string y nombre de la columna a la que apunta(esta o la anterior pueden usarse
                    aux.Descripcion = (string)lector["Descripcion"];
                    aux.UrlImagen = (string)lector["UrlImagen"];
                    aux.Tipo = new Elemento(); //Se genera una instancia del objeto de clase Elemento. Tipo no tiene una instancia anteriormente.
                    aux.Tipo.Descripcion = (string)lector["Tipo"];
                    aux.Debilidad = new Elemento();
                    aux.Debilidad.Descripcion = (string)lector["Debilidad"];

                    lista.Add(aux);
                }

                conexion.Close();

                //Hasta acá llega clase AccesoDatos... sin el while.

                return lista;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void agregar(Pokemon nuevo)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("insert into POKEMONS (Numero, Nombre, Descripcion, Activo) values(" + nuevo.Numero + ", '" + nuevo.Nombre + "', '" + nuevo.Descripcion +"', 1)");
                datos.ejecutarAccion();
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

        public void modificar(Pokemon modifica)
        {

        }

        public void quitarLogico(Pokemon quitaLogico)
        {

        }

        public void quitarFisico(Pokemon quitaFisico)
        {

        }
    }
}
