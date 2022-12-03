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
    public partial class TecnicoVista : Form
    {
        private TecnicoPresentador _presentador;
        private Tecnico _tecnico;
        private bool _alta;
        public TecnicoVista(GestProvContexto contexto)
        {
            InitializeComponent();
            _presentador = new TecnicoPresentador(this, contexto);
            CargarProveedores();
            _tecnico = new Tecnico();
            _alta = true;
            labelEstado.Visible = false;
            checkBoxEstado.Visible = false;
        }
        public TecnicoVista(Tecnico tecnico, GestProvContexto contexto)
        {
            InitializeComponent();
            _presentador = new TecnicoPresentador(this, contexto);
            CargarProveedores();
            _tecnico = tecnico;
            textNombre.Text = _tecnico.Nombre;
            textApellido.Text = _tecnico.Apellido;
            txtDNI.Text = _tecnico.DNI;
            textMail.Text = _tecnico.Mail;
            textTelefono.Text = _tecnico.Telefono;
            comboProveedores.SelectedItem = _tecnico.Proveedor;
            checkBoxEstado.Checked = _tecnico.Estado;
            if (!_tecnico.Estado)
            {
                labelEstado.Visible = true;
                checkBoxEstado.Visible = true;
            }
            btnLimpiar.Visible = false;
            _alta = false;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            textApellido.Text = string.Empty;
            textNombre.Text = string.Empty;
            textMail.Text = string.Empty;
            textTelefono.Text = string.Empty;
            txtDNI.Text = string.Empty;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (validarCampos())
            {

                _tecnico.Nombre = textNombre.Text;
                _tecnico.Apellido = textApellido.Text;
                _tecnico.DNI = txtDNI.Text;
                _tecnico.Mail = textMail.Text;
                _tecnico.Telefono = textTelefono.Text;
                _tecnico.Proveedor = comboProveedores.SelectedItem as Proveedor;
                if (_alta)
                {
                    _tecnico.Estado = true;
                    _presentador.AltaTecnico(_tecnico);
                    Guardar();
                }
                else
                {
                    _tecnico.Estado = checkBoxEstado.Checked;
                    DialogResult dialog = MessageBox.Show("ESTA SEGURO QUE DESEA MODIFICAR EL TECNICO?", "ESTA SEGURO?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (dialog == DialogResult.Yes)
                    {
                        Guardar();
                    }
                }
            }

        }

        private void Guardar()
        {
            _presentador.GuardarTecnico();
            MessageBox.Show("PROVEEDOR GUARDADO CORRECTAMENTE", "GUARDADO CORRECTO", MessageBoxButtons.OK);
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }


        private void CargarProveedores()
        {
            proveedorBindingSource.DataSource = _presentador.ObtenerProveedoresActivos();
        }

        private bool validarCampos()
        {
            if (textNombre.Text == null || textNombre.Text == string.Empty)
            {
                MessageBox.Show("DEBE INGRESAR NOMBRE DEL TECNICO", "DATO FALTANTE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                if (textApellido.Text == null || textApellido.Text == string.Empty)
                {
                    MessageBox.Show("DEBE INGRESAR APELLIDO DEL TECNICO", "DATO FALTANTE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                else
                {
                    if (txtDNI.Text == null || txtDNI.Text == string.Empty)
                    {
                        MessageBox.Show("DEBE INGRESAR DNI DEL TECNICO", "DATO FALTANTE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                    else
                    {
                        if (textMail.Text == null || textMail.Text == string.Empty)
                        {
                            MessageBox.Show("DEBE INGRESAR MAIL DEL TECNICO", "DATO FALTANTE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return false;
                        }
                        else
                        {
                            if (textTelefono.Text == null || textTelefono.Text == string.Empty)
                            {
                                MessageBox.Show("DEBE INGRESAR TELEFONO DEL TECNICO", "DATO FALTANTE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return false;
                            }
                            else
                            {
                                if (comboProveedores.Text == null || comboProveedores.Text == string.Empty)
                                {
                                    MessageBox.Show("DEBE SELECCIONAR UN PROVEEDOR ASOCIADO AL TECNICO", "DATO FALTANTE", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        }
    }
}
