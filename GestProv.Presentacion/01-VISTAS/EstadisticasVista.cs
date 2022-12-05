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
        DateTime fecha = DateTime.Now;
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
            ActualizarVista(0);
        }

        private void ColocarMeses()
        {
            CultureInfo ci = new CultureInfo("es-ES");
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
            ActualizarVista(0);
        }

        private int ObtenerRetraso(List<Compra> compras)
        {
            int retraso = 0;
            foreach(Compra compra in compras)
            {
                int _auxRestraso = Convert.ToDateTime(compra.FechaRealEntrega).Subtract(Convert.ToDateTime(compra.FechaEstimadaEntrega)).Days;
                if (_auxRestraso > 0)
                {
                    retraso = retraso + _auxRestraso;
                }
                
            }
            return retraso;
        }

        private List<Compra> ObtenerDatos()
        {
            return _presentador.ObtenerComprasProveedor(proveedorBindingSource.Current as Proveedor, _contexto);
        }

        private void LimpiarCampos()
        {
            comprasValueLB.Text = string.Empty;
            maximoValueLB.Text = string.Empty;
            minimoValueLB.Text = string.Empty;
            totalValueLB.Text = string.Empty;
            retrasoValueLB.Text = string.Empty;
        }

        private void ActualizarVista(int meses)
        {
            if (anualRB.Checked)
            {
                if (Compras.Count() > 0)
                {
                    CargarDatos(Compras);
                }
                else
                {
                    LimpiarCampos();
                }
            }
            else
            {
                if (mensualRB.Checked)
                {
                    LimpiarCampos();
                    List<Compra> _aux = new List<Compra>();
                    foreach (Compra compra in Compras)
                    {
                        if (Convert.ToDateTime(compra.FechaCompra).Month == fecha.AddMonths(-meses).Month)
                        {
                            _aux.Add(compra);
                        }
                    }
                    if (_aux.Count > 0)
                    {
                        CargarDatos(_aux);
                    }
                }
                else
                {
                    LimpiarCampos();
                }
                    
            }
        }

        private void CargarDatos(List<Compra> compras)
        {
            comprasValueLB.Text = compras.Count().ToString();
            minimoValueLB.Text = "$ " + compras.Min(x => x.Monto).ToString("0.00");
            maximoValueLB.Text = "$ " + compras.Max(x => x.Monto).ToString("0.00");
            totalValueLB.Text = "$ " + compras.Sum(x => x.Monto).ToString("0.00");
            retrasoValueLB.Text = ObtenerRetraso(compras).ToString() + " Dias";
        }


        private void mes1BTN_Click(object sender, EventArgs e)
        {
            ActualizarVista(11);
        }

        private void mes2BTN_Click(object sender, EventArgs e)
        {
            ActualizarVista(10);
        }

        private void mes3BTN_Click(object sender, EventArgs e)
        {
            ActualizarVista(9);
        }

        private void mes4BTN_Click(object sender, EventArgs e)
        {
            ActualizarVista(8);
        }

        private void mes5BTN_Click(object sender, EventArgs e)
        {
            ActualizarVista(7);
        }

        private void mes6BTN_Click(object sender, EventArgs e)
        {
            ActualizarVista(6);
        }

        private void mes7BTN_Click(object sender, EventArgs e)
        {
            ActualizarVista(5);
        }

        private void mes8BTN_Click(object sender, EventArgs e)
        {
            ActualizarVista(4);
        }

        private void mes9BTN_Click(object sender, EventArgs e)
        {
            ActualizarVista(3);
        }

        private void mes10BTN_Click(object sender, EventArgs e)
        {
            ActualizarVista(2);
        }

        private void mes11BTN_Click(object sender, EventArgs e)
        {
            ActualizarVista(1);
        }

        private void mes12BTN_Click(object sender, EventArgs e)
        {
            ActualizarVista(0);
        }
    }
}
