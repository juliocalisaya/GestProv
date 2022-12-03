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
    public partial class ListadoTecnicosVista : Form
    {
        private ListadoTecnicosPresentador _presentador;
        public ListadoTecnicosVista()
        {
            InitializeComponent();
            _presentador = new ListadoTecnicosPresentador(this);
        }

        private void ListadoTecnicosVista_Load(object sender, EventArgs e)
        {
            ActualizarListado();
        }

        public void ActualizarListado()
        {
            tecnicoBindingSource.DataSource = _presentador.ObtenerLista();
            tecnicoBindingSource.ResetBindings(false);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _presentador.NuevoTecnico();
            ActualizarListado();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("ESTA SEGURO QUE DESA ELIMINAR EL TECNICO?", "ESTA SEGURO?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialog == DialogResult.Yes)
            {
                _presentador.BajaTecnico(tecnicoBindingSource.Current as Tecnico);
                ActualizarListado();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            _presentador.EditarTecnico(tecnicoBindingSource.Current as Tecnico);
            ActualizarListado();
        }
    }
}
