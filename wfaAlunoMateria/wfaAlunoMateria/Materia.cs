using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wfaAlunoMateria
{
    internal class Materia
    {
        //atributo
        private string nome;
        private string codigo;

        //métodos
        public Materia() { }

        public Materia(string _nome, string _codigo)
        {
            Nome = _nome;
            Codigo = _codigo;
        }



        //getters & setters
        public string Nome { get => nome; set => nome = value; }
        public string Codigo { get => codigo; set => codigo = value; }
    }//fim da classe materia
}
