using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caRetangulos
{
    internal class Retangulo
    {
        //Atributos
        private double altura;
        private double comprimento;



        //Métodos
        public Retangulo() { }

        public Retangulo (double _altura, double _comprimento)
        {
            altura = _altura;
            comprimento = _comprimento;
        }

        public void mudaAltura(double newAltura)
        {
            altura = newAltura;
        }

        public void mudaComprimento(double newComp)
        {
            comprimento = newComp;
        }

        public double CalcPerimetro()
        {
            return (2 * (altura + comprimento));
        }

        public double CalcArea()
        {
            return (altura * comprimento);
        }

        public void Imprime()
        {
            Console.WriteLine("Altura: " + altura);
            Console.WriteLine("Comprimento: " + comprimento);
            Console.WriteLine("Perímetro: " + CalcPerimetro());
            Console.WriteLine("Área: " + CalcArea());
        }
        
       //getters & setters 
        public double Altura { get => altura; set => altura = value; }
        public double Comprimento { get => comprimento; set => comprimento = value; }

    }//Fim da classe Retângulo
}
