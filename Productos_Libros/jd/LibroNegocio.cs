using modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace negocio
{
    public class LibroNegocio
    {
        public List<Libro> ListarLibros ()
        {
            List<Libro> listaLibros = new List<Libro>();
            AccesoDatos datos = new AccesoDatos ();

            try
            {
                datos.setConsulta("select id_libro id, isbn, titulo, A.nombre autor, L.id_autor id_autor, anio_edicion,E.nombre editorial, L.id_editorial id_editorial, nro_edicion, precio_venta, precio_compra, I.nombre idioma, L.id_idioma id_idioma, cant_paginas, cant_impresiones from Libro L, Autor A, Editorial E, Idioma I where L.id_autor = A.id_autor AND L.id_editorial = E.id_editorial AND L.id_idioma = I.id_idioma");
                datos.ejecutarLector();

                while (datos.Lector.Read())
                {
                    Libro libro= new Libro ();
                    libro.Id = (int)datos.Lector["id"];
                    libro.ISBN = (string)datos.Lector["isbn"];
                    libro.Titulo = (string)datos.Lector["titulo"];
                    libro.Autor = new Autor();
                    libro.Autor.Nombre = (string)datos.Lector["autor"];
                    libro.Autor.Id_autor = (int)datos.Lector["id_autor"];
                    libro.Anio_edicion = (int)datos.Lector["anio_edicion"];
                    libro.Editorial = new Editorial();
                    libro.Editorial.Nombre = (string)datos.Lector["editorial"];
                    libro.Editorial.Id_editorial = (int)datos.Lector["id_editorial"];
                    libro.Nro_edicion = (int)datos.Lector["nro_edicion"];
                    libro.Precio_venta = (decimal)datos.Lector["precio_venta"];
                    libro.Precio_compra = (decimal)datos.Lector["precio_compra"];
                    libro.Idioma = new Idioma();
                    libro.Idioma.idioma = (string)datos.Lector["idioma"];
                    libro.Idioma.Id_idioma = (int)datos.Lector["id_idioma"];
                    if(datos.Lector["cant_paginas"] != DBNull.Value)
                    {
                        libro.Cant_paginas = (int)datos.Lector["cant_paginas"];
                    }
                    else
                    {
                        libro.Cant_paginas = 0;
                    }
                    if (datos.Lector["cant_impresiones"] != DBNull.Value)
                    {
                        libro.Cant_impresiones = (int)datos.Lector["cant_impresiones"];

                    }
                    else
                    {
                        libro.Cant_impresiones = 0;

                    }

                    listaLibros.Add(libro);
                }
                return listaLibros;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally { datos.cerrarConexion(); }
        }

        public void agregar(Libro nuevoLibro)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setConsulta("insert into libro(isbn, titulo, id_autor, id_editorial, nro_edicion, precio_venta, precio_compra, id_idioma, anio_edicion, cant_paginas, cant_impresiones) values(@isbn, @titulo, @idAutor, @idEditorial,@nroEdicion, @precioVenta, @precioCompra, @idIdioma, @anioEdicion, @cantPaginas, @cantImpresiones)");
                datos.setParametro("@isbn", nuevoLibro.ISBN);
                datos.setParametro("@titulo", nuevoLibro.Titulo);
                datos.setParametro("@idAutor", nuevoLibro.Autor.Id_autor);
                datos.setParametro("@anioEdicion", nuevoLibro.Anio_edicion);
                datos.setParametro("@nroEdicion", nuevoLibro.Nro_edicion);
                datos.setParametro("@precioVenta", nuevoLibro.Precio_venta);
                datos.setParametro("@precioCompra", nuevoLibro.Precio_compra);
                datos.setParametro("@idIdioma", nuevoLibro.Idioma.Id_idioma);
                datos.setParametro("@cantPaginas", nuevoLibro.Cant_paginas);
                datos.setParametro("@cantImpresiones", nuevoLibro.Cant_impresiones);
                datos.setParametro("@idEditorial", nuevoLibro.Editorial.Id_editorial);
                
                datos.ejecutarInstruccion();
            }
            catch (Exception ex)
            {
                throw;
            }
            finally { datos.cerrarConexion(); }
        }

        public void modificar(Libro modificarLibro)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setConsulta("Uptade Libros SET id=@id, isbn=@isbn, idAutor=@idAutor, idEditorial=@idEditorial, idIdioma=@idIdioma, anioEdicion=@anioEdicion, cantPaginas=@cantPaginas, cantImpresiones=@cantImpresiones");
                datos.setParametro("@id", modificarLibro.Id);
                datos.setParametro("@isbn", modificarLibro.ISBN);
                datos.setParametro("@idAutor", modificarLibro.Autor.Id_autor);
                datos.setParametro("@anioEdicion", modificarLibro.Anio_edicion);
                datos.setParametro("@nroEdicion", modificarLibro.Nro_edicion);
                datos.setParametro("precioVenta", modificarLibro.Precio_venta);
                datos.setParametro("@precioCompra", modificarLibro.Precio_compra);
                datos.setParametro("@idIdioma", modificarLibro.Idioma.Id_idioma);
                datos.setParametro("@cantPaginas", modificarLibro.Cant_paginas);
                datos.setParametro("cantImpresiones", modificarLibro.Cant_impresiones);
                datos.setParametro("@idEditorial", modificarLibro.Editorial.Id_editorial);

                datos.ejecutarInstruccion();

            }
            catch (Exception ex)
            {
                throw;
            }
            finally { datos.cerrarConexion(); }
        }



    }
}
