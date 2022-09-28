using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda
{
    class Contato
    {
        private string email;
        private string nome;
        private List<Telefone> telefones;
        private Data dtNasc;

        public List<Telefone> Telefones
        {
            get
            {
                return telefones;
            }
            set
            {
                telefones = value;
            }
        }
        public Contato()
        {
            email = "";
            nome = "";
            telefones = new List<Telefone>();
            dtNasc = new Data();
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        public Data DtNasc
        {
            get { return dtNasc; }
            set { dtNasc = value; }
        }

        public int getIdate()
        {
            DateTime hoje = DateTime.Today;
            DateTime nas = DateTime.Parse(DtNasc.ToString());

            int idade = hoje.Year - nas.Year;

            if (hoje.Month <= nas.Month && hoje.Day <= nas.Day)
            {
                idade--;
            }

            return idade;
        }

        public override string ToString()
        {
            return "Nome: " + nome + ", Email: " + email + ", Telefone: " + getTelefonePrincipal() + ", Idade: " + getIdate();
        }

        public override bool Equals(object obj)
        {
            return this.Nome.Equals(((Contato)obj).Nome);
        }

        public void adicionarTelefone(Telefone t)
        {
            if (t.Principal = true)
            {                
                telefones.Add(t);
            }
            else
            {
                t.Principal = false;
                telefones.Add(t);
            }
        }

        public string getTelefonePrincipal()
        {
            List<Telefone> telefone = new List<Telefone>();
            telefone = telefones;
            string principal = "";
            int maximo = telefone.Count();

            for (int i = 0; i < maximo; i++)
            {
                if (telefone[i].Principal == true)
                {
                    principal = telefone[i].Numero;
                    i = maximo;
                }
            }
            return principal;
        }

    }
}
