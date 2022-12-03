using GestProv.Dominio._01_ENTIDADES;
using GestProv.InfraestructuraDatos._01_BASE_DE_DATOS;
using GestProv.Presentacion._01_VISTAS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace GestProv.Presentacion._02_PRESENTADORES
{
    public class ListadoProveedoresPresentador
    {
        private ListadoProveedoresVista _vista;
        private GestProvContexto _contexto = new GestProvContexto();

        public ListadoProveedoresPresentador(ListadoProveedoresVista vista)
        {
            _vista = vista;
        }

        public void NuevoProveedor()
        {
            ProveedorVista proveedorVista = new ProveedorVista(_contexto);
            proveedorVista.ShowDialog();
        }

        public List<Proveedor> ObtenerLista()
        {
            return _contexto.ObtenerProveedores();
        }

        public void BajaProveedor(Proveedor proveedor)
        {
            proveedor.Estado = false;
            _contexto.GuardarCambios();

        }
        public void EditarProveedor(Proveedor proveedor)
        {
            ProveedorVista proveedorVista = new ProveedorVista(proveedor, _contexto);
            proveedorVista.ShowDialog();
        }

        public void VerSucursales(Proveedor proveedor)
        {
            SucursalesVista sucursalesVista = new SucursalesVista(proveedor, _contexto);
            sucursalesVista.ShowDialog();
        }
    }
}
