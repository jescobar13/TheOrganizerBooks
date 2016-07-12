using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Organitzador
{
    class Llibre
    {

        public string Titol { get; set; }
        public string Autor { get; set; }

        public override string ToString()
        {
            return "Titol: " + Titol + "  Autor: " + Autor;
        }
    }

    class LlibreVirtual
    {
        public string Titol { get; set; }
        public string Autor { get; set; }

        public override string ToString()
        {
            return "Titol: " + Titol + "  Autor: " + Autor;
        }
    }

    class Revista
    {
        public string Titol { get; set; }
        public string editorial { get; set; }
    }

    class TemaLectura
    {
        public string Tema { get; set; }
    }
}
