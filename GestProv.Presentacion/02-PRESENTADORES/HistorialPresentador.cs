using GestProv.Dominio._01_ENTIDADES;
using GestProv.InfraestructuraDatos._01_BASE_DE_DATOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestProv.Presentacion._02_PRESENTADORES
{
    public class HistorialPresentador
    {
        private GestProvContexto _contexto = new GestProvContexto();
        public HistorialPresentador()
        {

        }
        public List<Proveedor> ObtenerProveedores()
        {
            return _contexto.ObtenerProveedoresActivos();
        }

        public List<Compra> ObtenerComprasProveedor(Proveedor proveedor)
        {
            return _contexto.ObtenerComprasProveedor(proveedor);
        }



    }
}
