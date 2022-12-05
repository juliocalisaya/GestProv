using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestProv.Dominio._01_ENTIDADES
{
    public class Compra
    {
        public long Id { get; set; }
        public string FechaCompra { get; set; }
        public double Monto { get; set; }
        public string FechaEstimadaEntrega { get; set; }
        public string FechaRealEntrega { get; set; }
        public string Factura { get; set; }
        public virtual Proveedor Proveedor { get; set; }

        public List<int> EquipamientoId { get; set; }

        public virtual List<Equipamiento> Equipamientos { get; set; }


    }
}
