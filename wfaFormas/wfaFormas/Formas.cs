using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wfaFormas
{
    public abstract class Formas
    {
        //atributos
        protected string nome;

        //métodos
        public Formas() { }

        public Formas(string _nome)
        {
            nome = _nome;
        }

        public virtual double calcArea()
        {
            return 0.0;
        }

        public virtual double calcPerimetro()
        {
            return 0.0;
        }

        //getters & setters
        public string Nome { get => nome; set => nome = value; }
        
    }//fim da classe formas
}
