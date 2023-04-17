using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wfaPessoaFisicaJuridica
{
    internal class Pessoa
    {
        //Atributos
        protected string nome;
        protected string cidade;



        //Métodos
        public Pessoa() { }

        public Pessoa (string _nome, string _cidade)
        {
            this.nome = _nome;
            this.cidade = _cidade;
        }

        public virtual double CalcCredito()
        {
            return 0.0;
        }
        
        //getters & setters
        public string Nome { get => nome; set => nome = value; }
        public string Cidade { get => cidade; set => cidade = value; }
    }//Fim da classe Pessoa
}
