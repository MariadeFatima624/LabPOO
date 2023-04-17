using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wfaPessoaFisicaJuridica
{
    internal class PessoaJuridica : Pessoa
    {
        //Atributos
        private string cnpj;
        private int qtdFuncionarios;
        private double faturamento;
        private string nomeFantasia;

        //Métodos
        public PessoaJuridica() : base() { }

        public PessoaJuridica(string _nome, string _cidade, string _cnpj, int _qtdFuncionarios,
                              double _faturamento, string _nomeFantasia)
            : base(_nome,_cidade)
        {
            cnpj = _cnpj;
            qtdFuncionarios = _qtdFuncionarios;
            faturamento = _faturamento;
            nomeFantasia = _nomeFantasia;
        }

        public override double CalcCredito()
        {
            return ((faturamento*12)+(qtdFuncionarios*10));
        }

        //Getters & setters
        public string Cnpj { get => cnpj; set => cnpj = value; }
        public int QtdFuncionarios { get => qtdFuncionarios; set => qtdFuncionarios = value; }
        public double Faturamento { get => faturamento; set => faturamento = value; }
        public string NomeFantasia { get => nomeFantasia; set => nomeFantasia = value; }
    }//Fim da classe PessoaJuridica
}
