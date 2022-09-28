using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace Agenda
{
    public partial class Form1 : Form
    {
        Contatos contatos = new Contatos(10);
        Telefone telefone;
        Contato contatoauxtel = new Contato();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonNovo_Click(object sender, EventArgs e)
        {
            textBoxEmail.Text = "";
            textBoxNome.Text = "";
            textBoxDia.Text = "";
            textBoxAno.Text = "";
            textBoxMes.Text = "";
            textBoxNumero.Text = "";
            comboBoxTipo.Text = "";
            checkBoxPrincipal.Checked = false;
            
        }

        private void buttonGravar_Click(object sender, EventArgs e)
        {
            Contato contato = new Contato();
            contato.Nome = textBoxNome.Text;
            contato.Email = textBoxEmail.Text;
            Data data = new Data();
            data.setData(int.Parse(textBoxDia.Text), int.Parse(textBoxMes.Text), int.Parse(textBoxAno.Text));
            contato.DtNasc = data;
            contato.adicionarTelefone(telefone);

            contatos.adicionar(contato);
            contatoauxtel = new Contato();
            textBoxEmail.Text = "";
            textBoxNome.Text = "";
            textBoxDia.Text = "";
            textBoxAno.Text = "";
            textBoxMes.Text = "";
            textBoxNumero.Text = "";
            comboBoxTipo.Text = "";
            checkBoxPrincipal.Checked=false;

        }

        private void buttonAddTel_Click(object sender, EventArgs e)
        {
            Telefone tel = new Telefone();           
            tel.Numero = textBoxNumero.Text;
            tel.Tipo = comboBoxTipo.Text;
            if (checkBoxPrincipal.Checked == true)
            {
                tel.Principal = true;
            }
            else
            {
                tel.Principal= false;
            }
            telefone = tel;
        }

        private void buttonExclui_Click(object sender, EventArgs e)
        {
            Contato contato = new Contato();

            contato.Nome = textBoxNome.Text;
            contato.Email = textBoxEmail.Text;
            bool excluiu = contatos.remover(contato);
            if (excluiu)
            {
                MessageBox.Show("Sucesso!");
            }
            else
            {
                MessageBox.Show("Falha!");
            }

        }

        private void buttonPesquisa_Click(object sender, EventArgs e)
        {
            Contato contato = new Contato();

            contato.Email = textBoxEmail.Text;            

            contato = contatos.pesquisar(contato);            

            if (contato.Email != "")
            {                
                
                textBoxRetorno.Text = contato.ToString();

            }
            else
            {
                MessageBox.Show("Não encontrado!");
            }
        }

        private void buttonListar_Click(object sender, EventArgs e)
        {
            comboBoxList.Items.Clear();
            
            foreach (Contato c in contatos.Agenda)
            {
                if (c.Nome != "")
                {
                    comboBoxList.Items.Add(c.ToString());
                }
            }

        }
    }
}