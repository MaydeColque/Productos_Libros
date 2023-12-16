using modelo;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace negocio
{
    public class LibroNegocio
    {
        public List<Libro> ListarLibros()
        {
            List<Libro> listaLibros = new List<Libro>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                string consulta = $"select id_libro id, isbn, titulo, A.nombre autor, L.id_autor id_autor, anio_edicion,E.nombre editorial, L.id_editorial id_editorial, nro_edicion, precio_venta, precio_compra, I.nombre idioma, L.id_idioma id_idioma, cant_paginas, cant_impresiones from Libro L, Autor A, Editorial E, Idioma I where L.id_autor = A.id_autor AND L.id_editorial = E.id_editorial AND L.id_idioma = I.id_idioma";
                datos.setConsulta(consulta);
                datos.ejecutarLector();

                while (datos.Lector.Read())
                {
                    Libro libro = new Libro();
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
                    if (datos.Lector["cant_paginas"] != DBNull.Value)
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

        public void EliminarLibroDeBaseDeDatos(int libroId)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {

                {

                    // Crear y ejecutar la consulta DELETE
                    datos.setConsulta("DELETE FROM Libro WHERE id_libro = @LibroId");
                    datos.setParametro("@LibroId", libroId);
                    datos.ejecutarInstruccion();
                }
            }
            catch (Exception ex)
            {
                throw;
            }
            finally { datos.cerrarConexion(); }

        }
        //Modificacion: 10 - metodo modificar
        public void modificar(Libro libro)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setConsulta("update Libro set isbn = @isbn, titulo = @titulo, id_autor = @idAutor, id_editorial = @idEditorial, nro_edicion = @nroEdicion, precio_venta = @precioVenta, precio_compra = @precioCompra, id_idioma = @idIdioma, anio_edicion = @anio, cant_paginas = @cantPaginas, cant_impresiones = @cantImpresiones where id_libro = @id");
                datos.setParametro("@id", libro.Id);
                datos.setParametro("@isbn", libro.ISBN);
                datos.setParametro("@titulo", libro.Titulo);
                datos.setParametro("@idAutor", libro.Autor.Id_autor);
                datos.setParametro("@idEditorial", libro.Editorial.Id_editorial);
                datos.setParametro("@nroEdicion", libro.Nro_edicion);
                datos.setParametro("@precioVenta", libro.Precio_venta);
                datos.setParametro("@precioCompra", libro.Precio_compra);
                datos.setParametro("@idIdioma", libro.Idioma.Id_idioma);
                datos.setParametro("@anio", libro.Anio_edicion);
                datos.setParametro("@cantPaginas", libro.Cant_paginas);
                datos.setParametro("@cantImpresiones", libro.Cant_impresiones);

                datos.ejecutarInstruccion();
            }
            catch (Exception)
            {

                throw;
            }
            finally { datos.cerrarConexion(); }

        }

        // Lista de libros oredenados


        public List<Libro> OrdenamientoPrecioMax()
        {
            List<Libro> ListaM = new List<Libro>();
            AccesoDatos datos = new AccesoDatos();

            try
            {


                datos.setConsulta("select id_libro id, isbn, titulo, A.nombre autor, L.id_autor id_autor, anio_edicion,E.nombre editorial, L.id_editorial id_editorial, nro_edicion, precio_venta, precio_compra, I.nombre idioma, L.id_idioma id_idioma, cant_paginas, cant_impresiones from Libro L, Autor A, Editorial E, Idioma I where L.id_autor = A.id_autor AND L.id_editorial = E.id_editorial AND L.id_idioma = I.id_idioma order by precio_venta DESC ");

                datos.ejecutarLector();

                while (datos.Lector.Read())
                {
                    Libro listaMp = new Libro();
                    listaMp.Id = (int)datos.Lector["id"];
                    listaMp.ISBN = (string)datos.Lector["isbn"];
                    listaMp.Titulo = (string)datos.Lector["titulo"];
                    listaMp.Autor = new Autor();
                    listaMp.Autor.Nombre = (string)datos.Lector["autor"];
                    listaMp.Autor.Id_autor = (int)datos.Lector["id_autor"];
                    listaMp.Anio_edicion = (int)datos.Lector["anio_edicion"];
                    listaMp.Editorial = new Editorial();
                    listaMp.Editorial.Nombre = (string)datos.Lector["editorial"];
                    listaMp.Editorial.Id_editorial = (int)datos.Lector["id_editorial"];
                    listaMp.Nro_edicion = (int)datos.Lector["nro_edicion"];
                    listaMp.Precio_venta = (decimal)datos.Lector["precio_venta"];
                    listaMp.Precio_compra = (decimal)datos.Lector["precio_compra"];
                    listaMp.Idioma = new Idioma();
                    listaMp.Idioma.idioma = (string)datos.Lector["idioma"];
                    listaMp.Idioma.Id_idioma = (int)datos.Lector["id_idioma"];
                    if (datos.Lector["cant_paginas"] != DBNull.Value)
                    {
                        listaMp.Cant_paginas = (int)datos.Lector["cant_paginas"];
                    }
                    else
                    {
                        listaMp.Cant_paginas = 0;
                    }
                    if (datos.Lector["cant_impresiones"] != DBNull.Value)
                    {
                        listaMp.Cant_impresiones = (int)datos.Lector["cant_impresiones"];

                    }
                    else
                    {
                        listaMp.Cant_impresiones = 0;

                    }

                    ListaM.Add(listaMp);
                }
                return ListaM;
            }
            catch (Exception)
            {
                throw;
            }
            finally { datos.cerrarConexion(); }
        }

        public List<Libro> OrdenamientoPaginasMax()
        {
            List<Libro> ListaM = new List<Libro>();
            AccesoDatos datos = new AccesoDatos();

            try
            {


                datos.setConsulta("select id_libro id, isbn, titulo, A.nombre autor, L.id_autor id_autor, anio_edicion,E.nombre editorial, L.id_editorial id_editorial, nro_edicion, precio_venta, precio_compra, I.nombre idioma, L.id_idioma id_idioma, cant_paginas, cant_impresiones from Libro L, Autor A, Editorial E, Idioma I where L.id_autor = A.id_autor AND L.id_editorial = E.id_editorial AND L.id_idioma = I.id_idioma order by cant_paginas DESC ");

                datos.ejecutarLector();

                while (datos.Lector.Read())
                {
                    Libro listaMp = new Libro();
                    listaMp.Id = (int)datos.Lector["id"];
                    listaMp.ISBN = (string)datos.Lector["isbn"];
                    listaMp.Titulo = (string)datos.Lector["titulo"];
                    listaMp.Autor = new Autor();
                    listaMp.Autor.Nombre = (string)datos.Lector["autor"];
                    listaMp.Autor.Id_autor = (int)datos.Lector["id_autor"];
                    listaMp.Anio_edicion = (int)datos.Lector["anio_edicion"];
                    listaMp.Editorial = new Editorial();
                    listaMp.Editorial.Nombre = (string)datos.Lector["editorial"];
                    listaMp.Editorial.Id_editorial = (int)datos.Lector["id_editorial"];
                    listaMp.Nro_edicion = (int)datos.Lector["nro_edicion"];
                    listaMp.Precio_venta = (decimal)datos.Lector["precio_venta"];
                    listaMp.Precio_compra = (decimal)datos.Lector["precio_compra"];
                    listaMp.Idioma = new Idioma();
                    listaMp.Idioma.idioma = (string)datos.Lector["idioma"];
                    listaMp.Idioma.Id_idioma = (int)datos.Lector["id_idioma"];
                    if (datos.Lector["cant_paginas"] != DBNull.Value)
                    {
                        listaMp.Cant_paginas = (int)datos.Lector["cant_paginas"];
                    }
                    else
                    {
                        listaMp.Cant_paginas = 0;
                    }
                    if (datos.Lector["cant_impresiones"] != DBNull.Value)
                    {
                        listaMp.Cant_impresiones = (int)datos.Lector["cant_impresiones"];

                    }
                    else
                    {
                        listaMp.Cant_impresiones = 0;

                    }

                    ListaM.Add(listaMp);
                }
                return ListaM;
            }
            catch (Exception)
            {
                throw;
            }
            finally { datos.cerrarConexion(); }
        }

        public List<Libro> OrdenamientoImpresionesMax()
        {
            List<Libro> ListaM = new List<Libro>();
            AccesoDatos datos = new AccesoDatos();

            try
            {


                datos.setConsulta("select id_libro id, isbn, titulo, A.nombre autor, L.id_autor id_autor, anio_edicion,E.nombre editorial, L.id_editorial id_editorial, nro_edicion, precio_venta, precio_compra, I.nombre idioma, L.id_idioma id_idioma, cant_paginas, cant_impresiones from Libro L, Autor A, Editorial E, Idioma I where L.id_autor = A.id_autor AND L.id_editorial = E.id_editorial AND L.id_idioma = I.id_idioma order by cant_impresiones DESC ");

                datos.ejecutarLector();

                while (datos.Lector.Read())
                {
                    Libro listaMp = new Libro();
                    listaMp.Id = (int)datos.Lector["id"];
                    listaMp.ISBN = (string)datos.Lector["isbn"];
                    listaMp.Titulo = (string)datos.Lector["titulo"];
                    listaMp.Autor = new Autor();
                    listaMp.Autor.Nombre = (string)datos.Lector["autor"];
                    listaMp.Autor.Id_autor = (int)datos.Lector["id_autor"];
                    listaMp.Anio_edicion = (int)datos.Lector["anio_edicion"];
                    listaMp.Editorial = new Editorial();
                    listaMp.Editorial.Nombre = (string)datos.Lector["editorial"];
                    listaMp.Editorial.Id_editorial = (int)datos.Lector["id_editorial"];
                    listaMp.Nro_edicion = (int)datos.Lector["nro_edicion"];
                    listaMp.Precio_venta = (decimal)datos.Lector["precio_venta"];
                    listaMp.Precio_compra = (decimal)datos.Lector["precio_compra"];
                    listaMp.Idioma = new Idioma();
                    listaMp.Idioma.idioma = (string)datos.Lector["idioma"];
                    listaMp.Idioma.Id_idioma = (int)datos.Lector["id_idioma"];
                    if (datos.Lector["cant_paginas"] != DBNull.Value)
                    {
                        listaMp.Cant_paginas = (int)datos.Lector["cant_paginas"];
                    }
                    else
                    {
                        listaMp.Cant_paginas = 0;
                    }
                    if (datos.Lector["cant_impresiones"] != DBNull.Value)
                    {
                        listaMp.Cant_impresiones = (int)datos.Lector["cant_impresiones"];

                    }
                    else
                    {
                        listaMp.Cant_impresiones = 0;

                    }

                    ListaM.Add(listaMp);
                }
                return ListaM;
            }
            catch (Exception)
            {
                throw;
            }
            finally { datos.cerrarConexion(); }
        }

        public List<Libro> OrdenamientoPrecioMin()
        {
            List<Libro> ListaM = new List<Libro>();
            AccesoDatos datos = new AccesoDatos();

            try
            {


                datos.setConsulta("select id_libro id, isbn, titulo, A.nombre autor, L.id_autor id_autor, anio_edicion,E.nombre editorial, L.id_editorial id_editorial, nro_edicion, precio_venta, precio_compra, I.nombre idioma, L.id_idioma id_idioma, cant_paginas, cant_impresiones from Libro L, Autor A, Editorial E, Idioma I where L.id_autor = A.id_autor AND L.id_editorial = E.id_editorial AND L.id_idioma = I.id_idioma order by precio_venta ASC ");

                datos.ejecutarLector();

                while (datos.Lector.Read())
                {
                    Libro listaMp = new Libro();
                    listaMp.Id = (int)datos.Lector["id"];
                    listaMp.ISBN = (string)datos.Lector["isbn"];
                    listaMp.Titulo = (string)datos.Lector["titulo"];
                    listaMp.Autor = new Autor();
                    listaMp.Autor.Nombre = (string)datos.Lector["autor"];
                    listaMp.Autor.Id_autor = (int)datos.Lector["id_autor"];
                    listaMp.Anio_edicion = (int)datos.Lector["anio_edicion"];
                    listaMp.Editorial = new Editorial();
                    listaMp.Editorial.Nombre = (string)datos.Lector["editorial"];
                    listaMp.Editorial.Id_editorial = (int)datos.Lector["id_editorial"];
                    listaMp.Nro_edicion = (int)datos.Lector["nro_edicion"];
                    listaMp.Precio_venta = (decimal)datos.Lector["precio_venta"];
                    listaMp.Precio_compra = (decimal)datos.Lector["precio_compra"];
                    listaMp.Idioma = new Idioma();
                    listaMp.Idioma.idioma = (string)datos.Lector["idioma"];
                    listaMp.Idioma.Id_idioma = (int)datos.Lector["id_idioma"];
                    if (datos.Lector["cant_paginas"] != DBNull.Value)
                    {
                        listaMp.Cant_paginas = (int)datos.Lector["cant_paginas"];
                    }
                    else
                    {
                        listaMp.Cant_paginas = 0;
                    }
                    if (datos.Lector["cant_impresiones"] != DBNull.Value)
                    {
                        listaMp.Cant_impresiones = (int)datos.Lector["cant_impresiones"];

                    }
                    else
                    {
                        listaMp.Cant_impresiones = 0;

                    }

                    ListaM.Add(listaMp);
                }
                return ListaM;
            }
            catch (Exception)
            {
                throw;
            }
            finally { datos.cerrarConexion(); }
        }

        public List<Libro> OrdenamientoPaginasMin()
        {
            List<Libro> ListaM = new List<Libro>();
            AccesoDatos datos = new AccesoDatos();

            try
            {


                datos.setConsulta("select id_libro id, isbn, titulo, A.nombre autor, L.id_autor id_autor, anio_edicion,E.nombre editorial, L.id_editorial id_editorial, nro_edicion, precio_venta, precio_compra, I.nombre idioma, L.id_idioma id_idioma, cant_paginas, cant_impresiones from Libro L, Autor A, Editorial E, Idioma I where L.id_autor = A.id_autor AND L.id_editorial = E.id_editorial AND L.id_idioma = I.id_idioma order by cant_paginas ASC ");

                datos.ejecutarLector();

                while (datos.Lector.Read())
                {
                    Libro listaMp = new Libro();
                    listaMp.Id = (int)datos.Lector["id"];
                    listaMp.ISBN = (string)datos.Lector["isbn"];
                    listaMp.Titulo = (string)datos.Lector["titulo"];
                    listaMp.Autor = new Autor();
                    listaMp.Autor.Nombre = (string)datos.Lector["autor"];
                    listaMp.Autor.Id_autor = (int)datos.Lector["id_autor"];
                    listaMp.Anio_edicion = (int)datos.Lector["anio_edicion"];
                    listaMp.Editorial = new Editorial();
                    listaMp.Editorial.Nombre = (string)datos.Lector["editorial"];
                    listaMp.Editorial.Id_editorial = (int)datos.Lector["id_editorial"];
                    listaMp.Nro_edicion = (int)datos.Lector["nro_edicion"];
                    listaMp.Precio_venta = (decimal)datos.Lector["precio_venta"];
                    listaMp.Precio_compra = (decimal)datos.Lector["precio_compra"];
                    listaMp.Idioma = new Idioma();
                    listaMp.Idioma.idioma = (string)datos.Lector["idioma"];
                    listaMp.Idioma.Id_idioma = (int)datos.Lector["id_idioma"];
                    if (datos.Lector["cant_paginas"] != DBNull.Value)
                    {
                        listaMp.Cant_paginas = (int)datos.Lector["cant_paginas"];
                    }
                    else
                    {
                        listaMp.Cant_paginas = 0;
                    }
                    if (datos.Lector["cant_impresiones"] != DBNull.Value)
                    {
                        listaMp.Cant_impresiones = (int)datos.Lector["cant_impresiones"];

                    }
                    else
                    {
                        listaMp.Cant_impresiones = 0;

                    }

                    ListaM.Add(listaMp);
                }
                return ListaM;
            }
            catch (Exception)
            {
                throw;
            }
            finally { datos.cerrarConexion(); }
        }

        public List<Libro> OrdenamientoImpresionesMin()
        {
            List<Libro> ListaM = new List<Libro>();
            AccesoDatos datos = new AccesoDatos();

            try
            {


                datos.setConsulta("select id_libro id, isbn, titulo, A.nombre autor, L.id_autor id_autor, anio_edicion,E.nombre editorial, L.id_editorial id_editorial, nro_edicion, precio_venta, precio_compra, I.nombre idioma, L.id_idioma id_idioma, cant_paginas, cant_impresiones from Libro L, Autor A, Editorial E, Idioma I where L.id_autor = A.id_autor AND L.id_editorial = E.id_editorial AND L.id_idioma = I.id_idioma order by cant_impresiones ASC ");

                datos.ejecutarLector();

                while (datos.Lector.Read())
                {
                    Libro listaMp = new Libro();
                    listaMp.Id = (int)datos.Lector["id"];
                    listaMp.ISBN = (string)datos.Lector["isbn"];
                    listaMp.Titulo = (string)datos.Lector["titulo"];
                    listaMp.Autor = new Autor();
                    listaMp.Autor.Nombre = (string)datos.Lector["autor"];
                    listaMp.Autor.Id_autor = (int)datos.Lector["id_autor"];
                    listaMp.Anio_edicion = (int)datos.Lector["anio_edicion"];
                    listaMp.Editorial = new Editorial();
                    listaMp.Editorial.Nombre = (string)datos.Lector["editorial"];
                    listaMp.Editorial.Id_editorial = (int)datos.Lector["id_editorial"];
                    listaMp.Nro_edicion = (int)datos.Lector["nro_edicion"];
                    listaMp.Precio_venta = (decimal)datos.Lector["precio_venta"];
                    listaMp.Precio_compra = (decimal)datos.Lector["precio_compra"];
                    listaMp.Idioma = new Idioma();
                    listaMp.Idioma.idioma = (string)datos.Lector["idioma"];
                    listaMp.Idioma.Id_idioma = (int)datos.Lector["id_idioma"];
                    if (datos.Lector["cant_paginas"] != DBNull.Value)
                    {
                        listaMp.Cant_paginas = (int)datos.Lector["cant_paginas"];
                    }
                    else
                    {
                        listaMp.Cant_paginas = 0;
                    }
                    if (datos.Lector["cant_impresiones"] != DBNull.Value)
                    {
                        listaMp.Cant_impresiones = (int)datos.Lector["cant_impresiones"];

                    }
                    else
                    {
                        listaMp.Cant_impresiones = 0;

                    }

                    ListaM.Add(listaMp);
                }
                return ListaM;
            }
            catch (Exception)
            {
                throw;
            }
            finally { datos.cerrarConexion(); }
        }
    }
}
