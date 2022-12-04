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
    public class ListadoSucursalesPresentador
    {
        public List<Sucursal> ObtenerSucursales(Proveedor proveedor, GestProvContexto contexto)
        {
            return contexto.ObtenerSucursales(proveedor);
        }

        public void NuevaSucursal(Proveedor proveedor, GestProvContexto contexto)
        {
            SucursalVista sucursalVista = new SucursalVista(proveedor, contexto);
            sucursalVista.ShowDialog();
        }

        public void BajaSucursal(Sucursal sucursal, GestProvContexto contexto)
        {
            contexto.BajaSucursal(sucursal);
        }
        public void EditarSucursal(Sucursal sucursal, GestProvContexto contexto)
        {
            SucursalVista sucursalVista = new SucursalVista(sucursal, contexto);
            sucursalVista.ShowDialog();
        }
    }
}
