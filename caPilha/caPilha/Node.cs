using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caPilhas
{
    internal class Node
    {//Atributos
        private string info;
        protected string* next;
        
     //Métodos
        public Node() { }

        public Node(string _info)
        {
            this.info = _info;
            this.next = null;
        }
        

     //getters & setters
        public string Info { get => info; set => info = value; }
        protected string Next { get => next; set => next = value; }
    }
}
