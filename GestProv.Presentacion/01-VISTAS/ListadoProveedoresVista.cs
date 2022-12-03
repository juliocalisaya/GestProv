using GestProv.Dominio._01_ENTIDADES;
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
    public partial class ListadoProveedoresVista : Form
    {
        private ListadoProveedoresPresentador _presentador;
        public ListadoProveedoresVista()
        {
            InitializeComponent();
            _presentador = new ListadoProveedoresPresentador(this);
        }

        private void ListadoProveedoresVista_Load(object sender, EventArgs e)
        {
            ActualizarListado();
        }

        public void ActualizarListado()
        {
            proveedorBindingSource.DataSource = _presentador.ObtenerLista();
            proveedorBindingSource.ResetBindings(false);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _presentador.NuevoProveedor();
            ActualizarListado();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("ESTA SEGURO QUE DESA ELIMINAR EL PROVEEDOR?","ESTA SEGURO?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialog == DialogResult.Yes)
            {
                _presentador.BajaProveedor(proveedorBindingSource.Current as Proveedor);
                ActualizarListado();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            _presentador.EditarProveedor(proveedorBindingSource.Current as Proveedor);
            ActualizarListado();
        }

        private void buttonSucursales_Click(object sender, EventArgs e)
        {
            _presentador.VerSucursales(proveedorBindingSource.Current as Proveedor);
        }
    }
}
