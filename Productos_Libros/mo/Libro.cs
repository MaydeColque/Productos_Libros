using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modelo
{
    public class Libro
    {
        public int Id { get; set; }
        public string ISBN { get; set; }
        public string Titulo { get; set; }
        public Autor Autor { get; set; }
        public Editorial Editorial { get; set; }
        [DisplayName("Nro Edición")]
        public int Nro_edicion { get; set; }
        [DisplayName("Precio Venta")]
        public decimal Precio_venta { get; set; }
        [DisplayName("Precio Compra")]
        public decimal Precio_compra { get; set; }
        public Idioma Idioma { get; set; }
        [DisplayName("Año Edición")]
        public int Anio_edicion { get; set; }
        [DisplayName("Impresiones")]
        public int Cant_impresiones { get; set; }
        [DisplayName("Páginas")]
        public int Cant_paginas { get; set; }
    }
}
