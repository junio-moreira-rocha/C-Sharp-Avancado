using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateMulticast
{
    class Program
    {
        delegate void EscreverMensagem();

        static void Main(string[] args)
        {
            EscreverMensagem escreverMensagem = new EscreverMensagem(Mensagem1);
            escreverMensagem += Mensagem2;
            escreverMensagem += Mensagem3;

            // Para que os metódos sejam executados, deve-se chamar a instância do delegate
            escreverMensagem();

            Console.ReadKey(true);
        }

        static void Mensagem1()
        {
            Console.WriteLine("Mensagem 1");
        }

        static void Mensagem2()
        {
            Console.WriteLine("Mensagem 2");
        }

        static void Mensagem3()
        {
            Console.WriteLine("Mensagem 3");
        }
    }
}
