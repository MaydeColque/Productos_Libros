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

        /*
        private void btnGenerarLista_Click(object sender, EventArgs e)
        {
            int opcionOrdenar = cBoxOrdenarPor.SelectedIndex;
            int opcionCriterio = cBoxCriterios.SelectedIndex;
            if ( opcionOrdenar > 0 && opcionCriterio > 0)
            {
                if (opcionOrdenar == 1)
                {
                    nuevaListaDGV(dgvLibros, listaMinimos(opcionCriterio));
                }
                else
                {
                    nuevaListaDGV(dgvLibros, listaMaximos(opcionCriterio));
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una opción en ambos campos.", "Falta seleccionar campos...");
            }
        }
        //crear listados máximos y mínimos
        public List<Libro> listaMinimos(int indexCriterio)
        {
            List<Libro> listaMin = librosExtraidos;
            int cantLibros = listaMin.Count;
            switch (indexCriterio)
            {
                case 1:
                    //precio venta
                    decimal aux;
                    for (int i = 0; i < cantLibros; i++)
                    {
                        for (int x = 0; x < (cantLibros - 1); x++)
                        {
                            if (listaMin[x].Precio_venta > listaMin[x+1].Precio_venta)
                            {
                                aux = listaMin[x].Precio_venta;
                                listaMin[x].Precio_venta = listaMin[x + 1].Precio_venta;
                                listaMin[x + 1].Precio_venta = aux;
                            }
                        }
                    }
                    break; 
                case 2:
                    //impresiones
                    int impresiones;
                    for (int i = 0; i < cantLibros; i++)
                    {
                        for (int x = 0; x < (cantLibros - 1); x++)
                        {
                            if (listaMin[x].Cant_impresiones > listaMin[x + 1].Cant_impresiones)
                            {
                                impresiones = listaMin[x].Cant_impresiones;
                                listaMin[x].Cant_impresiones = listaMin[x + 1].Cant_impresiones;
                                listaMin[x + 1].Cant_impresiones = impresiones;
                            }
                        }
                    }
                    break;
                case 3:
                    //paginas
                    int paginas;
                    for (int i = 0; i < cantLibros; i++)
                    {
                        for (int x = 0; x < (cantLibros - 1); x++)
                        {
                            if (listaMin[x].Cant_paginas > listaMin[x + 1].Cant_paginas)
                            {
                                paginas = listaMin[x].Cant_paginas;
                                listaMin[x].Cant_paginas = listaMin[x + 1].Cant_paginas;
                                listaMin[x + 1].Cant_paginas = paginas;
                            }
                        }
                    }
                    break;
            }
            return listaMin;

        }
        public List<Libro> listaMaximos(int indexCriterio)
        {
            List<Libro> listaMax = librosExtraidos;
            int cantLibros = listaMax.Count;
            switch (indexCriterio)
            {
                case 1:
                    //precio venta
                    decimal aux;
                    for (int i = 0; i < cantLibros; i++)
                    {
                        for (int x = 0; x < (cantLibros - 1); x++)
                        {
                            if (listaMax[x].Precio_venta < listaMax[x + 1].Precio_venta)
                            {
                                aux = listaMax[x].Precio_venta;
                                listaMax[x].Precio_venta = listaMax[x + 1].Precio_venta;
                                listaMax[x + 1].Precio_venta = aux;
                            }
                        }
                    }
                    break;
                case 2:
                    //impresiones
                    int impresiones;
                    for (int i = 0; i < cantLibros; i++)
                    {
                        for (int x = 0; x < (cantLibros - 1); x++)
                        {
                            if (listaMax[x].Cant_impresiones < listaMax[x + 1].Cant_impresiones)
                            {
                                impresiones = listaMax[x].Cant_impresiones;
                                listaMax[x].Cant_impresiones = listaMax[x + 1].Cant_impresiones;
                                listaMax[x + 1].Cant_impresiones = impresiones;
                            }
                        }
                    }
                    break;
                case 3:
                    //páginas
                    int paginas;
                    for (int i = 0; i < cantLibros; i++)
                    {
                        for (int x = 0; x < (cantLibros - 1); x++)
                        {
                            if (listaMax[x].Cant_paginas < listaMax[x + 1].Cant_paginas)
                            {
                                paginas = listaMax[x].Cant_paginas;
                                listaMax[x].Cant_paginas = listaMax[x + 1].Cant_paginas;
                                listaMax[x + 1].Cant_paginas = paginas;
                            }
                        }
                    }
                    break;
            }
            return listaMax;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            LibroNegocio libroEliminado = new LibroNegocio(); 

            if (itemSeleccionado()){
                libroEliminado.EliminarLibroDeBaseDeDatos(libroSeleccionado.Id);
                cargarDGV();
            }
        }

        //Modificaciones:
        /*
            - Manejo de nulos cuando el sistema detecta que no se ha seleccionado ningún libro
                - itemSeleccionado(): Ahora devuelve true o false. True si se ha seleccionado un libro. Y falso, en caso de que no.
                - btnVerDetalle_click(): Ahora, pregunta con if si itemSelccionado() es true para mostrar la info sobre algún libro seleccionado.


         */

    }
}
