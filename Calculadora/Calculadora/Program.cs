using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            Repositorio rep = new Repositorio();
            Calculadora calc = new Calculadora();

            Console.WriteLine("Esse é uma aplicação de calculadora!");
            Console.WriteLine("Informe um número, um operação (+, -, / ou *), e depois informe mais um numero:");

            string operacao = Console.ReadLine(); 

            if (operacao.Contains(rep.Soma))
            {
                rep.numeros = operacao.Split(rep.Soma);
                rep.Numero1 = Convert.ToInt32(rep.numeros[0]);
                rep.Numero2 = Convert.ToInt32(rep.numeros[1]);
                rep.Resultado = $"{rep.Resultado} {calc.Somar(rep.Numero1, rep.Numero2)}";
            }
            else if (operacao.Contains(rep.Sub))
            {
                rep.numeros = operacao.Split(rep.Sub);
                rep.Numero1 = Convert.ToInt32(rep.numeros[0]);
                rep.Numero2 = Convert.ToInt32(rep.numeros[1]);
                rep.Resultado = $"{rep.Resultado} {calc.Subtrair(rep.Numero1, rep.Numero2)}";
            }
            else if (operacao.Contains(rep.Div))
            {
                rep.numeros = operacao.Split(rep.Div);
                rep.Numero1 = rep.numeros[0].Equals(0)? 0 : Convert.ToInt32(rep.numeros[0]);
                rep.Numero2 = Convert.ToInt32(rep.numeros[1]);
                rep.Resultado = $"{rep.Resultado} {calc.Dividir(rep.Numero1, rep.Numero2)}";
            }
            else
            {
                rep.numeros = operacao.Split(rep.Mult);
                rep.Numero1 = Convert.ToInt32(rep.numeros[0]);
                rep.Numero2 = Convert.ToInt32(rep.numeros[1]);
                rep.Resultado = $"{rep.Resultado} {calc.Multiplicar(rep.Numero1, rep.Numero2)}";
            }

            Console.WriteLine(rep.Resultado);

            Console.ReadKey();
        }
    }
}
