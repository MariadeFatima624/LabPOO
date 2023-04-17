using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caResistores
{
    internal class Resistor
    {
        //Atributos
        private double resistencia;
        private double potenciaMax;

        //Métodos

        public Resistor() { }

        public Resistor(double _resistencia, double _potenciaMax)
        {
            resistencia = _resistencia;
            potenciaMax = _potenciaMax;
        }

        public Resistor (string str)
        {
            Console.WriteLine(str);
            resistencia = Convert.ToDouble(Console.ReadLine());
            potenciaMax = Convert.ToDouble(Console.ReadLine());
        }

        public Resistor resistorSerie( Resistor R)
        {
            Resistor rSerie = new Resistor();

            rSerie.resistencia = resistencia+R.resistencia;

            if(potenciaMax < R.potenciaMax)
                rSerie.potenciaMax = potenciaMax;
           
            else
                rSerie.potenciaMax = R.potenciaMax;

            return rSerie;

        }

        public Resistor resistorParalelo(Resistor R)
        {
            Resistor rParalelo = new Resistor();

            rParalelo.resistencia = (resistencia * R.resistencia)/(resistencia + R.resistencia);

            if (potenciaMax < R.potenciaMax)
                rParalelo.potenciaMax = potenciaMax;

            else
                rParalelo.potenciaMax = R.potenciaMax;

            return rParalelo;

        }

        public void imprimeResistor(Resistor r2)
        {
            Console.WriteLine("Dados do resistor r1:");
            Console.WriteLine("Resistência: " + resistencia);
            Console.WriteLine("Potência máxima: " + potenciaMax);
            Console.WriteLine("\n");

            Console.WriteLine("Dados do resistor r2:");
            Console.WriteLine("Resistência: " + r2.resistencia);
            Console.WriteLine("Potência máxima: " + r2.potenciaMax);
            Console.WriteLine("\n");

            Console.WriteLine("Dados do resistor equivalente da associação em série de r1 e r2:");
            Console.WriteLine("Resistência: " + resistorSerie(r2).resistencia);
            Console.WriteLine("Potência máxima: " + resistorSerie(r2).potenciaMax);
            Console.WriteLine("\n");

            Console.WriteLine("Dados do resistor equivalente da associação em paralelo de r1 e r2:");
            Console.WriteLine("Resistência: " + resistorParalelo(r2).resistencia);
            Console.WriteLine("Potência máxima: " + resistorParalelo(r2).potenciaMax);
            Console.ReadLine();
        }


        public double Resistencia { get => resistencia; set => resistencia = value; }
        public double PotenciaMax { get => potenciaMax; set => potenciaMax = value; }
    }//Fim da classe resistor
}
