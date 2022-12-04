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
    public partial class SucursalVista : Form
    {
        private SucursalPresentador _presentador;
        private Proveedor _proveedor;
        private Sucursal _sucursal;
        private bool _alta;
        public SucursalVista(Proveedor proveedor, GestProvContexto contexto)
        {
            InitializeComponent();
            _presentador = new SucursalPresentador(this,contexto);
            _proveedor = proveedor;
            _alta = true;
            _sucursal = new Sucursal();
            ObtenerPaises();
        }
        public SucursalVista(Sucursal sucursal, GestProvContexto contexto)
        {
            InitializeComponent();
            _presentador = new SucursalPresentador(this, contexto);
            _alta = false;
            _sucursal = sucursal;
            btnLimpiar.Visible = false;
            ObtenerPaises();
            comboBoxPais.SelectedItem = _sucursal.Ciudad.Provincia.Pais;
            comboBoxProvincia.Enabled = true;
            ObtenerProvincias();
            comboBoxProvincia.SelectedItem = _sucursal.Ciudad.Provincia;
            comboBoxCiudad.Enabled = true;
            ObtenerCiudades();
            comboBoxCiudad.SelectedItem = _sucursal.Ciudad;
            textCalle.Text = _sucursal.NombreCalle;
            textAltura.Text = _sucursal.Altura;
            txtPiso.Text = _sucursal.Piso;
            textMail.Text = _sucursal.Mail;
            textTelefono.Text = _sucursal.Telefono;
        }



        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            textAltura.Text = string.Empty;
            textCalle.Text = string.Empty;
            textMail.Text = string.Empty;
            textTelefono.Text = string.Empty;
            txtPiso.Text = string.Empty;
            comboBoxProvincia.Enabled = false;
            comboBoxCiudad.Enabled = false;
        }

        private void ObtenerPaises()
        {
            paisBindingSource.Clear();
            provinciaBindingSource.Clear();
            ciudadBindingSource.Clear();
            paisBindingSource.DataSource = _presentador.ObtenerPaises();
        }

        private void ObtenerProvincias()
        {
            provinciaBindingSource.Clear();
            ciudadBindingSource.Clear();
            provinciaBindingSource.DataSource = _presentador.ObtenerProvincias(comboBoxPais.SelectedItem as Pais);
        }

        private void ObtenerCiudades()
        {
            ciudadBindingSource.Clear();
            ciudadBindingSource.DataSource = _presentador.ObtenerCiudades(comboBoxProvincia.SelectedItem as Provincia);
        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (validarCampos())
            {
                _sucursal.NombreCalle = textCalle.Text;
                _sucursal.Altura = textAltura.Text;
                _sucursal.Piso = txtPiso.Text;
                _sucursal.Mail = textMail.Text;
                _sucursal.Telefono = textTelefono.Text;
                if (_alta)
                {
                    _sucursal.Proveedor = _proveedor;
                    _presentador.AltaSucursal(_sucursal);
                    Guardar();
                }
                else
                {
                    DialogResult dialog = MessageBox.Show("ESTA SEGURO QUE DESEA MODIFICAR LA SUCURSAL?", "ESTA SEGURO?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (dialog == DialogResult.Yes)
                    {
                        Guardar();
                    }
                }
            }
            _presentador.GuardarSucursal();
        }
        private void Guardar()
        {
            _presentador.GuardarSucursal();
            MessageBox.Show("SUCURSAL GUARDADA CORRECTAMENTE", "GUARDADO CORRECTO", MessageBoxButtons.OK);
            this.Close();
        }

        private void comboBoxPais_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxPais.SelectedItem != null)
            {
                comboBoxProvincia.Enabled = true;
                comboBoxCiudad.Enabled = false;
                ObtenerProvincias();
            }
        }

        private void comboBoxProvincia_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxProvincia.SelectedItem != null)
            {
                comboBoxCiudad.Enabled = true;
                ObtenerCiudades();
            }
        }

        private void comboBoxCiudad_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxCiudad.SelectedItem != null)
            {
                _sucursal.Ciudad = comboBoxCiudad.SelectedItem as Ciudad;
            }
        }

        private bool validarCampos()
        {
            if (textCalle.Text == null || textCalle.Text == string.Empty)
            {
                MessageBox.Show("DEBE INGRESAR NOMBRE DE CALLE PARA LA SUCURSAL", "DATO FALTANTE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                if (textAltura.Text == null || textAltura.Text == string.Empty)
                {
                    MessageBox.Show("DEBE INGRESAR ALTURA DE CALLE DE LA SUCURSAL", "DATO FALTANTE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                else
                {
                    if (txtPiso.Text == null || txtPiso.Text == string.Empty)
                    {
                        MessageBox.Show("DEBE INGRESAR NUMERO DE PISO DE LA SUCURSAL", "DATO FALTANTE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                    else
                    {
                        if (textMail.Text == null || textMail.Text == string.Empty)
                        {
                            MessageBox.Show("DEBE INGRESAR MAIL DE LA SUCURSAL", "DATO FALTANTE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return false;
                        }
                        else
                        {
                            if (textTelefono.Text == null || textTelefono.Text == string.Empty)
                            {
                                MessageBox.Show("DEBE INGRESAR TELEFONO DE LA SUCURSAL", "DATO FALTANTE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return false;
                            }
                            else
                            {
                                if (comboBoxCiudad.Text == null || comboBoxCiudad.Text == string.Empty)
                                {
                                    MessageBox.Show("DEBE SELECCIONAR LA CIUDAD DE LA SUCURSAL", "DATO FALTANTE", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
