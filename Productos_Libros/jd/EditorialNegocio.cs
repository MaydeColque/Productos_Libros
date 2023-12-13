using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using modelo;

namespace negocio
{
	public class EditorialNegocio
	{
		public List<Editorial> listaEditorial()
		{
			AccesoDatos datos = new AccesoDatos();
			List<Editorial> lista = new List<Editorial>();
			try
			{
				datos.setConsulta("select id_editorial, nombre from Editorial");
				datos.ejecutarLector();

				while (datos.Lector.Read())
				{
					Editorial editorial = new Editorial();
					editorial.Id_editorial = (int)datos.Lector["id_editorial"];
					editorial.Nombre = (string)datos.Lector["nombre"];

					lista.Add(editorial);
				}

				return lista;

			}
			catch (Exception)
			{

				throw;
			}
			finally { datos.cerrarConexion(); }
		}
		public void agregar(string nuevaEditorial)
		{
			AccesoDatos datos = new AccesoDatos();
			try
			{
				datos.setConsulta("INSERT INTO Editorial VALUES(@nombre)");
				datos.setParametro("@nombre", nuevaEditorial);
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
