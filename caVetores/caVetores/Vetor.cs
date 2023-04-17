using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caVetores
{
    internal class Vetor
    {
        //Atributos
        private double x;
        private double y;



        //Métodos
        public Vetor() { }

        public Vetor(double _x, double _y) {
            x = _x;
            y = _y;
        }

        public Vetor (string str)
        {
            Console.WriteLine(str);
            x = Convert.ToDouble(Console.ReadLine());
            y = Convert.ToDouble(Console.ReadLine());
        }

        public Vetor somaVetor(Vetor v2)
        {
            Vetor vRes = new Vetor(x+v2.x, y+v2.y);

            return vRes;
        }

        public double prodEscalar(Vetor v2)
        {
            return x*v2.x + y*v2.y;
            
        }

        public void imprimeVetor(Vetor v2)
        {
            Console.WriteLine("Coordenadas do vetor 1: ("+x+","+y+")");
            Console.WriteLine("\n");
            Console.WriteLine("Coordenadas do vetor 2: (" + v2.x + "," + v2.y + ")");
            Console.WriteLine("\n");
            Console.WriteLine("Coordenadas do vetor soma: (" + somaVetor(v2).x + "," + somaVetor(v2).y + ")");
            Console.WriteLine("\n");
            Console.WriteLine("Produto escalar entre os vetores 1 e 2: "+ prodEscalar(v2));
            Console.ReadLine();
        }

        //getters & setters
        public double X { get => x; set => x = value; }
        public double Y { get => y; set => y = value; }
    }//Fim da classe Vetor
}
