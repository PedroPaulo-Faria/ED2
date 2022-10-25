using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetoAtendimento
{
    class Senhas
    {
        private int proximoAtendimento;
        private Queue<Senha> filaSenhas;

        public Senhas()
        {
            proximoAtendimento = 1;
            filaSenhas = new Queue<Senha>();
        }

        public void gerar()
        {
            Senha senha = new Senha(proximoAtendimento);
            filaSenhas.Enqueue(senha);
            proximoAtendimento++;

        }       
        public Queue<Senha> FilaSenhas
        {
            get { return filaSenhas; }
            set { filaSenhas = value; }
        }

        public int ProximoAtendimento
        {
           get { return proximoAtendimento; }
           set { proximoAtendimento = value; }
        }

    }
}
