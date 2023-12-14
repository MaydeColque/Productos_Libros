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
    public partial class FmrModificar : Form
    {
        public FmrModificar()
        {
            InitializeComponent();
        }

        private void cargarDGV()
        {
            LibroNegocio modificar = new LibroNegocio();
            dgvModificar.DataSource = modificar.ListarLibros();
        }
        private void estiloDGV()
        {
            dgvModificar.Columns["Id"].Visible = false;
            dgvModificar.Columns["Idioma"].Width = 63;
            dgvModificar.Columns["Nro_edicion"].Width = 50;
            dgvModificar.Columns["Anio_edicion"].Width = 45;
            dgvModificar.Columns["Precio_venta"].Width = 58;
            dgvModificar.Columns["Precio_compra"].Width = 58;
            dgvModificar.Columns["Cant_paginas"].Width = 55;
            dgvModificar.Columns["Cant_impresiones"].Width = 65;


        }

        private void FormModificar_Load(object sender, EventArgs e)
        {
            cargarDGV();
            estiloDGV();
        }

        private void dgvModificar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtISBNmd.Text = dgvModificar.CurrentRow.Cells[1].Value.ToString();
            txtTituloM.Text = dgvModificar.CurrentRow.Cells[2].Value.ToString();
            txtAutorM.Text = dgvModificar.CurrentRow.Cells[3].Value.ToString();
            txtEditorialM.Text = dgvModificar.CurrentRow.Cells[4].Value.ToString();
            txtNroEdicionM.Text = dgvModificar.CurrentRow.Cells[5].Value.ToString();
            txtPrecioVenM.Text = dgvModificar.CurrentRow.Cells[6].Value.ToString();
            txtPrecioCm.Text = dgvModificar.CurrentRow.Cells[7].Value.ToString();
            txtIdiomaM.Text = dgvModificar.CurrentRow.Cells[8].Value.ToString();
            txtAnioEdiM.Text = dgvModificar.CurrentRow.Cells[9].Value.ToString();
            txtImpresionM.Text = dgvModificar.CurrentRow.Cells[10].Value.ToString();
            txtPaginasM.Text = dgvModificar.CurrentRow.Cells[11].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
