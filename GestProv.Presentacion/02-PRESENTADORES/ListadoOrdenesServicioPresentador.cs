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
    public class ListadoOrdenesServicioPresentador
    {

        private GestProvContexto _contexto = new GestProvContexto();
        public ListadoOrdenesServicioPresentador()
        {

        }

        public void AltaOrdenServicio()
        {
            OrdenDeServicioVista OSVista = new OrdenDeServicioVista(_contexto);
            OSVista.ShowDialog();
        }

        public void BajaOrdenServicio(OrdenDeServicio orden)
        {
            _contexto.BajaOrdenDeServicio(orden);
        }

        public void EditarOrdenServicio(OrdenDeServicio orden)
        {
            OrdenDeServicioVista OSVista = new OrdenDeServicioVista(orden, _contexto);
            OSVista.ShowDialog();
        }

        public List<OrdenDeServicio> ObtenerOS()
        {
            return _contexto.ObtenerOrdenesServicio();
        }
    }


}
