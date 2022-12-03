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
    public class TecnicoPresentador
    {
        private TecnicoVista _vista;
        private GestProvContexto _contexto;
        public TecnicoPresentador(TecnicoVista vista, GestProvContexto contexto)
        {
            _vista = vista;
            _contexto = contexto;
        }

        public void AltaTecnico(Tecnico tecnico)
        {
            _contexto.AltaTecnico(tecnico);
        }
        public void GuardarTecnico()
        {
            _contexto.GuardarCambios();
        }

        public List<Proveedor> ObtenerProveedoresActivos()
        {
            return _contexto.ObtenerProveedoresActivos();
        }
    }
}
