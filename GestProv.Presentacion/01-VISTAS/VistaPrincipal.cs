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
    public partial class VistaPrincipal : Form
    {
        private int _selectedId = -99;
        private Form ventanaActiva;

        public VistaPrincipal()
        {
            InitializeComponent();
        }

        private void comprasBTN_Click(object sender, EventArgs e)
        {
            if (_selectedId != 1)
            {
                _selectedId = 1;
                seleccionLB.Text = comprasBTN.Text;
                ListadoComprasVista vista = new ListadoComprasVista();
                AbrirVentana(vista);
            }
        }

        private void ProveedoresBTN_Click(object sender, EventArgs e)
        {
            if (_selectedId != 2)
            {
                _selectedId = 2;
                seleccionLB.Text = ProveedoresBTN.Text;
                ListadoProveedoresVista vista = new ListadoProveedoresVista();
                AbrirVentana(vista);
            }
        }

        private void tecnicosBTN_Click(object sender, EventArgs e)
        {
            if (_selectedId != 3)
            {
                _selectedId = 3;
                seleccionLB.Text = tecnicosBTN.Text;
                ListadoTecnicosVista vista = new ListadoTecnicosVista();
                AbrirVentana(vista);
            }
        }

        private void ordServicioBTN_Click(object sender, EventArgs e)
        {
            if (_selectedId != 4)
            {
                _selectedId = 4;
                seleccionLB.Text = ordServicioBTN.Text;
                ListadoOrdenesServiciosVista vista = new ListadoOrdenesServiciosVista();
                AbrirVentana(vista);
            }
        }

        private void historialBTN_Click(object sender, EventArgs e)
        {
            if (_selectedId != 5)
            {
                _selectedId = 5;
                seleccionLB.Text = historialBTN.Text;
                HistorialVista vista = new HistorialVista();
                AbrirVentana(vista);
            }
        }

        private void equipamientosBTN_Click(object sender, EventArgs e)
        {
            if (_selectedId != 6)
            {
                _selectedId = 6;
                seleccionLB.Text = equipamientosBTN.Text;
                EquipamientosVista vista = new EquipamientosVista();
                AbrirVentana(vista);
            }
        }

        private void calificacionesBTN_Click(object sender, EventArgs e)
        {
            if (_selectedId != 7)
            {
                _selectedId = 7;
                seleccionLB.Text = calificacionesBTN.Text;
                CalificacionesVista vista = new CalificacionesVista();
                AbrirVentana(vista);
            }
        }

        private void estadisticasBTN_Click(object sender, EventArgs e)
        {
            if (_selectedId != 8)
            {
                _selectedId = 8;
                seleccionLB.Text = estadisticasBTN.Text;
                EstadisticasVista vista = new EstadisticasVista();
                AbrirVentana(vista);
            }
        }


        private void AbrirVentana(Form ventana)
        {
            if (ventanaActiva != null)
            {
                ventanaActiva.Close();
            }

            ventanaActiva = ventana;
            ventana.TopLevel = false;
            ventana.FormBorderStyle = FormBorderStyle.None;
            ventana.Dock = DockStyle.Fill;
            //ventana.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            //ventana.AutoSize = true;
            this.seleccionPN.Controls.Add(ventana);
            this.seleccionPN.Tag = ventana;
            ventana.BringToFront();
            ventana.Show();
        }

        private void VistaPrincipal_Resize(object sender, EventArgs e)
        {
            if (ventanaActiva != null)
            {
                ventanaActiva.Size = seleccionPN.Size;

            }
        }
    }
}
