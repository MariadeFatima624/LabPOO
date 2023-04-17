using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wfaPessoaFisicaJuridica
{
    internal class PessoaFisica : Pessoa
    {
        //Atributos
        private string cpf;
        private int qtdFilhos;
        private double salario;

        //Métodos
        public PessoaFisica() : base() { }

        public PessoaFisica(string _nome, string _cidade, string _cpf, int _qtdFilhos, double _salario) 
            : base( _nome, _cidade)
        {
            cpf = _cpf;
            qtdFilhos = _qtdFilhos;
            salario = _salario;
        }

        public override double CalcCredito()
        {
            return ((salario*12)-(qtdFilhos*10));
        }

        //getters & setters
        public string Cpf { get => cpf; set => cpf = value; }
        public int QtdFilhos { get => qtdFilhos; set => qtdFilhos = value; }
        public double Salario { get => salario; set => salario = value; }
    }//Fim da classe PesoaFisica
}
