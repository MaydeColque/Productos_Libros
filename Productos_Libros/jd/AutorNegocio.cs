using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using modelo;

namespace negocio
{
    public class AutorNegocio
    {
        public List<Autor> listaAutores()
        {
            List<Autor> lista = new List<Autor>();
            AccesoDatos datos = new AccesoDatos();

			try
			{
                datos.setConsulta("select id_autor, nombre from Autor");
                datos.ejecutarLector();

                while (datos.Lector.Read())
                {
                    Autor autor = new Autor();
                    autor.Id_autor = (int)datos.Lector["id_autor"];
                    autor.Nombre = (string)datos.Lector["nombre"];

                    lista.Add(autor);
                }

                return lista;
            }
			catch (Exception)
			{

				throw;
			}
            finally { datos.cerrarConexion(); }
        }
        public void agregarAutor(string nuevoAutor)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setConsulta("Insert into Autor values (@nombre)");
                datos.setParametro("@nombre", nuevoAutor);

                datos.ejecutarInstruccion();

            }
            catch (Exception)
            {

                throw;
            }
            finally { datos.cerrarConexion(); }

        }
    }
}
