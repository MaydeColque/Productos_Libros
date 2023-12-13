using modelo;
using negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Productos_Libros
{
    public partial class frmCrudDatos : Form
    {
        //Helpers
        List<Libro> listaLibros;
        bool camposCorrectamenteCompletos;
        //bool itemNuevo;



        //Constructores
        public frmCrudDatos()
        {
            InitializeComponent();
            listaLibros= new List<Libro>();
            btnAceptar.Text = "Guardar";
        }
        //Métodos
        /*
         
        public void cargarCBX()
        {
            AutorNegocio autor = new AutorNegocio();
            cBxAutor.DataSource = autor.listaAutores();
            cBxAutor.ValueMember = "Id_autor";
            cBxAutor.DisplayMember = "Nombre";
            EditorialNegocio editorial= new EditorialNegocio();
            cBxEditorial.DataSource = editorial.listaEditorial();
            cBxEditorial.ValueMember = "Id_editorial";
            cBxEditorial.DisplayMember = "Nombre";
            IdiomaNegocio idioma = new IdiomaNegocio();
            cBxIdioma.DataSource = idioma.listaIdioma();
            cBxIdioma.ValueMember = "Id_idioma";
            cBxIdioma.DisplayMember = "idioma";
        }
         
         */
        public bool isbnRepetido()
        {
            if (listaLibros.Any(x => x.ISBN == txtIsbn.Text))
            {
                return true;
            }
            return false;
        }
        public void cargarCbxAutor()
        {
            AutorNegocio autor = new AutorNegocio();
            cBxAutor.DataSource = autor.listaAutores();
            cBxAutor.ValueMember = "Id_autor";
            cBxAutor.DisplayMember = "Nombre";
        }
        public void cargarCbxEditorial()
        {   
            EditorialNegocio editorial = new EditorialNegocio();
            cBxEditorial.DataSource = editorial.listaEditorial();
            cBxEditorial.ValueMember = "Id_editorial";
            cBxEditorial.DisplayMember = "Nombre";
        }
        public void cargarCbxIdioma()
        {
            IdiomaNegocio idioma = new IdiomaNegocio();
            cBxIdioma.DataSource = idioma.listaIdioma();
            cBxIdioma.ValueMember = "Id_idioma";
            cBxIdioma.DisplayMember = "idioma";
        }
        public void verificarDatos()
        {
            //itemNuevo = false;
            camposCorrectamenteCompletos = false;
            if (isbnRepetido() || txtIsbn.Text.Length != 14 || !esNumero(txtIsbn.Text))
            {
                txtIsbn.BackColor = Color.IndianRed;
                if (txtIsbn.Text.Length != 14 || !esNumero(txtIsbn.Text))
                {
                    lblAlertaIsbn.Visible = true;
                    return;
                }
                lblIsbnRepetido.Visible = true;
            }
            else if (txtTitulo.Text == "")
            {
                lblAlertaTitulo.Visible = true;
            }
            else if (cBxAutor.SelectedItem == null)
            {
                if (cBxAutor.Text != "")
                {
                    //Agregar el nuevo Autor a la base de datos
                    DialogResult respuesta = MessageBox.Show("Se ha detectado un nuevo AUTOR ¿Deseas agregarlo a la Base de Datos?", "Nuevo Autor Encontrado", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (respuesta == DialogResult.Yes)
                    {
                        int nuevoAutor = cBxAutor.Items.Count;
                        AutorNegocio autorNegocio = new AutorNegocio();
                        autorNegocio.agregarAutor(cBxAutor.Text);
                        MessageBox.Show("Autor agregado. Haz click nuevamente en Guardar.", "Notificación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        cargarCbxAutor();
                        
                        cBxAutor.SelectedIndex = nuevoAutor;
                        //itemNuevo = true;
                    }
                }
                else
                {
                    //REVISAR
                    lblAlertaAutor.Visible = true;
                }

            }
            else if (cBxEditorial.SelectedItem == null)
            {
                if (cBxEditorial.Text != "")
                {
                    //Agregar el nuevo Autor a la base de datos
                    DialogResult respuesta = MessageBox.Show("Se ha detectado una nueva Editorial ¿Deseas agregarla a la Base de Datos?", "Nueva Editorial Encontrada", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (respuesta == DialogResult.Yes)
                    {
                        int nuevaEditorial = cBxEditorial.Items.Count;
                        EditorialNegocio editorial = new EditorialNegocio();
                        editorial.agregar(cBxEditorial.Text);
                        MessageBox.Show("Editorial agregada. Haz click nuevamente en Guardar.", "Notificación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        cargarCbxEditorial();
                        cBxEditorial.SelectedIndex = nuevaEditorial;
                        //itemNuevo = true;
                    }
                }
                else
                {
                    //REVISAR
                    lblAlertaEditorial.Visible = true;
                }
            }
            else if (cBxIdioma.SelectedItem == null)
            {
                if (cBxIdioma.Text != "")
                {
                    //Agregar el nuevo Idioma a la base de datos
                    DialogResult respuesta = MessageBox.Show("Se ha detectado un nuevo IDIOMA ¿Deseas agregarlo a la Base de Datos?", "Nuevo Idioma Encontrado", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (respuesta == DialogResult.Yes)
                    {
                        int nuevoIdioma = cBxIdioma.Items.Count;
                        IdiomaNegocio idioma = new IdiomaNegocio();
                        idioma.agregar(cBxIdioma.Text);
                        MessageBox.Show("Idioma agregado. Haz click nuevamente en Guardar.", "Notificación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        cargarCbxIdioma();
                        cBxIdioma.SelectedIndex = nuevoIdioma;
                        //itemNuevo = true;
                    }
                }
                else
                {
                    lblAlertaIdioma.Visible = true;
                }

            }
            else if (!esNumero(txtAnioEdicion.Text))
            {
                lblAlertaAño.Visible = true;
            }
            else if (!esNumero(txtNroEdicion.Text))
            {
                lblAlertaNroEdicion.Visible = true;
            }
            else if (!esNumero(txtPaginas.Text))
            {
                lblAlertaPaginas.Visible = true;
            }
            else if (!esNumero(txtImpresiones.Text))
            {
                lblAlertaImpresiones.Visible = true;
            }
            else if (!esNumero(txtPrecioVenta.Text))
            {
                lblAlertaPrecioVenta.Visible = true;
            }
            else if (!esNumero(txtPrecioCompra.Text))
            {
                lblAlertaPrecioCompra.Visible = true;
            }
            else
            {
                camposCorrectamenteCompletos = true;
            }

        }
        public bool esNumero(string numero)
        {
            if (string.IsNullOrEmpty(numero))
            {
                return false;
            }
            foreach (char caracter in numero)
            {
                if (!char.IsNumber(caracter) && caracter != '.' && caracter != ',')
                {
                    return false;
                }
            }

            return true;
        }
       
         
        public void reestablecerDatos()
        {
            cBxAutor.Text = "";
            cBxEditorial.Text = "";
            cBxIdioma.Text = "";
            txtAnioEdicion.Text = "";
            txtImpresiones.Text = "";
            txtIsbn.Text = "";
            txtTitulo.Text = "";
            txtNroEdicion.Text = "";
            txtPaginas.Text = "";
            txtPrecioCompra.Text = "";
            txtPrecioVenta.Text = "";

            lblAlertaAutor.Visible = false;
            lblIsbnRepetido.Visible = false;
            txtIsbn.BackColor = Color.White;
            lblAlertaTitulo.Visible = false;
            lblAlertaAño.Visible = false;
            lblAlertaEditorial.Visible = false;
            lblAlertaIdioma.Visible = false;
            lblAlertaImpresiones.Visible = false;
            lblAlertaPaginas.Visible = false;
            lblAlertaPrecioVenta.Visible = false;
            lblAlertaPrecioCompra.Visible = false;
            lblAlertaNroEdicion.Visible = false;

        }
        
        //Eventos
        private void frmCrudDatos_Load(object sender, EventArgs e)
        {
            cargarCbxAutor();
            cargarCbxEditorial();
            cargarCbxIdioma();
            cBxAutor.SelectedIndex = -1;
            cBxEditorial.SelectedIndex = -1;
            cBxIdioma.SelectedIndex = -1;
        }
        public void actualizarListaLibros()
        {

            LibroNegocio libroNegocio = new LibroNegocio();
            listaLibros = libroNegocio.ListarLibros();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            actualizarListaLibros();
            verificarDatos();
            if (camposCorrectamenteCompletos)
            {
                Libro libro = new Libro();

                libro.Autor = (Autor)cBxAutor.SelectedItem;
                libro.Titulo = txtTitulo.Text;
                libro.Editorial = (Editorial)cBxEditorial.SelectedItem;
                libro.Anio_edicion = int.Parse(txtAnioEdicion.Text);
                libro.ISBN = txtIsbn.Text;
                libro.Idioma = (Idioma)cBxIdioma.SelectedItem;
                libro.Nro_edicion = int.Parse(txtNroEdicion.Text);
                libro.Cant_impresiones = int.Parse(txtImpresiones.Text);
                libro.Cant_paginas = int.Parse(txtPaginas.Text);
                libro.Precio_venta = decimal.Parse(txtPrecioVenta.Text);
                libro.Precio_compra = decimal.Parse(txtPrecioCompra.Text);

                LibroNegocio libroNegocio = new LibroNegocio();
                libroNegocio.agregar(libro);
                DialogResult respuesta = MessageBox.Show("Agregado con éxito! ¿Deseas continuar con el ingreso de nuevos libros?", "Nuevo libro", MessageBoxButtons.YesNo);
                if (respuesta == DialogResult.Yes)
                {
                    reestablecerDatos();
                }
                else
                {
                    Close();
                }
            }
            /*
            else if(!itemNuevo)
            {
                MessageBox.Show("Los campos deben ser correctamente completados antes de guardar un libro. Por favor, verificalos.");
            }
             */

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtIsbn_Leave(object sender, EventArgs e)
        {
            if (esNumero(txtIsbn.Text) && !isbnRepetido())
            {
                txtIsbn.BackColor = Color.LightGreen;
                lblAlertaIsbn.Visible = false;
                lblIsbnRepetido.Visible = false;
            }
            else if(txtIsbn.Text.Length == 14)
            {
                lblAlertaIsbn.Visible = false;
            }

        }

    }
}
