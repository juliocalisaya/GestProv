using GestProv.Dominio._01_ENTIDADES;
using GestProv.InfraestructuraDatos._01_BASE_DE_DATOS;
using GestProv.Presentacion._02_PRESENTADORES;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestProv.Presentacion._01_VISTAS
{
    public partial class EstadisticasVista : Form
    {
        GestProvContexto _contexto;
        EstadisticasPresentador _presentador;
        List<Compra> Compras;
        public EstadisticasVista()
        {
            InitializeComponent();
            _contexto = new GestProvContexto();
            _presentador = new EstadisticasPresentador();
        }

        private void EstadisticasVista_Load(object sender, EventArgs e)
        {
            proveedorBindingSource.DataSource = CargarProveedores();
            anualRB.Checked = true;
            LimpiarCampos();
        }

        private List<Proveedor> CargarProveedores()
        {
            return _presentador.ObtenerProveedores(_contexto);
        }

        private void mensualRB_CheckedChanged(object sender, EventArgs e)
        {
            ColocarMeses();
            mesesPN.Visible = true;
            LimpiarCampos();
        }

        private void anualRB_CheckedChanged(object sender, EventArgs e)
        {
            mesesPN.Visible = false;
        }

        private void ColocarMeses()
        {
            CultureInfo ci = new CultureInfo("es-ES");
            DateTime fecha = DateTime.Now;
            mes12BTN.Text = fecha.ToString("MMMM", ci).ToUpper() + "-" + fecha.ToString("yy", ci);
            mes11BTN.Text = fecha.AddMonths(-1).ToString("MMMM", ci).ToUpper() + "-" + fecha.AddMonths(-1).ToString("yy", ci);
            mes10BTN.Text = fecha.AddMonths(-2).ToString("MMMM", ci).ToUpper() + "-" + fecha.AddMonths(-2).ToString("yy", ci);
            mes9BTN.Text = fecha.AddMonths(-3).ToString("MMMM", ci).ToUpper() + "-" + fecha.AddMonths(-3).ToString("yy", ci);
            mes8BTN.Text = fecha.AddMonths(-4).ToString("MMMM", ci).ToUpper() + "-" + fecha.AddMonths(-4).ToString("yy", ci);
            mes7BTN.Text = fecha.AddMonths(-5).ToString("MMMM", ci).ToUpper() + "-" + fecha.AddMonths(-5).ToString("yy", ci);
            mes6BTN.Text = fecha.AddMonths(-6).ToString("MMMM", ci).ToUpper() + "-" + fecha.AddMonths(-6).ToString("yy", ci);
            mes5BTN.Text = fecha.AddMonths(-7).ToString("MMMM", ci).ToUpper() + "-" + fecha.AddMonths(-7).ToString("yy", ci);
            mes4BTN.Text = fecha.AddMonths(-8).ToString("MMMM", ci).ToUpper() + "-" + fecha.AddMonths(-8).ToString("yy", ci);
            mes3BTN.Text = fecha.AddMonths(-9).ToString("MMMM", ci).ToUpper() + "-" + fecha.AddMonths(-9).ToString("yy", ci);
            mes2BTN.Text = fecha.AddMonths(-10).ToString("MMMM", ci).ToUpper() + "-" + fecha.AddMonths(-10).ToString("yy", ci);
            mes1BTN.Text = fecha.AddMonths(-11).ToString("MMMM", ci).ToUpper() + "-" + fecha.AddMonths(-11).ToString("yy", ci);
        }

        private void ProveedoresList_SelectionChanged(object sender, EventArgs e)
        {
            Compras = ObtenerDatos();
            comprasValueLB.Text = Compras.Count().ToString();
            if (anualRB.Checked)
            {
                totalValueLB.Text = "$ "+ObtenerTotalCompras(Compras).ToString("0.00");
            }
            else
            {

            }
        }

        private List<Compra> ObtenerDatos()
        {
            return _presentador.ObtenerComprasProveedor(proveedorBindingSource.Current as Proveedor, _contexto);
        }

        private double ObtenerTotalCompras(List<Compra> compras)
        {
            double total = 0;
            foreach(Compra compra in compras)
            {
                total = total + compra.Monto;
            }
            return total;
        }

        private void LimpiarCampos()
        {
            comprasValueLB.Text = string.Empty;
            maximoValueLB.Text = string.Empty;
            minimoValueLB.Text = string.Empty;
            totalValueLB.Text = string.Empty;
            retrasoValueLB.Text = string.Empty;
        }
    }
}
