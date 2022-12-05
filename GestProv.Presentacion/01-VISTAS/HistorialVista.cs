using GestProv.Dominio._01_ENTIDADES;
using GestProv.InfraestructuraDatos._01_BASE_DE_DATOS;
using GestProv.Presentacion._02_PRESENTADORES;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
        private HistorialPresentador _presentador;
        private bool _oncreate = true;
        public HistorialVista()
        {
            InitializeComponent();
            _presentador = new HistorialPresentador();
            proveedorBindingSource.DataSource = CargarProveedores();
            
        }

        private void HistorialVista_Load(object sender, EventArgs e)
        {
            
        }

        private List<Proveedor> CargarProveedores()
        {
            return _presentador.ObtenerProveedores();
        }

        private void verFacturaBTN_Click(object sender, EventArgs e)
        {
            Process.Start(historialList.SelectedRows[0].Cells[5].Value.ToString());
        }

        private void ProveedoresList_SelectionChanged(object sender, EventArgs e)
        {
            if (!_oncreate)
            {
                compraBindingSource.DataSource = _presentador.ObtenerComprasProveedor(proveedorBindingSource.Current as Proveedor);
            }
            
        }

        private void HistorialVista_VisibleChanged(object sender, EventArgs e)
        {
            ProveedoresList.ClearSelection();

            historialList.Rows.Clear();

            _oncreate = false;
        }
    }
}
