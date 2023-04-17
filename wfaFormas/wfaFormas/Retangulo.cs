using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wfaFormas
{
    internal class Retangulo:Formas
    {
        //atributos
        private double baseR;
        private double altura;

        //métodos
        public Retangulo() : base() { }

        public Retangulo(string _nome, double _baseR, double _altura) : base(_nome)
        {
            baseR = _baseR;
            altura = _altura;
        }



        public override double calcArea()
        {
            return baseR*altura;
        }

        public override double calcPerimetro()
        {
            return ((2*baseR)+(2*altura));
        }

        //getters & setters
        public double BaseR { get => baseR; set => baseR = value; }
        public double Altura { get => altura; set => altura = value; }

    }//fim da classe retangulo
}
