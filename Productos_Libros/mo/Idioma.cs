using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modelo
{
    public class Idioma
    {
        public int Id_idioma { get; set; }
        public string idioma { get; set; }

        public override string ToString()
        {
            return idioma;
        }
    }
}
