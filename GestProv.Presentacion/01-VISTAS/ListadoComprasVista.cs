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
    public partial class ListadoComprasVista : Form
    {
        private CompraPresentador _presentador;
        public ListadoComprasVista()
        {
            InitializeComponent();
            _presentador = new CompraPresentador(this);
            ActualizarListado();
        }

        private void ActualizarListado()
        {
            comprasBindingSource.DataSource = _presentador.ObtenerListadoDeCompras();
            comprasBindingSource.ResetBindings(false);
        }



        private void agregarCompraBTN_Click(object sender, EventArgs e)
        {
            _presentador.AgregarCompra();
            ActualizarListado();
        }

        private void eliminarCompraBTN_Click(object sender, EventArgs e)
        {
            _presentador.EliminarCompra(comprasBindingSource.Current as Compra);
            ActualizarListado();
        }

        private void editarCompraBTN_Click(object sender, EventArgs e)
        {
            if(comprasList.SelectedRows.Count > 0)
            {
                _presentador.EditarCompra(comprasBindingSource.Current as Compra);
                ActualizarListado();
            }
            else
            {
                MessageBox.Show("DEBE SELECCIONAR UNA COMPRA QUE EDITAR", "ERROR", MessageBoxButtons.OK);
            }
            
        }



    }
}
