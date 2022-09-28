using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda
{
    class Data
    {
        private int dia;
        private int mes;
        private int ano;


        public Data()
        {
            dia = 1;
            mes = 1;
            ano = 1900;
        }

        public void setData(int d, int m, int a)
        {
            this.dia = d;
            this.mes = m;
            this.ano = a;
        }

        public override string ToString()
        {
            DateTime a = new DateTime(ano, mes, dia);
            string sa = a.ToString("dd/MM/yyyy");
            return sa;
        }

        public int Dia
        {
            get { return dia; }
            set { dia = value; }
        }

        public int Mes
        {
            get { return mes; }
            set { mes = value; }
        }

        public int Ano
        {
            get { return ano; }
            set { ano = value; }
        }
    }
}
