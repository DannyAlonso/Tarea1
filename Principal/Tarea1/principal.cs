using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea1
{
    internal class principal
    {
        static void Main(string[] args)
        {
            Menu menu = new Menu();
            menu.mostrarMenu();
            Console.Read();
        }
    }
}
