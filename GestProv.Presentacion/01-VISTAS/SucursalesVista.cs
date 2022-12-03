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
    public partial class SucursalesVista : Form
    {
        public SucursalPresentador _presentador;
        public Proveedor _proveedor;
        public GestProvContexto _contexto;
        public SucursalesVista(Proveedor proveedor, GestProvContexto contexto)
        {
            InitializeComponent();
            _presentador = new SucursalPresentador();
            _proveedor= proveedor;
            _contexto = contexto;
        }

        private void SucursalesVista_Load(object sender, EventArgs e)
        {
            sucursalBindingSource.DataSource = _presentador.ObtenerSucursales(_proveedor, _contexto);
        }
    }
}
