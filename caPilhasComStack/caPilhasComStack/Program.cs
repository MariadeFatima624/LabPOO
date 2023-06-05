using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caPilhasComStack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<string> pilha = new Stack<string>();

            Console.WriteLine("Deseja adicionar algum elemento à pilha?");
            bool respPush = Convert.ToBoolean(Console.ReadLine());
            if (respPush)
            {
                Console.WriteLine("Quantos elementos do tipo string deseja adicionar à pilha?");
                int nPush = Convert.ToInt32(Console.ReadLine());

                for (int i = 0; i <= nPush; i++) {
                    Console.WriteLine("Digite o elemento que deseja adicionar à pilha:");
                    string aux = Console.ReadLine();
                    pilha.Push(aux);
                }
            }

            Console.WriteLine("Deseja deletar algum elemento da pilha?");
            bool respPop = Convert.ToBoolean(Console.ReadLine());
            if (respPop)
            {
                Console.WriteLine("Quantos elementos do tipo string deseja deletar da pilha?");
                int nPop = Convert.ToInt32(Console.ReadLine());

                for (int i = 0; i <= nPop; i++)
                {
                    if (pilha.Any())
                    {
                        pilha.Pop();
                    }
                }
            }

            Console.WriteLine("Deseja visualizar o último elemento da pilha?");
            bool respPeek = Convert.ToBoolean(Console.ReadLine());
            if (respPeek)
            {
                if (pilha.Any())
                {
                    pilha.Peek();
                }
            }
        }
    }
}
