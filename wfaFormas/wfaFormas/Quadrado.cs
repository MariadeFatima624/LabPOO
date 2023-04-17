using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wfaFormas
{
    internal class Quadrado : Formas
    {
        //atributos
        private double lado;

        //métodos
        public Quadrado() : base() { }

        public Quadrado(string _nome, double _lado) : base(_nome)
        {
            lado = _lado;
        }

        public override double calcArea()
        {
            return Math.Pow(lado, 2);
        }

        public override double calcPerimetro()
        {
            return lado * 4;
        }

        //getters & setters
        public double Lado { get => lado; set => lado = value; }
    }//fim da classe quadrado
}
