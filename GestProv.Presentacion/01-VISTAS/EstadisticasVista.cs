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
    public partial class EstadisticasVista : Form
    {
        GestProvContexto _contexto;
        EstadisticasPresentador _presentador;
        public EstadisticasVista()
        {
            InitializeComponent();
            _contexto = new GestProvContexto();
            _presentador = new EstadisticasPresentador();
        }

        private void EstadisticasVista_Load(object sender, EventArgs e)
        {
            proveedorBindingSource.DataSource = CargarProveedores();
        }

        private List<Proveedor> CargarProveedores()
        {
            return _presentador.ObtenerProveedores(_contexto);
        }
    }
}
