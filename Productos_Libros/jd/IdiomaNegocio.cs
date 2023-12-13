using modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace negocio
{
    public class IdiomaNegocio
    {
        public List<Idioma> listaIdioma() {

			AccesoDatos datos= new AccesoDatos();
			List<Idioma> lista = new List<Idioma>();

			try
			{
				datos.setConsulta("select id_idioma, nombre from Idioma");
				datos.ejecutarLector();

				while (datos.Lector.Read())
				{
					Idioma idioma = new Idioma();
					idioma.Id_idioma = (int)datos.Lector["id_idioma"];
					idioma.idioma = (string)datos.Lector["nombre"];

					lista.Add(idioma);
				}

				return lista;

			}
			catch (Exception)
			{

				throw;
			}
            finally { datos.cerrarConexion(); }
        }

		public void agregar(string nuevoIdioma)
		{
			AccesoDatos datos = new AccesoDatos();

			try
			{
				datos.setConsulta("INSERT INTO Idioma VALUES(@idioma)");
				datos.setParametro("@idioma", nuevoIdioma);
				datos.ejecutarInstruccion();
			}
			catch (Exception)
			{

				throw;
			}
			finally { datos.cerrarConexion();}
		}
    }
}
