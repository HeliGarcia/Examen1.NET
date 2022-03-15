using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen1.Juego
{
    internal class Instrucciones
    {
        public void mostrarInstrucciones()
        {
            Console.WriteLine("\n");
            Console.WriteLine("------------------- Las instrucciones son las siguientes -------------------\n");
            Console.WriteLine("1. Se inicia el juego con $300 para apostar.\n" +
                "2. Selecciona el tipo de apuesta que deseas realizar; número específico (x10), extremos (x8), medios (x4), par o impar (x2)." +
                "3. Al seleccionar la opción de 'lanzar dados' se lanzarán dos dados de 6 caras.\n" +
                "4. Si el valor de ambos dados da el número específico que elegiste, cayó en un extremo, en algún medio \n " +
                "  o fue par o impar según lo elegido, ganarás el dinero apostado multiplicado por el valor correspondiente." +
                "5. Puedes retirarte en cualquier momento eligiendo la opción 'Salir'" +
                "6. Pierdes al momento de quedarte sin dinero.");
        }
    }
}
