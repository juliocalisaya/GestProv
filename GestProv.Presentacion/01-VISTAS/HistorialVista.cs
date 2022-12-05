using GestProv.Dominio._01_ENTIDADES;
using GestProv.InfraestructuraDatos._01_BASE_DE_DATOS;
using GestProv.Presentacion._02_PRESENTADORES;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestProv.Presentacion._01_VISTAS
{
    public partial class HistorialVista : Form
    {
        GestProvContexto _contexto;
        HistorialPresentador _presentador;
        public HistorialVista()
        {
            InitializeComponent();
            _contexto = new GestProvContexto();
            _presentador = new HistorialPresentador();
        }

        private void HistorialVista_Load(object sender, EventArgs e)
        {
            proveedorBindingSource.DataSource = CargarProveedores();
        }

        private List<Proveedor> CargarProveedores()
        {
            return _presentador.ObtenerProveedores(_contexto);
        }

        private void verFacturaBTN_Click(object sender, EventArgs e)
        {

        }
    }
}
