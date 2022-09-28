using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda
{
    class Telefone
    {
        private string tipo;
        private string numero;
        private bool principal;

        public Telefone()
        {
            tipo = "";
            numero = "";
            principal = false;
        }
        public string Tipo
        {
            get
            {
                return tipo;
            }
            set
            {
                tipo = value;
            }
        }
        public string Numero
        {
            get
            {
                return numero;
            }
            set
            {
                numero = value;
            }
        }
        public bool Principal
        {
            get
            {
                return principal;
            }
            set
            {
                principal = value;
            }
        }
    }
}
