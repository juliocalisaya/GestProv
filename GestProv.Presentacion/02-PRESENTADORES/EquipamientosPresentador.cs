using GestProv.Dominio._01_ENTIDADES;
using GestProv.InfraestructuraDatos._01_BASE_DE_DATOS;
using GestProv.Presentacion._01_VISTAS;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestProv.Presentacion._02_PRESENTADORES
{
    public class EquipamientosPresentador
    {
        private GestProvContexto _contexto = new GestProvContexto();
        private EquipamientosVista _vista;
        private List<Equipamiento> _listado;
        public EquipamientosPresentador(EquipamientosVista vista)
        {
            _vista = vista;
        }


        public void BuscarListadoCompletoEquipamiento()
        {
            _vista.LimpiarListado();
            _listado = _contexto.ObtenerEquipamientos();

            foreach (var item in _listado)
            {
                DateTime fechaCompra = DateTime.ParseExact(item.Compra.FechaCompra,"dd-mm-yyyy", CultureInfo.InvariantCulture);
                DateTime vtoGarantia = fechaCompra.AddDays((double)item.DiasGarantia);
                _vista.CargarListado(item.Nombre,item.Compra.FechaCompra,vtoGarantia.ToString("dd-mm-yyyy"),item.Compra.Factura,item.Categoria.Nombre);
            }

        }


        public void BuscarEquipamientoSinGarantia()
        {
            _vista.LimpiarListado();
            foreach (var item in _listado)
            {
                DateTime fechaCompra = DateTime.ParseExact(item.Compra.FechaCompra, "dd-mm-yyyy", CultureInfo.InvariantCulture);
                DateTime vtoGarantia = fechaCompra.AddDays((double)item.DiasGarantia);
                if (vtoGarantia.CompareTo(DateTime.Now) < 0)
                {
                    _vista.CargarListado(item.Nombre, item.Compra.FechaCompra, vtoGarantia.ToString("dd-mm-yyyy"), item.Compra.Factura,item.Categoria.Nombre);
                }

                
            }



        }




    }
}
