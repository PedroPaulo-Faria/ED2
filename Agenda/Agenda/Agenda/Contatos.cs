using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda
{
    class Contatos
    {
        private List<Contato> agenda;

        public List<Contato> Agenda
        {
            get { return agenda; }
            set { agenda = value; }
        }

        public Contatos(int tam)
        {
            agenda = new List<Contato>();
        }


        public bool adicionar(Contato con)
        {
            bool podeAdicionar = false;

            foreach (Contato c in agenda)
            {
                if (c.Nome == con.Nome)
                {
                    podeAdicionar = true;
                }
            }
            if (podeAdicionar == false)
            {
                agenda.Add(con);
            }

            return podeAdicionar;
        }

        public Contato pesquisar(Contato con)
        {
            Contato achado = new Contato();
            Boolean achou = false;

            foreach (Contato c in agenda)
            {
                achou = c.Equals(con);
                if (achou == true)
                {
                    achado = c;
                    achou = false;
                }
            }

            return achado;
        }

        public bool remover(Contato con)
        {
            Contato achado = new Contato();
            bool achou = false;
            foreach (Contato c in agenda)
            {
                if (c.Equals(con))
                {
                    achado = c;
                    achou = true;
                }
            }

            if (achou == true)
            {
                agenda.Remove(achado);
            }
            return achou;
        }

        public bool alterar(Contato con)
        {
            bool achou = false;
            foreach (Contato c in agenda)
            {
                if (c.Equals(con))
                {
                    c.Nome = con.Nome;
                    c.Telefones = con.Telefones;
                    c.Email = con.Email;
                    c.DtNasc = con.DtNasc;
                    achou = true;
                }
            }
            return achou;
        }

    }
}
