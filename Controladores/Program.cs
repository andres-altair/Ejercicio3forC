using Ejercicio3forC;
using Ejercicio3forC.Servicios;

namespace Ejercicio3forC
{
    class program
    {
        static void Main(string[] args)
        {
            pedirI pI = new pedirC();
            int i = pI.pedir();
            forI fI = new forC();
            fI.foor(i);
        }
    }
}