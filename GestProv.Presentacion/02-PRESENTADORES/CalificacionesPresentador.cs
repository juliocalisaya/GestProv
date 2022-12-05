using GestProv.Dominio._01_ENTIDADES;
using GestProv.InfraestructuraDatos._01_BASE_DE_DATOS;
using GestProv.Presentacion._01_VISTAS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestProv.Presentacion._02_PRESENTADORES
{
    public class CalificacionesPresentador
    {
        private GestProvContexto _contexto = new GestProvContexto();
        private CalificacionesVista _vista;


        public CalificacionesPresentador(CalificacionesVista vista)
        {
            _vista = vista;
        }

        public List<Proveedor> ObtenerProveedores()
        {
            return _contexto.ObtenerProveedoresActivos();
        }

        public void CalcularCalificacionProveedor(Proveedor proveedor)
        {
            
        }


    }
}
