using caPilhas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caPilhas
{
    internal class Pilha:Node 
    {
        
        //Atributos
         Node top;
        //Métodos
        public Pilha() : base() { }

        public Pilha(string _info):base( _info)
        {
            this.top = null;
        }

        public void push(string _info)
        {
            Node nAux = new Node(_info);
            nAux.next = this.top;
            this.top = nAux;
        }

        public bool isempty()
        {
            return this.top == null;
        }

        public string pop()
        {
            if (!isempty())
            {
                Node nAuxPop = this.top;
                this.top = nAuxPop.next;
                return nAuxPop.Info;
            }
            else
            {
                Console.WriteLine("Pilha vazia!");
                Console.ReadLine();
                return null;
            }
        }

        public string peek()
        {
            if (!isempty())
            {
                return this.top.Info;
            }
            else
            {
                Console.WriteLine("Pilha vazia!");
                Console.ReadLine();
                return null;
            }
        }



     //getters & setters
        public Node Top { get => top; set => top = value; }
    }
}
