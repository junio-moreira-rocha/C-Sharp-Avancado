using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateParaInstanciasEhMetodosEstaticos
{
    class Program
    {
        delegate int ExecutarOperacaoAritimetica(int a, int b);
        static void Main(string[] args)
        {
            int num1 = 20;
            int num2 = 10;
            int resultado;

            Calculadora calculadora = new Calculadora();
            ExecutarOperacaoAritimetica executarOperacao = new ExecutarOperacaoAritimetica(calculadora.Somar);

            resultado = executarOperacao(num1, num2);
            Console.WriteLine($"{num1} + {num2} = {resultado}");
            Console.WriteLine(executarOperacao.Target.ToString());

            executarOperacao += calculadora.Subtrair;
            resultado = executarOperacao(num1, num2);
            Console.WriteLine($"{num1} - {num2} = {resultado}");
            Console.WriteLine(executarOperacao.Target.ToString());

            Console.ReadKey(true);
        }
    }

    class Calculadora
    {
        public int Somar(int num1, int num2)
        {
            return num1 + num2;
        }

        public int Subtrair(int num1, int num2)
        {
            return num1 - num2;
        }
    }
}
