using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestProv.Dominio._01_ENTIDADES
{
    public class Tecnico
    {
        public long Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string DNI { get; set; }
        public string Mail { get; set; }
        public string Telefono { get; set; }
        public virtual Proveedor Proveedor { get; set; }
        public bool Estado { get; set; }
    }
}
