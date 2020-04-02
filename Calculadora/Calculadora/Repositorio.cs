using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    public class Repositorio
    {
        public Repositorio()
        {
            Resultado = "O resultado é";
            Soma = '+';
            Sub = '-';
            Div = '/';
            Mult = '*';
        }

        public int Numero1 { get; set; }
        public int Numero2 { get; set; }
        public string[] numeros { get; set; }

        public string Resultado { get; set; }

        /// <summary>
        /// Propriedade já contem o +
        /// </summary>
        public char Soma { get; }
        
        /// <summary>
        /// Propriedade já contem o -
        /// </summary>
        public char Sub { get; }

        /// <summary>
        /// Propriedade já contem o /
        /// </summary>
        public char Div { get; }

        /// <summary>
        /// Propriedade já contem o *
        /// </summary>
        public char Mult { get; }

    }
}
