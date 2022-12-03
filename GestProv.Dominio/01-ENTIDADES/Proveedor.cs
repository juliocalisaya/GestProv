using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestProv.Dominio._01_ENTIDADES
{
    public class Proveedor
    {
        public long Id { get; set; }
        public string NombreyApellido { get; set; }
        public string RazonSocial { get; set; }
        public string CUIT { get; set; }
        public bool Estado { get; set; }
    }
}
