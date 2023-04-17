using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caVetores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Favor digitar os dados solicitados no seguinte formato:\nValor da coordenada x \n*pressione enter* \nValor da coordenada em y\n*pressione enter*");
            Console.WriteLine("\n");
            Vetor v1 = new Vetor("Digite os dados do vetor 1:");
            Console.WriteLine("\n");
            Vetor v2 = new Vetor("Digite os dados do vetor 2:");
            Console.WriteLine("\n");
            v1.imprimeVetor(v2);
        }
    }
}
