using GestProv.Dominio._01_ENTIDADES;
using GestProv.InfraestructuraDatos._01_BASE_DE_DATOS;
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
    public partial class CalificacionesVista : Form
    {
        CalificacionesPresentador _presentador;
        private bool _oncreate = true;
        public CalificacionesVista()
        {
            InitializeComponent();
            _presentador = new CalificacionesPresentador(this);
        }

        private void CalificacionesVista_Load(object sender, EventArgs e)
        {
            proveedorBindingSource.DataSource = CargarProveedores();
        }

        private List<Proveedor> CargarProveedores()
        {
            return _presentador.ObtenerProveedores();
        }

        private void CalificacionesVista_VisibleChanged(object sender, EventArgs e)
        {
            ProveedoresList.ClearSelection();
            _oncreate = false;
        }

        private void CalificacionesVista_FormClosing(object sender, FormClosingEventArgs e)
        {
            _oncreate = true;
        }

        private void ProveedoresList_SelectionChanged(object sender, EventArgs e)
        {
            if (!_oncreate)
            {
                _presentador.CalcularCalificacionProveedor(proveedorBindingSource.Current as Proveedor);
            }
        }

        public void CargarCalificacion(string calificacion, Color colorTexto)
        {
            calificacionValueLB.Text = calificacion;
            calificacionValueLB.ForeColor = colorTexto;
        }

        public void CargarCantidadDeCompras(string compras)
        {
            comprasValueLB.Text = compras;
        }

        public void CargarCantidadDeDemoras(string demoras)
        {
            comprasRetrasoValueLB.Text = demoras;
        }

        public void CargarPenalizacionCompras(string penalizacion)
        {
            comprasPenalizacionValueLB.Text = penalizacion;
        }

        public void CargarCantidadOrdenesDeServicio(string ordenes)
        {
            cantidadOrdenesValueLB.Text = ordenes;
        }

        public void CargarCantidadOrdenesDeServicioRetrasadas(string demoras)
        {
            demoraOrdenesValueLB.Text = demoras;
        }

        public void CargarPenalizacionOrdenesDeServicio(string penalizacion)
        {
            ordenesPenalizacionValueLB.Text = penalizacion;
        }
    }
}
