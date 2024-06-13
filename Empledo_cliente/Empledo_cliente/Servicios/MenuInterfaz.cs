using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empledo_cliente.Servicios
{
    internal interface MenuInterfaz
    {
        public int mostrarMenuPrincipal();
        public void accederVersionEmpleado();

        public int accederVersionCliente();
    }
}
