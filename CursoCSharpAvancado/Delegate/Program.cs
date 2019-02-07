using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    class Program
    {
        private delegate int ExecutarOperacaoAritimetica(int a, int b);
        static void Main(string[] args)
        {
            int num1 = 16;
            int num2 = 7;

            ExecutarOperacaoAritimetica executarCalculo = new ExecutarOperacaoAritimetica(Subtrair);

            int resultado = executarCalculo(num1, num2);
            Console.WriteLine($"{num1} - {num2} = {resultado}");

            executarCalculo += Somar;
            resultado = executarCalculo(num1, num2);
            Console.WriteLine($"{num1} + {num2} = {resultado}");

            executarCalculo += Multiplicar;
            resultado = executarCalculo(num1, num2);
            Console.WriteLine($"{num1} * {num2} = {resultado}");

            executarCalculo += Dividir;
            resultado = executarCalculo(num1, num2);
            Console.WriteLine($"{num1} / {num2} = {resultado}");

            Console.ReadKey(true);
        }

        static int Somar(int a, int b)
        {
            return a + b;
        }

        static int Subtrair(int a, int b)
        {
            return a - b;
        }

        static int Multiplicar(int a, int b)
        {
            return a * b;
        }

        static int Dividir(int a, int b)
        {
            if (b != 0)
            {
                return a / b;
            }
            return 0;
        }
    }
}
