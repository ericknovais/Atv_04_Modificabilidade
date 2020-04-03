using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    // S - Single Responsibility Principle (Princípio da responsabilidade única)
    public class Calculadora : ICalculadora
    {
        public int Somar(int numero1, int numero2)
        {
            return numero1 + numero2;
        }

        public int Subtrair(int numero1, int numero2)
        {
            return numero1 - numero2;
        }

        public int Dividir(int numero1, int numero2)
        {
            return numero1 / numero2;
        }

        public int Multiplicar(int numero1, int numero2)
        {
            return numero1 * numero2;
        }
    }
}
