using GestProv.Dominio._01_ENTIDADES;
using GestProv.InfraestructuraDatos._01_BASE_DE_DATOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestProv.Presentacion._02_PRESENTADORES
{
    public class OrdenDeServicioPresentador
    {
        private GestProvContexto _contexto;
        public OrdenDeServicioPresentador(GestProvContexto contexto)
        {
            _contexto = contexto;
        }

        public List<Tecnico> ObtenerTecnicos()
        {
            return _contexto.ObtenerTecnicosActivos();
        }

        public void AltaOrdenServicio(OrdenDeServicio orden)
        {
            _contexto.AltaOrdenDeServicio(orden);
        }

        public void GuardarOrdenServicio()
        {
            _contexto.GuardarCambios();
        }

    }
}
