using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caResistores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite os dados solicitaados no seguinte formato:\n Valor da resistência \n *pressione enter* \n Valor da máxima potência \n *pressione enter*");
            Console.ReadLine();
            Resistor r1 = new Resistor("Digite os dados do resisro 1:");
            Console.WriteLine("\n");
            Resistor r2 = new Resistor("Digite os dados do resisro 2:");
            Console.WriteLine("\n");
            r1.imprimeResistor(r2);
        }
    }
}
