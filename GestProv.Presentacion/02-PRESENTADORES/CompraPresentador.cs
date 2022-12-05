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
    public class CompraPresentador
    {
        private ListadoComprasVista _vista;
        private GestProvContexto _contexto = new GestProvContexto();
        private List<Equipamiento> _equipamientos;
        private Compra _seleccion;
        private CompraVista _vistaCompra;
        private int _cantidadPreviaDeEquipamientos;
        public CompraPresentador(ListadoComprasVista vista)
        {
            _vista = vista;


        }

        public List<Compra> ObtenerListadoDeCompras()
        {
            return _contexto.ObtenerCompras();
        }

        public List<Categoria> ObtenerCategorias()
        {
            return _contexto.ObtenerCategorias();
        }

        public List<Proveedor> ObtenerProveedores()
        {
            return _contexto.ObtenerProveedoresActivos();
        }

        public List<Sucursal> ObtnenerSucursales(Proveedor proveedor)
        {
            if(proveedor != null)
            {
                return _contexto.ObtenerSucursales(proveedor);
            }
            return null;
        }

        public List<Equipamiento> ObtenerEquipamientos()
        {
            if(_seleccion == null)
            {
                _equipamientos = new List<Equipamiento>();
                return _equipamientos;
            }
            else
            {
                return _contexto.ObtenerEquipamientosDeCompra(_seleccion);
            }
        }



        public void AgregarCompra()
        {
            CompraVista agregar = new CompraVista(this);
            _seleccion = null;
            _vistaCompra = agregar;
            agregar.ShowDialog();
        }


        public void EditarCompra(Compra seleccion)
        {
            _seleccion = seleccion;
            CompraVista editar = new CompraVista(this,seleccion);
            _vistaCompra = editar;
            _cantidadPreviaDeEquipamientos = seleccion.Equipamientos.Count;
            editar.ShowDialog();
        }

        public void EliminarCompra(Compra objetivo)
        {
            _contexto.BajaCompra(objetivo);
        }

        public void GuardarCompra()
        {

            if (_seleccion == null)
            {
                Compra nuevaCompra = new Compra();
                nuevaCompra.Equipamientos = new List<Equipamiento>();

                nuevaCompra.FechaCompra = _vistaCompra.ObtenerFechaDeCompra();
                nuevaCompra.FechaEstimadaEntrega = _vistaCompra.ObtenerFechaDeEntregaEsperada();
                nuevaCompra.Monto = Double.Parse(_vistaCompra.ObtenerMontoCompra(), CultureInfo.InvariantCulture);
                nuevaCompra.Factura = _vistaCompra.ObtenerFactura();
                nuevaCompra.Proveedor = _vistaCompra.ObtenerProveedor();

                foreach (var item in _equipamientos)
                {
                    nuevaCompra.Equipamientos.Add(CrearEquipamiento(item,nuevaCompra));
                }

                _contexto.AltaCompra(nuevaCompra);


            }
            else
            {
                //if(_seleccion.Equipamientos.Count > _cantidadPreviaDeEquipamientos)
                //{
                //    for (int i = _cantidadPreviaDeEquipamientos; i < _seleccion.Equipamientos.Count; i++)
                //    {
                //        _seleccion.Equipamientos.Add(CrearEquipamiento(_seleccion.));
                //    }
                //}

                _contexto.SaveChanges();
            }
        }

        private Equipamiento CrearEquipamiento(Equipamiento nuevo , Compra compra)
        {
            Equipamiento auxiliar = new Equipamiento();
            auxiliar.Categoria = nuevo.Categoria;
            auxiliar.DiasGarantia = nuevo.DiasGarantia;
            auxiliar.Nombre = nuevo.Nombre;
            auxiliar.Compra = compra;

            Equipamiento agregado = _contexto.AltaEquipamiento(auxiliar);

            return agregado;
        }

    }
}
