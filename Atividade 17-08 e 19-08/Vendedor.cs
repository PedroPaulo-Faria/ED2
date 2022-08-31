using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_17_08_e_19_08
{
    class Vendedor
    {
        private int id;
        private string nome;
        private double percComissao;
        private Venda[] asVendas = new Venda[31];

        public int Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }
        public double PercComissao { get => percComissao; set => percComissao = value; }
        public Venda[] AsVendas { get => asVendas; set => asVendas = value; }

        public Vendedor()
        {
            this.id = -1;
            this.nome = "";
            this.percComissao = 0.0;

            for (int i = 0; i < 31; i++)
            {
                this.asVendas[i] = new Venda();
            }
        }

        public void registrarVenda(int dia, Venda venda)
        {
            asVendas[dia - 1] = venda;
        }

        public double valorVendas()
        {
            double valorTotal = 0.0;

            foreach (Venda v in this.asVendas)
            {
                valorTotal += v.Valor;
            }

            return valorTotal;
        }

        public double valorComissao()
        {
            double valorTotal = 0.0;

            foreach (Venda v in this.asVendas)
            {
                valorTotal += v.Valor;
            }

            valorTotal = valorTotal * 0.1;

            return valorTotal;
        }
    }
}

