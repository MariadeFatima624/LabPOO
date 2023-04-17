using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wfaFormas
{
    internal class Circulo : Formas
    {
        //atributos
        private double raio;

        //métodos
        public Circulo(): base() { }

        public Circulo(string _nome, double _raio) : base(_nome)
        {
            raio = _raio;
        }


        public override double calcArea()
        {
            return Math.PI*Math.Pow(raio, 2);
        }

        public override double calcPerimetro()
        {
            return 2*Math.PI*raio;
        }

        //getters & setters
        
        public double Raio { get => raio; set => raio = value; }

    }//fim da classe circulo
}
