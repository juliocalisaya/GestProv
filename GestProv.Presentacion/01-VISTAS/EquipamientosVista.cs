using GestProv.Presentacion._02_PRESENTADORES;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestProv.Presentacion._01_VISTAS
{
    public partial class EquipamientosVista : Form
    {
        private EquipamientosPresentador _presentador;
        public EquipamientosVista()
        {
            InitializeComponent();
            _presentador = new EquipamientosPresentador(this);
            _presentador.BuscarListadoCompletoEquipamiento();

        }

 
        private void verFacturaBTN_Click(object sender, EventArgs e)
        {
            Process.Start(equipamientosList.SelectedRows[0].Cells[3].Value.ToString());
        }

        private void listadoCompletoRB_CheckedChanged(object sender, EventArgs e)
        {
            if (listadoCompletoRB.Checked)
            {
                _presentador.BuscarListadoCompletoEquipamiento();
            }
            
        }

        private void fueraDeGarantiaRB_CheckedChanged(object sender, EventArgs e)
        {
            if (fueraDeGarantiaRB.Checked)
            {
                _presentador.BuscarEquipamientoSinGarantia();
            }
        }

        public void CargarListado(string descripcion, string fechaCompra,string vencimientoGarantia,string facturaPath,string categoriaEquipamiento)
        {
            equipamientosList.Rows.Add(descripcion,fechaCompra,vencimientoGarantia,facturaPath,categoriaEquipamiento);
        }
        public void LimpiarListado()
        {
            equipamientosList.Rows.Clear();
        }
    }
}
