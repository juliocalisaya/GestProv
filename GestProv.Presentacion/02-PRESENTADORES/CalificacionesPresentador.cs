using GestProv.Dominio._01_ENTIDADES;
using GestProv.InfraestructuraDatos._01_BASE_DE_DATOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestProv.Presentacion._02_PRESENTADORES
{
    public class CalificacionesPresentador
    {
        public CalificacionesPresentador()
        {

        }

        public List<Proveedor> ObtenerProveedores(GestProvContexto contexto)
        {
            return contexto.ObtenerProveedoresActivos();
        }

    }
}
