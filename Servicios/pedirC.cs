using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3forC.Servicios
{
    internal class pedirC : pedirI
    {
        public int pedir()
        {
            Console.WriteLine("escribe un numero enetro");
            int i = Convert.ToInt32(Console.ReadLine());
            return i;
        }
    }
}
