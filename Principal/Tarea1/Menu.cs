using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea1
{
    internal class Menu
    {
        
        private Program program;
        private String opciones;
        

        public Menu()
        {
            program = new Program();

        }

        public void mostrarMenu()
        {
            do
            {
                Console.WriteLine("++++++++++ Menu principal del sistema ++++++++++\n"
                        + "1-Inicializar Vectores\n"
                        + "2-Ingresar Paso Veicular\n"
                        + "3-Consulta de vehículos x Número de Placa\n"
                        + "4-Modificar Datos Vehículos x número de Placa\n"
                        + "5-Reporte Todos los Datos de los vectores\n"
                        + "6-Salir");
                opciones = Console.ReadLine();

                switch (opciones)
                {
                    case "1":
                        program.inicializarVerctores();
                        break;
                    case "2":
                        program.ingrasarDatos();

                        break;
                    case "3":
                        program.consultarPlaca();


                        break;
                    case "4":
                        //program.modificar();
                        break;
                    case "5":
                        program.reporte();

                        break;
                    case "6":

                        break;


                }//fin del switch
            } while (opciones !="6");
            Console.Read();

        }//fin del metodo menu



    }
}
