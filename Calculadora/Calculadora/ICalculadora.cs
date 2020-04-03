using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    //I — Interface Segregation Principle (Princípio da Segregação da Interface)
    interface ICalculadora
    {
        int Somar(int numero1, int numero2);
        int Subtrair(int numero1, int numero2);
        int Dividir(int numero1, int numero2);
        int Multiplicar(int numero1, int numero2);
    }
}
