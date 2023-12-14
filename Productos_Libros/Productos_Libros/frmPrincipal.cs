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
        public void itemSeleccionado()
        {
            if (dgvLibros.CurrentRow.Selected)
            {
               libroSeleccionado = (Libro)dgvLibros.CurrentRow.DataBoundItem;
            }
            else
            {
                MessageBox.Show("Seleccione un libro, por favor.", "No se ha seleccionado ningún libro...", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        //Eventos
        private void frmPrincipal_Load(object sender, EventArgs e)
        {
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
            itemSeleccionado();
            frmCrudDatos verDetalle = new frmCrudDatos(libroSeleccionado);
            verDetalle.ShowDialog();

        }

        private void txtBuscador_Enter(object sender, EventArgs e)
        {
            txtBuscador.Text = "";
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

        }
    }
}
