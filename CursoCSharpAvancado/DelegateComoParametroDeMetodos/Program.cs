using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateComoParametroDeMetodos
{
    class Program
    {
        delegate int ExecutarOperacao(int a, int b);

        private static void EscreverResultado(int a, int b, ExecutarOperacao operacao)
        {
            int resultado = operacao(a, b);
            Console.WriteLine(string.Format("O resultado é {0}", resultado));
        }

        private static int Somar(int a, int b)
        {
            return a + b;
        }

        static void Main(string[] args)
        {
            EscreverResultado(20, 15, Somar);

            Console.ReadKey(true);
        }
    }
}
