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
    public class CompraPresentador
    {
        private ListadoComprasVista _vista;
        private GestProvContexto _contexto = new GestProvContexto();
        private List<Equipamiento> _equipamientos = new List<Equipamiento>();
        private Compra _seleccion;

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
            return _contexto.ObtenerSucursales(proveedor);
        }

        public List<Equipamiento> ObtenerEquipamientos()
        {
            return _equipamientos;
        }



        public void AgregarCompra()
        {
            CompraVista agregar = new CompraVista(this);
            _seleccion = null;
            _equipamientos = new List<Equipamiento>();
            agregar.ShowDialog();
        }


        public void EditarCompra(Compra seleccion)
        {
            _seleccion = seleccion;
            _equipamientos = seleccion.Equipamientos;
            CompraVista editar = new CompraVista(this,seleccion);
            editar.ShowDialog();
        }

        public void EliminarCompra(Compra objetivo)
        {
            _contexto.BajaCompra(objetivo);
        }

        public void GuardarCompra()
        {




            if (_seleccion != null)
            {

            }
            else
            {

            }
        }



    }
}
