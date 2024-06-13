using Empledo_cliente.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empledo_cliente.Servicios
{
    internal class MenuImplementacion : MenuInterfaz
    {

        List<ClienteDto>listaClientes= new List<ClienteDto>();
        public int mostrarMenuPrincipal()
        {

            int opcionPrincipal;

            Console.WriteLine("0. Cerrar aplicación");
            Console.WriteLine("1. Versión empleado");
            Console.WriteLine("2. Versión cliente");
            Console.WriteLine("Escriba la opción deseada: ");
            opcionPrincipal = Convert.ToInt32(Console.ReadLine());
            return opcionPrincipal;


        }

        public void accederVersionEmpleado()
        {
            EmpleadoInterfaz ei = new EmpleadoImplementacion();

            int opcionEmpleado;
            opcionEmpleado = mostrarMenuEmpleado();

            switch (opcionEmpleado)
            {
                case 0:
                    Console.WriteLine("Validar cliente");
                    ei.validarCliente(listaClientes);
                     break;
                case 1:
                    Console.WriteLine("Mostrar cliente");
                    ei.mostrarCliente(listaClientes);
                    break;
                case 2:
                    Console.WriteLine("Borrar cliente");
                    ei.borrarCliente(listaClientes);
                    break;


            }





        }

        private int mostrarMenuEmpleado()
        {
            int opcion;




            return opcion;

        }

        public void accederVersionCliente()
        {


        }

        int MenuInterfaz.accederVersionCliente()
        {
            throw new NotImplementedException();
        }
    }

}

