using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetoAtendimento
{
    class Guiche
    {
        private int id;
        private Queue<Senha> atendimentos;


        public Guiche()
        {
            id = 0;
            atendimentos = new Queue<Senha>();
        }

        public Guiche(int id)
        {

            this.id = id;
            atendimentos = new Queue<Senha>();
        }

        public bool chamar(Queue<Senha> filaSenhas)
        {

            if(filaSenhas.Count > 0)
            {

                filaSenhas.First().HoraAtend = DateTime.Now;
                filaSenhas.First().DataAtend = DateTime.Today;
                atendimentos.Enqueue(filaSenhas.First());
                filaSenhas.Dequeue();
                return true;
            }
            else
            {
                return false;
            }
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public Queue<Senha> Atendimentos
        {
            get { return atendimentos; }
            set { atendimentos = value; }
        }


    }




}
