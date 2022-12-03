using GestProv.Dominio._01_ENTIDADES;
using GestProv.InfraestructuraDatos._01_BASE_DE_DATOS;
using GestProv.Presentacion._02_PRESENTADORES;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace GestProv.Presentacion._01_VISTAS
{
    public partial class ProveedorVista : Form
    {
        private ProveedorPresentador _presentador;
        private Proveedor _proveedor;
        private bool _alta;
        public ProveedorVista(GestProvContexto contexto)
        {
            InitializeComponent();
            _presentador = new ProveedorPresentador(this, contexto);
            _proveedor = new Proveedor();
            _alta = true;
            labelEstado.Visible = false;
            checkBoxEstado.Visible = false;
        }

        public ProveedorVista(Proveedor proveedor, GestProvContexto contexto)
        {
            InitializeComponent();
            _presentador = new ProveedorPresentador(this, contexto);
            _proveedor = proveedor;
            textNombreyApellido.Text = _proveedor.NombreyApellido;
            textRazonSocial.Text = _proveedor.RazonSocial;
            txtCUIT.Text = _proveedor.CUIT;
            checkBoxEstado.Checked = _proveedor.Estado;
            if (!_proveedor.Estado)
            {
                labelEstado.Visible = true;
                checkBoxEstado.Visible = true;
            }
            btnLimpiar.Visible = false;
            _alta = false;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (validarCampos())
            {
                
                    _proveedor.NombreyApellido = textNombreyApellido.Text;
                    _proveedor.RazonSocial = textRazonSocial.Text;
                    _proveedor.CUIT = txtCUIT.Text;
                if (_alta)
                {
                    _proveedor.Estado = true;
                    _presentador.AltaProveedor(_proveedor);
                    Guardar();
                }
                else
                {
                    _proveedor.Estado = checkBoxEstado.Checked;
                    DialogResult dialog = MessageBox.Show("ESTA SEGURO QUE DESEA MODIFICAR EL PROVEEDOR?", "ESTA SEGURO?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (dialog == DialogResult.Yes)
                    {
                        Guardar();
                    }
                }
            }
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            textNombreyApellido.Text = string.Empty;
            textRazonSocial.Text = string.Empty;
            txtCUIT.Text = string.Empty;
        }

        private void Guardar()
        {
            _presentador.GuardarProveedor();
            MessageBox.Show("PROVEEDOR GUARDADO CORRECTAMENTE", "GUARDADO CORRECTO", MessageBoxButtons.OK);
            this.Close();
        }

        private bool validarCampos()
        {
            if (textNombreyApellido.Text == null || textNombreyApellido.Text == string.Empty)
            {
                MessageBox.Show("DEBE INGRESAR NOMBRE Y APELLIDO DEL PROVEEDOR", "DATO FALTANTE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                if (textRazonSocial.Text == null || textRazonSocial.Text == string.Empty)
                {
                    MessageBox.Show("DEBE INGRESAR RAZON SOCIAL DEL PROVEEDOR", "DATO FALTANTE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                else
                {
                    if (txtCUIT.Text == null || txtCUIT.Text == string.Empty)
                    {
                        MessageBox.Show("DEBE INGRESAR CUIT DEL PROVEEDOR", "DATO FALTANTE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
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
