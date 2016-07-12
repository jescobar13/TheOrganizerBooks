using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Organitzador.Model
{
    class Lleixa : List<Llibre>
    {
        public string Categoria { get; set; }
    }
}
