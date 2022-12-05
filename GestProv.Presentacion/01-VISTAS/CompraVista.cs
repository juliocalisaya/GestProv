using GestProv.Dominio._01_ENTIDADES;
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
    public partial class CompraVista : Form
    {
        private CompraPresentador _presentador;
        private bool _edicion = false;
        public CompraVista(CompraPresentador presentador)
        {
            InitializeComponent();

            _presentador = presentador;
            categoriasBindingSource.DataSource = _presentador.ObtenerCategorias();
            proveedoresBindingSource.DataSource = _presentador.ObtenerProveedores();
        }

        public CompraVista(CompraPresentador presentador, Compra seleccion)
        {
            InitializeComponent();

            _presentador = presentador;
            categoriasBindingSource.DataSource = _presentador.ObtenerCategorias();
            proveedoresBindingSource.DataSource = _presentador.ObtenerProveedores();
            proveedorCB.SelectedIndex = 0;
            fechaCompraValueTB.Text = seleccion.FechaCompra;
            fechaEsperadaEntregaTB.Text = seleccion.FechaEstimadaEntrega;
            fechaRealEntregaTB.Text = seleccion.FechaRealEntrega;
            facturaPathTB.Text = seleccion.Factura;
            montoValueTB.Text = $"${seleccion.Monto.ToString()}";

            limpiarBTN.Visible = false;
            fechaRealEntregaLB.Visible = true;
            fechaRealEntregaTB.Visible = true;
            _edicion = true;
        }


        public void CargarEquipamiento(string id , string nombre,string garantia, Categoria categoria)
        {
            comprasList.Rows.Add(id, nombre, garantia,categoria.Nombre);
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

        private void guardarBTN_Click(object sender, EventArgs e)
        {
            if (validarCampos())
            {
                Guardar();
            }
        }

        private void Guardar()
        {
            if (_edicion)
            {
                ActualizarEquipamiento()
            }
            else
            {
                GuardarEquipamiento();
            }
            
            
            _presentador.GuardarCompra();
            MessageBox.Show("COMPRA GUARDADA CORRECTAMENTE", "GUARDADO CORRECTO", MessageBoxButtons.OK);
            this.Close();
        }

        private void GuardarEquipamiento()
        {
            for (int i = 0; i < comprasList.Rows.Count-1; i++)
            {
                _presentador.GuardarEquipamiento(comprasList.Rows[i].Cells[1].Value.ToString(), comprasList.Rows[i].Cells[2].Value.ToString(), comprasList.Rows[i].Cells[3].Value.ToString());
            }
        }

        private void ActualizarEquipamiento()
        {
            for (int i = 0; i < comprasList.Rows.Count - 1; i++)
            {
                _presentador.ActualizarEquipamiento(comprasList.Rows[i].Cells[0].Value.ToString(),comprasList.Rows[i].Cells[1].Value.ToString(), comprasList.Rows[i].Cells[2].Value.ToString(), comprasList.Rows[i].Cells[3].Value.ToString());
            }
        }



        private bool validarCampos()
        {
            if (fechaCompraValueTB.Text == null || fechaCompraValueTB.Text == string.Empty || FormatoDeFechaInvalido(fechaCompraValueTB.Text))
            {
                MessageBox.Show("LA FECHA DE COMPRA NO RESPETA EL FORMATO", "FECHA INVALIDA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                if (fechaEsperadaEntregaTB.Text == null || fechaEsperadaEntregaTB.Text == string.Empty || FormatoDeFechaInvalido(fechaEsperadaEntregaTB.Text))
                {
                    MessageBox.Show("LA FECHA ESPERADA DE ENTREGA NO RESPETA EL FORMATO", "FECHA INVALIDA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                else
                {
                    if (montoValueTB.Text == null || montoValueTB.Text == string.Empty || NoEsUnValorReal(montoValueTB.Text))
                    {
                        MessageBox.Show("EL MONTO NO PUEDE SER 0", "MONTO INVALIDO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                    else
                    {
                        if (facturaPathTB.Text == null || facturaPathTB.Text == string.Empty)
                        {
                            MessageBox.Show("DEBE SELECCIONAR EL PDF DE LA FACTURA DE COMPRA", "DATO FALTANTE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return false;
                        }
                        else
                        {
                            if (comprasList.Rows.Count == 0 )
                            {
                                MessageBox.Show("DEBE INGRESAR EL EQUIPAMIENTO ADQUIRIDO", "DATO FALTANTE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return false;
                            }
                            else
                            {
                                if (fechaRealEntregaTB.Visible)
                                {
                                    if(fechaRealEntregaTB.Text == null || fechaRealEntregaTB.Text == string.Empty || FormatoDeFechaInvalido(fechaRealEntregaTB.Text))
                                    {
                                        MessageBox.Show("LA FECHA REAL DE ENTREGA NO RESPETA EL FORMATO", "FECHA INVALIDA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        return false;
                                    }
                                    else
                                    {
                                        return true;
                                    }
                                                                       
                                }
                                else
                                {
                                    return true;
                                }
                            }
                        }
                    }
                }
            }
        }

        private bool FormatoDeFechaInvalido(string fecha)
        {
            try
            {
                DateTime convercion = DateTime.ParseExact(fecha, "dd-mm-yyyy", CultureInfo.InvariantCulture);
                return false;
            }
            catch (ArgumentException ae)
            {

            }
            return true;

        }

        private bool NoEsUnValorReal(string cadena)
        {
            try
            {
                string valor = cadena.Substring(1, cadena.Length - 1);

                double numero = double.Parse(valor, CultureInfo.InvariantCulture);

                if (numero <= 0.0d) return true;

                return false;
            }
            catch (ArgumentException ae)
            {

            }
            return true;

        }



        public string ObtenerFechaDeCompra()
        {
            return fechaCompraValueTB.Text;
        }

        public string ObtenerFechaDeEntregaEsperada()
        {
            return fechaEsperadaEntregaTB.Text;
        }

        public string ObtenerFechaRealDeEntrega()
        {
            return fechaRealEntregaTB.Text;
        }

        public string ObtenerMontoCompra()
        {
            return montoValueTB.Text;
        }

        public Proveedor ObtenerProveedor()
        {
            return proveedoresBindingSource.Current as Proveedor;
        }

        public string ObtenerFactura()
        {
            return facturaPathTB.Text;
        }


        private void montoValueTB_TextChanged(object sender, EventArgs e)
        {
            if(montoValueTB.Text.Length > 0)
            {
                if (montoValueTB.Text[0] != '$')
                {
                    montoValueTB.Text = '$' + montoValueTB.Text;
                }
            }
            else
            {
                montoValueTB.Text = "$";
                montoValueTB.SelectionStart = montoValueTB.Text.Length;
                montoValueTB.SelectionLength = 0;
            }
            
        }

        private void comprasList_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            //comprasList.Rows[e.RowIndex].Cells[3].
        }
    }
}
