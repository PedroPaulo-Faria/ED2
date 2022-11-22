using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleAcesso.Models
{
    class Usuario
    {
        private int id;
        private string nome;
        private List<Ambiente> ambientes;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public List<Ambiente> Ambientes
        {
            get { return ambientes; }
            set { ambientes = value; }
        }


        public bool concederPermissao(Ambiente ambiente)
        {
            bool suc = true;
            foreach (Ambiente a in ambientes)
            {
                if (a.Nome == ambiente.Nome)
                {
                    suc = false;
                }

            }
            if(suc == true)
            {
                ambientes.Add(ambiente);
            }
            return suc;
        }

        public bool revogarPermissao(Ambiente ambiente)
        {
            bool suc = false;
            foreach (Ambiente a in ambientes)
            {
                if (a.Nome == ambiente.Nome)
                {
                    ambientes.Remove(a);
                    suc = true;
                }
            }

            return suc;

        }



    }
}
