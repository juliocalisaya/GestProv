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
    public partial class ListadoOrdenesServiciosVista : Form
    {
        private ListadoOrdenesServicioPresentador _presentador;
        public ListadoOrdenesServiciosVista()
        {
            InitializeComponent();
            _presentador = new ListadoOrdenesServicioPresentador();
            ObtenerOS();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _presentador.AltaOrdenServicio();
            ObtenerOS();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _presentador.BajaOrdenServicio(ordenDeServicioBindingSource.Current as OrdenDeServicio);
            ObtenerOS();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            _presentador.EditarOrdenServicio(ordenDeServicioBindingSource.Current as OrdenDeServicio);
            ObtenerOS();
        }

        private void ObtenerOS()
        {
            ordenDeServicioBindingSource.DataSource = _presentador.ObtenerOS();
        }
    }
}
