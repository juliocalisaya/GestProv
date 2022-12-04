using GestProv.Dominio._01_ENTIDADES;
using GestProv.InfraestructuraDatos._01_BASE_DE_DATOS;
using GestProv.Presentacion._02_PRESENTADORES;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestProv.Presentacion._01_VISTAS
{
    public partial class ListadoSucursalesVista : Form
    {
        public ListadoSucursalesPresentador _presentador;
        public Proveedor _proveedor;
        public GestProvContexto _contexto;
        public ListadoSucursalesVista(Proveedor proveedor, GestProvContexto contexto)
        {
            InitializeComponent();
            _presentador = new ListadoSucursalesPresentador();
            _proveedor= proveedor;
            _contexto = contexto;
        }

        private void SucursalesVista_Load(object sender, EventArgs e)
        {
            ObtenerSucursales();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _presentador.NuevaSucursal(_proveedor, _contexto);
            ObtenerSucursales();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _presentador.BajaSucursal(sucursalBindingSource.Current as Sucursal, _contexto);
            ObtenerSucursales();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            _presentador.EditarSucursal(sucursalBindingSource.Current as Sucursal, _contexto);
            ObtenerSucursales();
        }

        private void ObtenerSucursales()
        {
            sucursalBindingSource.DataSource = _presentador.ObtenerSucursales(_proveedor, _contexto);
        }
    }
}
