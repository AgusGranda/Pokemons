using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Pokemons
{
    internal class PokemonNegocio
    {



        public List<Pokemon> listar()
        {
            List<Pokemon> lista = new List<Pokemon>();

            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;



            try
            {
                conexion.ConnectionString = "server=.\\SQLEXPRESS ; database=POKEDEX_DB ; integrated security=true";

                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "select Numero, Nombre, Descripcion,UrlImagen from POKEMONS";
                comando.Connection = conexion;

                conexion.Open();

                lector = comando.ExecuteReader();


                while (lector.Read())
                {
                    Pokemon aux = new Pokemon();
                    aux.Numero = (int)lector["Numero"];
                    aux.Nombre = (string)lector["Nombre"];
                    aux.Descripcion = (string)lector["Descripcion"];
                    aux.UrlImagen = (string)lector["UrlImagen"];


                    lista.Add(aux);
                }



                return lista;
            }
            catch(Exception ex) 
            {
                throw;
            }
            finally
            {
                conexion.Close();
            }


        }


    }
}
