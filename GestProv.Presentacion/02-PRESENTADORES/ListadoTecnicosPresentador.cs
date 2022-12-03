using GestProv.Dominio._01_ENTIDADES;
using GestProv.InfraestructuraDatos._01_BASE_DE_DATOS;
using GestProv.Presentacion._01_VISTAS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestProv.Presentacion._02_PRESENTADORES
{
    public class ListadoTecnicosPresentador
    {
        private ListadoTecnicosVista _vista;
        private GestProvContexto _contexto = new GestProvContexto();

        public ListadoTecnicosPresentador(ListadoTecnicosVista vista)
        {
            _vista = vista;
        }

        public void NuevoTecnico()
        {
            TecnicoVista proveedorVista = new TecnicoVista(_contexto);
            proveedorVista.ShowDialog();
        }

        public List<Tecnico> ObtenerLista()
        {
            return _contexto.ObtenerTecnicos();
        }

        public void BajaTecnico(Tecnico tecnico)
        {
            tecnico.Estado = false;
            _contexto.GuardarCambios();

        }
        public void EditarTecnico(Tecnico tecnico)
        {
            TecnicoVista proveedorVista = new TecnicoVista(tecnico, _contexto);
            proveedorVista.ShowDialog();
        }
    }
}
