using GestProv.Dominio._01_ENTIDADES;
using GestProv.InfraestructuraDatos._01_BASE_DE_DATOS;
using GestProv.Presentacion._01_VISTAS;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestProv.Presentacion._02_PRESENTADORES
{
    public class CalificacionesPresentador
    {
        private GestProvContexto _contexto = new GestProvContexto();
        private CalificacionesVista _vista;
        private List<Compra> _compras;
        private List<OrdenDeServicio> _ordenesDeServicio;

        private int _cantidadDeCompras = 0;
        private int _entregasConRetraso = 0;
        private double _penalizacionCompras = 0.0d;
        private int _cantidadDeOrdenesDeServicio = 0;
        private int _ordenesConRetraso = 0;
        private double _penalizacionServicios = 0.0d;
        private double _Calificacion = 100.0;

        private Dictionary<int, Color> _codigoColores = new Dictionary<int, Color>
        {
            { 61,Color.FromArgb(204,0,0) },
            { 71,Color.FromArgb(255,128,0) },
            { 81,Color.FromArgb(0,0,153) },
            { 91,Color.FromArgb(0,204,0) },
            { 101,Color.DarkGoldenrod }
        };

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
            _compras = new List<Compra>();
            _ordenesDeServicio = new List<OrdenDeServicio>();
            ReiniciarVariables();
            ObtenerCompras(proveedor);
            _cantidadDeCompras = _compras.Count;
            ContarEntregasConRetraso();
            ObtenerOrdenesDeServicio(proveedor);
            _cantidadDeOrdenesDeServicio = _ordenesDeServicio.Count;
            ContarServiciosConRetraso();

            _Calificacion = CalcularCalificacion();

            Color colorCalificacion = BuscarColor();
            //calificacion
            _vista.CargarCalificacion(Math.Round(_Calificacion).ToString(),colorCalificacion);

            //datos compras
            _vista.CargarCantidadDeCompras(_cantidadDeCompras.ToString());
            _vista.CargarCantidadDeDemoras(_entregasConRetraso.ToString());
            _vista.CargarPenalizacionCompras(_penalizacionCompras.ToString("G0") + " Puntos");

            //datos servicios
            _vista.CargarCantidadOrdenesDeServicio(_cantidadDeOrdenesDeServicio.ToString());
            _vista.CargarCantidadOrdenesDeServicioRetrasadas(_ordenesConRetraso.ToString());
            _vista.CargarPenalizacionOrdenesDeServicio(_penalizacionServicios.ToString("G0") + " Puntos");
        }

        private void ReiniciarVariables()
        {
            _cantidadDeCompras = 0;
            _entregasConRetraso = 0;
            _penalizacionCompras = 0.0d;
            _cantidadDeOrdenesDeServicio = 0;
            _ordenesConRetraso = 0;
            _penalizacionServicios = 0.0d;
            _Calificacion = 100.0d;
        }

        private void ObtenerCompras(Proveedor proveedor)
        {
            DateTime fechaActual = DateTime.Now;

            for (int i = 0; i < 12; i++)
            {
                string busqueda = fechaActual.ToString("MM-yyyy");
                List<Compra> temporal = _contexto.ObtenerComprasMes(busqueda).Where(x => x.Proveedor.Equals(proveedor)).ToList();
                foreach (var item in temporal)
                {
                    _compras.Add(item);
                }
                fechaActual = fechaActual.AddMonths(-1);
            }
        }

        private void ContarEntregasConRetraso()
        {
            foreach (var item in _compras)
            {
                if(item.FechaRealEntrega != null)
                {
                    DateTime fechaEsperada = DateTime.ParseExact(item.FechaEstimadaEntrega, "dd-MM-yyyy", CultureInfo.InvariantCulture);
                    DateTime fechaReal = DateTime.ParseExact(item.FechaRealEntrega, "dd-MM-yyyy", CultureInfo.InvariantCulture);

                    if (fechaReal.CompareTo(fechaEsperada) > 0)
                    {
                        _entregasConRetraso++;
                    }
                }
                
            }
        }



        private double CalcularCalificacion()
        {

            if(_cantidadDeCompras > 0)
            {
                _penalizacionCompras = 40.0d * (Convert.ToDouble(_entregasConRetraso) / Convert.ToDouble(_cantidadDeCompras));
            }

            if (_cantidadDeOrdenesDeServicio > 0)
            {
                _penalizacionServicios = 60.0d * (Convert.ToDouble(_ordenesConRetraso) / Convert.ToDouble(_cantidadDeOrdenesDeServicio));
            }
            


            return _Calificacion - _penalizacionCompras - _penalizacionServicios ;
        }

        private void ObtenerOrdenesDeServicio(Proveedor proveedor)
        {
            DateTime fechaActual = DateTime.Now;

            for (int i = 0; i < 12; i++)
            {
                string busqueda = fechaActual.ToString("MM-yyyy");
                List<OrdenDeServicio> temporal = _contexto.ObtenerOrdenesMes(busqueda).Where(x => x.Tecnico.Proveedor.Equals(proveedor)).ToList();
                foreach (var item in temporal)
                {
                    _ordenesDeServicio.Add(item);
                }
                fechaActual = fechaActual.AddMonths(-1);
            }
        }

        private void ContarServiciosConRetraso()
        {
            foreach (var item in _ordenesDeServicio)
            {
                if (item.FechaRealResolucion != null)
                {
                    DateTime fechaEsperada = DateTime.ParseExact(item.FechaEstimadaResolucion, "dd-MM-yyyy", CultureInfo.InvariantCulture);
                    DateTime fechaReal = DateTime.ParseExact(item.FechaRealResolucion, "dd-MM-yyyy", CultureInfo.InvariantCulture);

                    if (fechaReal.CompareTo(fechaEsperada) > 0)
                    {
                        _ordenesConRetraso++;
                    }
                }                

            }
        }

        private Color BuscarColor()
        {
            int inferior = 0;
            foreach (var item in _codigoColores)
            {
                if (_Calificacion >= inferior && _Calificacion < item.Key) return item.Value;
            }
            return Color.Black;
        }

    }
}
