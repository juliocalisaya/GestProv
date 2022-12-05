using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestProv.Dominio._01_ENTIDADES
{
    public class Sucursal
    {
        public long Id { get; set; }
        public string NombreCalle { get; set; }
        public string Altura { get; set; }
        public string Piso { get; set; }
        public string Telefono { get; set; }
        public string Mail { get; set; }
        public virtual Proveedor Proveedor { get; set; }

        public virtual Ciudad Ciudad { get; set; }

    }
}
