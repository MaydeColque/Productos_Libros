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
    public partial class frmPrincipal : Form
    {
        //Constructores
        public frmPrincipal()
        {
            InitializeComponent();
        }
        //Métodos
        private void cargarDGV()
        {
            LibroNegocio libros = new LibroNegocio();
            dgvLibros.DataSource= libros.ListarLibros();
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
    }
}
