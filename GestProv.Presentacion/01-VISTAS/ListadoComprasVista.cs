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
        }

        private void agregarCompraBTN_Click(object sender, EventArgs e)
        {
            _presentador.AgregarCompra();
        }

        private void eliminarCompraBTN_Click(object sender, EventArgs e)
        {
            _presentador.EliminarCompra();
        }

        private void editarCompraBTN_Click(object sender, EventArgs e)
        {
            _presentador.EditarCompra();
        }
    }
}
