using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_17_08_e_19_08
{
    class Venda
    {
        private int qtde;
        private double valor;

        public Venda()
        {
            Qtde = 0;
            Valor = 0.0;
        }

        public Venda(int qtde, double valor)
        {
            this.Qtde = qtde;
            this.Valor = valor;
        }

        public int Qtde { get => qtde; set => qtde = value; }
        public double Valor { get => valor; set => valor = value; }

        public double valorMedio()
        {
            return valor / qtde;
        }
    }
}
