using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleAcesso.Models
{
    class Log
    {
        private DateTime dtAcesso;
        private Usuario usuario;
        private bool tipoAcesso;

        public DateTime DtAcesso
        {
            get { return dtAcesso; }
            set { dtAcesso = value; }
        }

        public Usuario Usuario
        {
            get { return usuario; }
            set { usuario = value; }
        }

        public bool TipoAcesso
        {
            get { return tipoAcesso; }
            set { tipoAcesso = value; }
        }

        public Log(DateTime d, Usuario u, bool t)
        {
            dtAcesso = d;
            usuario = u;
            tipoAcesso = t;

        }
    }
}
