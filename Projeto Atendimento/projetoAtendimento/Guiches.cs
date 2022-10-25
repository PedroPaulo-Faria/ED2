using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetoAtendimento
{
    class Guiches
    {
        private List<Guiche> listaGuiches;

        public Guiches()
        {
            listaGuiches = new List<Guiche>();
        }

        public void adicionar(Guiche guiche)
        {
            ListaGuiches.Add(guiche);
        }

        public List<Guiche> ListaGuiches
        {
            get { return listaGuiches; }
            set { listaGuiches = value; }
        }

    }
}
