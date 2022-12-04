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
    public partial class OrdenDeServicioVista : Form
    {
        private OrdenDeServicioPresentador _presentador;
        private OrdenDeServicio _ordenServicio;
        private bool _alta;
        public OrdenDeServicioVista(GestProvContexto contexto)
        {
            InitializeComponent();
            _ordenServicio = new OrdenDeServicio();
            _presentador = new OrdenDeServicioPresentador(contexto);
            _alta = true;
            tecnicoBindingSource.DataSource = ObtenerTecnicos();
        }
        public OrdenDeServicioVista(OrdenDeServicio orden, GestProvContexto contexto)
        {
            InitializeComponent();
            _ordenServicio = orden;
            _presentador = new OrdenDeServicioPresentador(contexto);
            _alta = false;
            textDescripcion.Text = _ordenServicio.Descripcion;
            textFechaSolic.Text = _ordenServicio.FechaSolicitud;
            textFechaEstResol.Text = _ordenServicio.FechaEstimadaResolucion;
            textFechaRealResol.Text = _ordenServicio.FechaRealResolucion;
            tecnicoBindingSource.Add(_ordenServicio.Tecnico);
            btnLimpiar.Visible = false;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            textDescripcion.Text = string.Empty;
            textFechaSolic.Text = string.Empty;
            textFechaEstResol.Text = string.Empty;
            textFechaRealResol.Text = string.Empty;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (validarCampos())
            {
                _ordenServicio.Descripcion = textDescripcion.Text;
                _ordenServicio.FechaSolicitud = textFechaSolic.Text;
                _ordenServicio.FechaEstimadaResolucion = textFechaEstResol.Text;
                _ordenServicio.FechaRealResolucion = textFechaRealResol.Text;
                _ordenServicio.Tecnico = tecnicoBindingSource.Current as Tecnico;
                if (_alta)
                {
                    _presentador.AltaOrdenServicio(_ordenServicio);
                    Guardar();
                }
                else
                {
                    DialogResult dialog = MessageBox.Show("ESTA SEGURO QUE DESEA MODIFICAR LA ORDEN DE SERVICIO?", "ESTA SEGURO?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (dialog == DialogResult.Yes)
                    {
                        Guardar();
                    }
                    
                }
            }
        }

        private void Guardar()
        {
            _presentador.GuardarOrdenServicio();
            MessageBox.Show("ORDEN DE SERVICIO GUARDADA CORRECTAMENTE", "GUARDADO CORRECTO", MessageBoxButtons.OK);
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private List<Tecnico> ObtenerTecnicos()
        {
            return _presentador.ObtenerTecnicos();
        }

        private bool validarCampos()
        {
            if (textDescripcion.Text == null || textDescripcion.Text == string.Empty)
            {
                MessageBox.Show("DEBE INGRESAR DESCRIPCION DE LA ORDEN DE SERVICIO", "DATO FALTANTE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                if (textFechaSolic.Text == null || textFechaSolic.Text == string.Empty)
                {
                    MessageBox.Show("DEBE INGRESAR FECHA DE SOLICITUD DEL TECNICO", "DATO FALTANTE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                else
                {
                    if (dataGridViewTecnicos.SelectedRows == null)
                    {
                        MessageBox.Show("DEBE SELECCIONAR UN TECNICO ASOCIADO A LA ORDEN DE SERVICIO", "DATO FALTANTE", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
