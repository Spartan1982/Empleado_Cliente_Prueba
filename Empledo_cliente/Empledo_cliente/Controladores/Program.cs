using Empledo_cliente.Servicios;

namespace Prueba
{

    class program
    {

        public static void Main(string[] args)
        {

            MenuInterfaz mi = new MenuImplementacion();

            int opcionPrincipal;
            bool cerrarMenu=false;

            do
            {

                opcionPrincipal = mi.mostrarMenuPrincipal();

                switch (opcionPrincipal)
                {

                    case 0:
                        Console.WriteLine("Se cierra la aplicacion");
                        cerrarMenu = true;
                        break;
                    case 1:
                        Console.WriteLine("VERSION CLIENTE");
                        mi.accederVersionCliente();
                        break;
                        
                    case 2:
                        Console.WriteLine("VERSION EMPLEADO");
                        mi.accederVersionEmpleado();
                        break ;
                    default:
                        Console.WriteLine("No se ha elegido ninguna opcion");
                        break;
                }

            }while(!cerrarMenu);
        }
    }
}