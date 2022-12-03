using GestProv.Presentacion._01_VISTAS;
using GestProv.Presentacion._03_INTERFACES;
using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestProv.Presentacion._02_PRESENTADORES
{
    public class PrincipalPresentador
    {
        private PrincipalVista _vista;
        public PrincipalPresentador(PrincipalVista vista) 
        {
            _vista = vista;
        }
        public void ListarCompras()
        {
            ListadoComprasVista listadoCompras = new ListadoComprasVista();
            listadoCompras.MdiParent = _vista;
            listadoCompras.Show();
        }

        public void ListarOS()
        {
            ListadoOrdenesServiciosVista listadoCompras = new ListadoOrdenesServiciosVista();
            listadoCompras.MdiParent = _vista;
            listadoCompras.Show();
        }

        public void ListarProveedores()
        {
            ListadoProveedoresVista listadoCompras = new ListadoProveedoresVista();
            listadoCompras.MdiParent = _vista;
            listadoCompras.Show();
        }

        public void ListarTecnicos()
        {
            ListadoTecnicosVista listadoCompras = new ListadoTecnicosVista();
            listadoCompras.MdiParent = _vista;
            listadoCompras.Show();
        }
    }
    
}
