using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestProv.Dominio._01_ENTIDADES
{
    public class Equipamiento
    {
        public long Id { get; set; }
        public string Nombre { get; set; }
        public long DiasGarantia { get; set; }
        public virtual Categoria Categoria { get; set; }
        public virtual Compra Compra { get; set; }

        

    }
}
