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
    public class SucursalPresentador
    {
        private SucursalVista _vista;
        private GestProvContexto _contexto;
        public SucursalPresentador(SucursalVista vista, GestProvContexto contexto)
        {
            _vista = vista;
            _contexto = contexto;
        }

        public List<Pais> ObtenerPaises()
        {
            return _contexto.ObtenerPaises();
        }

        public List<Provincia> ObtenerProvincias(Pais pais)
        {
            return _contexto.ObtenerProvincias(pais);
        }

        public List<Ciudad> ObtenerCiudades(Provincia provincia)
        {
            return _contexto.ObtenerCiudades(provincia);
        }
        public void AltaSucursal(Sucursal sucursal)
        {
            _contexto.AltaSucursal(sucursal);
        }
        public void GuardarSucursal()
        {
            _contexto.GuardarCambios();
        }
        public void BajaSucursal(Sucursal sucursal)
        {
            _contexto.BajaSucursal(sucursal);
        }



    }
}
