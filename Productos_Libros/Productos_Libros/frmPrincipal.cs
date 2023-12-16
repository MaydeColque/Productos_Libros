using negocio;
using modelo;
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
    public partial class frmPrincipal : Form
    {
        //Helpers
        List<Libro> librosExtraidos;
        Libro libroSeleccionado;
        //Constructores
        public frmPrincipal()
        {
            InitializeComponent();
        }
        //Métodos
        private void cargarDGV()
        {
            LibroNegocio libros = new LibroNegocio();
            librosExtraidos = libros.ListarLibros();
            dgvLibros.DataSource= librosExtraidos;
        }
        private void estiloDGV()
        {
            dgvLibros.Columns["Id"].Visible= false;
            dgvLibros.Columns["Idioma"].Width = 63; 
            dgvLibros.Columns["Nro_edicion"].Width = 50;
            dgvLibros.Columns["Anio_edicion"].Width = 45;
            dgvLibros.Columns["Precio_venta"].Width= 58; 
            dgvLibros.Columns["Precio_compra"].Width = 58;
            dgvLibros.Columns["Cant_paginas"].Width = 55;
            dgvLibros.Columns["Cant_impresiones"].Width = 65;


        }
        public void nuevaListaDGV(DataGridView nombreDGV, List<Libro> nuevaLista)
        {
            nombreDGV.DataSource = null;
            nombreDGV.DataSource = nuevaLista;
            estiloDGV();
        }
        public bool itemSeleccionado()
        {
            if (dgvLibros.CurrentRow != null)
            {
               libroSeleccionado = (Libro)dgvLibros.CurrentRow.DataBoundItem;
                return true;
            }
            else
            {
                MessageBox.Show("Seleccione un libro, por favor.", "No se ha seleccionado ningún libro...", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
        }

        //Eventos
        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            cBoxOrdenarPor.Items.Add("Máximos");
            cBoxOrdenarPor.Items.Add("Minímos");
            cBoxCriterios.Items.Add("Precio Venta");
            cBoxCriterios.Items.Add("Impresiones");
            cBoxCriterios.Items.Add("Páginas");
            cargarDGV();
            estiloDGV();
        }

        private void btnNuevoLibro_Click(object sender, EventArgs e)
        {
            frmCrudDatos nuevoLibro = new frmCrudDatos();
            nuevoLibro.ShowDialog();
            cargarDGV();
        }

        private void txtBuscador_TextChanged(object sender, EventArgs e)
        {
            List<Libro> librosEncontrados = new List<Libro>();
            string criterioBuscado = txtBuscador.Text;

            if (criterioBuscado != "" && criterioBuscado != "Buscar")
            {
                librosEncontrados = librosExtraidos.FindAll(libro => libro.ISBN.Contains(criterioBuscado) || libro.Titulo.ToUpper().Contains(criterioBuscado.ToUpper()) || libro.Autor.Nombre.ToUpper().Contains(criterioBuscado.ToUpper()));

            }
            else
            {
                librosEncontrados = librosExtraidos;
            }
            nuevaListaDGV(dgvLibros, librosEncontrados);
        }


        private void btnLimpiarBuscador_Click(object sender, EventArgs e)
        {
            txtBuscador.Text = "Buscar";
        }

        private void btnVerDetalle_Click(object sender, EventArgs e)
        {
            //Modificacion: 2
            if (itemSeleccionado())
            {
                frmCrudDatos verDetalle = new frmCrudDatos(libroSeleccionado, false);
                verDetalle.ShowDialog();
            }

        }

        private void txtBuscador_Enter(object sender, EventArgs e)
        {
            txtBuscador.Text = "";
        }
        //Modificacion: 1
        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (itemSeleccionado())
            {
                frmCrudDatos modificar = new frmCrudDatos(libroSeleccionado, true);
                modificar.ShowDialog();
                cargarDGV();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            LibroNegocio libroEliminado = new LibroNegocio();

            if (itemSeleccionado())
            {
                libroEliminado.EliminarLibroDeBaseDeDatos(libroSeleccionado.Id);
                cargarDGV();
            }
        }

        private void cBoxCriterios_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cBoxCriterios.Text.Length == 0 || cBoxOrdenarPor.Text.Length == 0)
            {
                MessageBox.Show("Faltan casillas por llenar");
            }

            if (cBoxCriterios.Text == "Precio Venta" && cBoxOrdenarPor.Text == "Máximos")
            {

                List<Libro> ListasOrdenadas = new List<Libro>();
                LibroNegocio ListadoOrder = new LibroNegocio();
                ListasOrdenadas = ListadoOrder.OrdenamientoPrecioMax();
                nuevaListaDGV(dgvLibros, ListasOrdenadas);
            }

            if (cBoxCriterios.Text == "Precio Venta" && cBoxOrdenarPor.Text == "Minímos")
            {
                List<Libro> ListasOrdenadas = new List<Libro>();
                LibroNegocio ListadoOrder = new LibroNegocio();
                ListasOrdenadas = ListadoOrder.OrdenamientoPrecioMin();
                nuevaListaDGV(dgvLibros, ListasOrdenadas);
            }

            if (cBoxCriterios.Text == "Impresiones" && cBoxOrdenarPor.Text == "Máximos")
            {

                List<Libro> ListasOrdenadas = new List<Libro>();
                LibroNegocio ListadoOrder = new LibroNegocio();
                ListasOrdenadas = ListadoOrder.OrdenamientoImpresionesMax();
                nuevaListaDGV(dgvLibros, ListasOrdenadas);
            }
            if (cBoxCriterios.Text == "Impresiones" && cBoxOrdenarPor.Text == "Minímos")
            {
                List<Libro> ListasOrdenadas = new List<Libro>();
                LibroNegocio ListadoOrder = new LibroNegocio();
                ListasOrdenadas = ListadoOrder.OrdenamientoImpresionesMin();
                nuevaListaDGV(dgvLibros, ListasOrdenadas);
            }

            if (cBoxCriterios.Text == "Páginas" && cBoxOrdenarPor.Text == "Minímos")
            {
                List<Libro> ListasOrdenadas = new List<Libro>();
                LibroNegocio ListadoOrder = new LibroNegocio();
                ListasOrdenadas = ListadoOrder.OrdenamientoPaginasMin();
                nuevaListaDGV(dgvLibros, ListasOrdenadas);
            }

            if (cBoxCriterios.Text == "Páginas" && cBoxOrdenarPor.Text == "Máximos")
            {
                List<Libro> ListasOrdenadas = new List<Libro>();
                LibroNegocio ListadoOrder = new LibroNegocio();
                ListasOrdenadas = ListadoOrder.OrdenamientoPaginasMax();
                nuevaListaDGV(dgvLibros, ListasOrdenadas);
            }
        }
    }
}
