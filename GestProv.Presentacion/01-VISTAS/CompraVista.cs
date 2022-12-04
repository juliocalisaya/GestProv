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
    public partial class CompraVista : Form
    {
        private CompraPresentador _presentador;
        private bool _editar;
        public CompraVista(CompraPresentador presentador,bool editar)
        {
            InitializeComponent();

            _presentador = presentador;
            _editar = editar;
            if (editar)
            {
                fechaRealEntregaLB.Visible = true;
                fechaRealEntregaTB.Visible = true;
                CargarCompra();
            }



        }


        private void CargarCompra()
        {

        }

        private void seleccionarFacturaBTN_Click(object sender, EventArgs e)
        {
            OpenFileDialog seleccion = new OpenFileDialog();

            if (seleccion.ShowDialog() == DialogResult.OK)
            {
                facturaPathTB.Text = seleccion.FileName;
            }

        }

        private void cancelarBTN_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void limpiarBTN_Click(object sender, EventArgs e)
        {
            if (!_editar) 
            {
                proveedorCB.SelectedIndex = 0;
                fechaCompraValueTB.Text = "dd-mm-aaaa";
                fechaEsperadaEntregaTB.Text = "dd-mm-aaaa";
                fechaRealEntregaTB.Text = "dd-mm-aaaa";
                facturaPathTB.Text = "";
                montoValueTB.Text = "$0";
                comprasList.Rows.Clear();
            }
            else
            {
                CargarCompra();
            }
            
        }
    }
}
