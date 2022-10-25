using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projetoAtendimento
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Senhas senhas = new Senhas();
        Guiches guiches = new Guiches();
        Guiche guiche = new Guiche(0);
        
        private void gerarSenha_Click(object sender, EventArgs e)
        {          
            senhas.gerar();
            senhasLista.Text = "Senha gerada.";
        }

        private void listarSenhas_Click(object sender, EventArgs e)
        {
            senhasLista.Clear();
            foreach (Senha s in senhas.FilaSenhas)
            {
               
                senhasLista.Text += s.dadosParciais();
            }

        }

        private void addGuiche_Click(object sender, EventArgs e)
        {
            guiches.adicionar(new Guiche(guiches.ListaGuiches.Count +1));
            qtGuiche.Text = Convert.ToString(guiches.ListaGuiches.Count);
                    
        }

        private void btn_chamarGuiche_Click(object sender, EventArgs e)
        {

            int aux = 0;
            
            int guichePesq = int.Parse(chamarGuiche.Text);
            foreach (Guiche g in guiches.ListaGuiches)
            
            {
               int ident = g.Id;
                if(guichePesq == ident)
                {

                    if (guiche.chamar(senhas.FilaSenhas) == false)
                    {
                                           
                        senhasAtendidas.Text = "Não há mais senhas à espera."; 
                    }
                    else
                    {
                        senhasAtendidas.Text = "O guichê " + Convert.ToString(g.Id) + " foi chamado.";
                    
                    }
                                
                }

                aux = g.Id;
                
            }
            if(guichePesq > aux)
            {
                senhasAtendidas.Text = "Este guiche não existe.";
            }
        }

        private void listarAtendimentos_Click(object sender, EventArgs e)
        {
            senhasAtendidas.Clear();
           foreach(Senha g in guiche.Atendimentos)
            {
       
                
                if(guiche.Atendimentos.Count == 0)
                {
                    senhasAtendidas.Text = "Não há nenhum guiche adicionado.";
                }
                else
                {
                    senhasAtendidas.Text +=  g.dadosCompletos();
                }
            }
        }
    }
}
