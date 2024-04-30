using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chante4Eva.servicios
{
    /// <summary>
    /// Implementación donde se encuentran los metodos del menú
    /// </summary>
    internal class MenuImplementacion : MenuInterfaz
    {
        public int menuAcceso()
        {
            Console.WriteLine("Introduce una opción");
            Console.WriteLine("--------------------");
            Console.WriteLine("[0] - cerrar menú");
            Console.WriteLine("[1] - Registro de llegada");
            Console.WriteLine("[2] - Listado de consultas");
            Console.WriteLine("--------------------");

            int op1 = Convert.ToInt32(Console.ReadLine());

            return op1;
        }
        public int menuConsultas()
        {
            Console.WriteLine("Introduce una opción");
            Console.WriteLine("--------------------");
            Console.WriteLine("[0] - Volver");
            Console.WriteLine("[1] - Mostrar Consultas");
            Console.WriteLine("[2] - Imprimir Consultas");
            Console.WriteLine("--------------------");

            int op2 = Convert.ToInt32(Console.ReadLine());

            return op2;
        }

        public int tipoConsultas()
        {
            Console.WriteLine("Introduce una opción");
            Console.WriteLine("--------------------");
            Console.WriteLine("[0] - Psicología");
            Console.WriteLine("[1] - Traumatología");
            Console.WriteLine("[2] - Fisioterapia");
            Console.WriteLine("--------------------");

            int op3 = Convert.ToInt32(Console.ReadLine());

            return op3;
        }
    }
}
