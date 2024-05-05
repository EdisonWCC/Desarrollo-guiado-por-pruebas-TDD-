using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto
{
    public class MCD
    {
        public static int CalcularMCD(int a, int b)
        {
            // Si uno de los números es cero, el MCD es el otro número
            if (a == 0)
                return b;
            if (b == 0)
                return a;

            // Aplicamos el algoritmo de Euclides para encontrar el MCD
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }

        // Función para calcular el máximo común divisor de cuatro números
        public static int CalcularMCDCuatroNumeros(int a, int b, int c, int d)
        {
            // Calculamos el MCD de los dos primeros números
            int mcdAB = CalcularMCD(a, b);
            // Calculamos el MCD de los dos últimos números
            int mcdCD = CalcularMCD(c, d);
            // Calculamos el MCD de los dos resultados anteriores
            return CalcularMCD(mcdAB, mcdCD);
        }
    }
}
