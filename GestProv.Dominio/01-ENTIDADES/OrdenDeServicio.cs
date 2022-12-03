using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestProv.Dominio._01_ENTIDADES
{
    public class OrdenDeServicio
    {
        public long Id { get; set; }
        public string Descripcion { get; set; }
        public string FechaSolicitud { get; set; }
        public string FechaEstimadaResolucion { get; set; }
        public string FechaRealResolucion { get; set; }
        public virtual Tecnico Tecnico { get; set; }
    }
}
