using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wfaAlunoMateria
{
    internal class aluno
    {
        //atributos
        private string nome;
        private string numero_matricula;
        private int periodo;
        //lista de matérias:
        private Materia[] lista_materias;

        //métodos
        public aluno() { }

        public aluno(string _nome, string _numero_matricula, int _periodo)
        {
            nome = _nome;
            numero_matricula = _numero_matricula;
            periodo = _periodo;
            Materia[] lista_materias = new Materia[10];
        }



        //getters & setters
        public string Nome { get => nome; set => nome = value; }
        public string Numero_matricula { get => numero_matricula; set => numero_matricula = value; }
        public int Periodo { get => periodo; set => periodo = value; }
        public Materia[] Lista_materias { get => lista_materias; set => lista_materias = value; }
    }//fim da classe aluno
}
