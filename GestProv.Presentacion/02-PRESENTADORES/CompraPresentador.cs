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
        private List<Categoria> _categorias;


        public CompraPresentador(ListadoComprasVista vista)
        {
            _vista = vista;
            _categorias = _contexto.ObtenerCategorias();

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

        private void CargarEquipamientos()
        {
            foreach (var item in _seleccion.Equipamientos)
            {
                _vistaCompra.CargarEquipamiento(item.Id.ToString(),item.Nombre,item.DiasGarantia.ToString(),item.Categoria);
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
            _equipamientos = new List<Equipamiento>();
            CargarEquipamientos();
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

                string cadena = _vistaCompra.ObtenerMontoCompra();


                nuevaCompra.Monto = Double.Parse(cadena.Substring(1,cadena.Length-1), CultureInfo.InvariantCulture);
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

                _seleccion.FechaCompra = _vistaCompra.ObtenerFechaDeCompra();
                _seleccion.FechaEstimadaEntrega = _vistaCompra.ObtenerFechaDeEntregaEsperada();

                string cadena = _vistaCompra.ObtenerMontoCompra();


                _seleccion.Monto = Double.Parse(cadena.Substring(1, cadena.Length - 1), CultureInfo.InvariantCulture);
                _seleccion.Factura = _vistaCompra.ObtenerFactura();
                _seleccion.Proveedor = _vistaCompra.ObtenerProveedor();

                foreach (var item in _equipamientos)
                {
                    _seleccion.Equipamientos.Add(CrearEquipamiento(item, _seleccion));
                }

                _contexto.SaveChanges();
            }
        }

        public void GuardarEquipamiento(string nombre, string garantia, string categoria)
        {

            Equipamiento auxiliar = new Equipamiento();
            auxiliar.Nombre = nombre;
            auxiliar.DiasGarantia = long.Parse(garantia);
            auxiliar.Categoria = _categorias.Find(x => x.Nombre.Equals(categoria));
            _equipamientos.Add(auxiliar);
            
        }

        public void ActualizarEquipamiento(string id,string nombre, string garantia, string categoria)
        {
            
            if(id != "" && id != string.Empty && id != null)
            {
                Equipamiento auxiliar = _seleccion.Equipamientos.Find(x => x.Id == long.Parse(id));
                auxiliar.Nombre = nombre;
                auxiliar.DiasGarantia = long.Parse(garantia);
                auxiliar.Categoria = _categorias.Find(x => x.Nombre.Equals(categoria));
            }
            else
            {
                Equipamiento temporal = new Equipamiento();
                temporal.Nombre = nombre;
                temporal.DiasGarantia = long.Parse(garantia);
                temporal.Categoria = _categorias.Find(x => x.Nombre.Equals(categoria));
                _equipamientos.Add(temporal);
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
