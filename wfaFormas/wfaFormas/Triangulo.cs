using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wfaFormas
{
    internal class Triangulo:Formas
    {
        //atributos
        private double baseT;
        private double altura;

        //métodos
        public Triangulo() : base() { }

        public Triangulo(string _nome, double _baseT, double _altura) : base(_nome)
        {
            baseT = _baseT;
            altura = _altura;
        }

        public override double calcArea()
        {
            return (baseT * altura)/2;
        }

        //getters & setters
        public double BaseT { get => baseT; set => baseT = value; }
        public double Altura { get => altura; set => altura = value; }

    }//fim da classe triangulo
}

