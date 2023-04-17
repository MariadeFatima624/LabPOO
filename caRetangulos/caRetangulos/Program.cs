using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caRetangulos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Retangulo r1 = new Retangulo(10, 20);

            Console.WriteLine("Dados do retângulo r1:");
            //Console.ReadLine();
            r1.Imprime();
            Console.ReadLine();

            r1.mudaAltura(25);
            r1.mudaComprimento(50);
            Console.WriteLine("Novos dados do retângulo r1:");
            //Console.ReadLine();
            r1.Imprime();
            Console.ReadLine();
        }
    }
}
