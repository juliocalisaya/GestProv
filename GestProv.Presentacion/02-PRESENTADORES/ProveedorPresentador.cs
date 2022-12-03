using GestProv.Dominio._01_ENTIDADES;
using GestProv.InfraestructuraDatos._01_BASE_DE_DATOS;
using GestProv.Presentacion._01_VISTAS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestProv.Presentacion._02_PRESENTADORES
{
    public class ProveedorPresentador
    {
        private ProveedorVista _vista;
        private GestProvContexto _contexto;
        public ProveedorPresentador(ProveedorVista vista, GestProvContexto contexto)
        {
            _vista = vista;
            _contexto = contexto;
        }

        public void AltaProveedor(Proveedor proveedor)
        {
            _contexto.AltaProveedor(proveedor);
        }
        public void GuardarProveedor()
        {
            _contexto.GuardarCambios();
        }


    }
}
