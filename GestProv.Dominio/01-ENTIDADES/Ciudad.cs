using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestProv.Dominio._01_ENTIDADES
{
    public class Ciudad
    {
        public long Id { get; set; }
        public string Nombre { get; set; }
        public long CodPostal { get; set; }
        public virtual Provincia Provincia { get; set; }

    }
}
