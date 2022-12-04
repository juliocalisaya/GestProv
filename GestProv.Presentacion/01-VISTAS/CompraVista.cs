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
    public partial class CompraVista : Form
    {
        private CompraPresentador _presentador;
        public CompraVista(CompraPresentador presentador)
        {
            InitializeComponent();

            _presentador = presentador;
            equipamientoBindingSource.DataSource = _presentador.ObtenerEquipamientos();
            categoriasBindingSource.DataSource = _presentador.ObtenerCategorias();
            proveedoresBindingSource.DataSource = _presentador.ObtenerProveedores();
            sucursalBindingSource.DataSource = _presentador.ObtnenerSucursales(proveedoresBindingSource.Current as Proveedor);
        }

        public CompraVista(CompraPresentador presentador, Compra seleccion)
        {
            InitializeComponent();

            _presentador = presentador;
            equipamientoBindingSource.DataSource = _presentador.ObtenerEquipamientos();

            
            proveedorCB.SelectedIndex = 0;
            fechaCompraValueTB.Text = seleccion.FechaCompra;
            fechaEsperadaEntregaTB.Text = seleccion.FechaEstimadaEntrega;
            fechaRealEntregaTB.Text = seleccion.FechaRealEntrega;
            facturaPathTB.Text = seleccion.Factura;
            montoValueTB.Text = $"${seleccion.Monto.ToString("N")}";

            limpiarBTN.Visible = false;
            fechaRealEntregaLB.Visible = true;
            fechaRealEntregaTB.Visible = true;
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

                proveedorCB.SelectedIndex = 0;
                fechaCompraValueTB.Text = "dd-mm-aaaa";
                fechaEsperadaEntregaTB.Text = "dd-mm-aaaa";
                fechaRealEntregaTB.Text = "dd-mm-aaaa";
                facturaPathTB.Text = "";
                montoValueTB.Text = "$0";
                comprasList.Rows.Clear();

        }

        private void proveedorCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            sucursalBindingSource.DataSource = _presentador.ObtnenerSucursales(proveedoresBindingSource.Current as Proveedor);
        }

        private void guardarBTN_Click(object sender, EventArgs e)
        {
            
        }

        private void Guardar()
        {
            _presentador.GuardarCompra();
            MessageBox.Show("COMPRA GUARDADA CORRECTAMENTE", "GUARDADO CORRECTO", MessageBoxButtons.OK);
            this.Close();
        }

        //private bool validarCampos()
        //{
        //    if (fechaCompraValueTB.Text == null || fechaCompraValueTB.Text == string.Empty )
        //    {
        //        MessageBox.Show("DEBE INGRESAR NOMBRE DEL TECNICO", "DATO FALTANTE", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        return false;
        //    }
        //    else
        //    {
        //        if (textApellido.Text == null || textApellido.Text == string.Empty)
        //        {
        //            MessageBox.Show("DEBE INGRESAR APELLIDO DEL TECNICO", "DATO FALTANTE", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //            return false;
        //        }
        //        else
        //        {
        //            if (txtDNI.Text == null || txtDNI.Text == string.Empty)
        //            {
        //                MessageBox.Show("DEBE INGRESAR DNI DEL TECNICO", "DATO FALTANTE", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //                return false;
        //            }
        //            else
        //            {
        //                if (textMail.Text == null || textMail.Text == string.Empty)
        //                {
        //                    MessageBox.Show("DEBE INGRESAR MAIL DEL TECNICO", "DATO FALTANTE", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //                    return false;
        //                }
        //                else
        //                {
        //                    if (textTelefono.Text == null || textTelefono.Text == string.Empty)
        //                    {
        //                        MessageBox.Show("DEBE INGRESAR TELEFONO DEL TECNICO", "DATO FALTANTE", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //                        return false;
        //                    }
        //                    else
        //                    {
        //                        if (comboProveedores.Text == null || comboProveedores.Text == string.Empty)
        //                        {
        //                            MessageBox.Show("DEBE SELECCIONAR UN PROVEEDOR ASOCIADO AL TECNICO", "DATO FALTANTE", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //                            return false;
        //                        }
        //                        else
        //                        {
        //                            return true;
        //                        }
        //                    }
        //                }
        //            }
        //        }
        //    }
        //}





    }
}
