using GestProv.Presentacion._01_VISTAS;
using GestProv.Presentacion._02_PRESENTADORES;
using GestProv.Presentacion._03_INTERFACES;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestProv.Presentacion
{
    public partial class PrincipalVista : Form, IPrincipalVista
    {
        private PrincipalPresentador _presentador;
        public PrincipalVista()
        {
            InitializeComponent();
            _presentador = new PrincipalPresentador(this);
        }

        private void listadoDeComprasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _presentador.ListarCompras();
        }

        private void listadoDeOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _presentador.ListarOS();
        }

        private void listadoDeProveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _presentador.ListarProveedores();
        }

        private void listadoDeTécnicosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            _presentador.ListarTecnicos();
        }
    }

}
