
namespace projetoAtendimento
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.gerarSenha = new System.Windows.Forms.Button();
            this.listarSenhas = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.senhasLista = new System.Windows.Forms.RichTextBox();
            this.senhasAtendidas = new System.Windows.Forms.RichTextBox();
            this.listarAtendimentos = new System.Windows.Forms.Button();
            this.addGuiche = new System.Windows.Forms.Button();
            this.qtGuiche = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.chamarGuiche = new System.Windows.Forms.TextBox();
            this.btn_chamarGuiche = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // gerarSenha
            // 
            this.gerarSenha.Location = new System.Drawing.Point(90, 59);
            this.gerarSenha.Name = "gerarSenha";
            this.gerarSenha.Size = new System.Drawing.Size(75, 23);
            this.gerarSenha.TabIndex = 0;
            this.gerarSenha.Text = "Gerar";
            this.gerarSenha.UseVisualStyleBackColor = true;
            this.gerarSenha.Click += new System.EventHandler(this.gerarSenha_Click);
            // 
            // listarSenhas
            // 
            this.listarSenhas.Location = new System.Drawing.Point(75, 270);
            this.listarSenhas.Name = "listarSenhas";
            this.listarSenhas.Size = new System.Drawing.Size(115, 23);
            this.listarSenhas.TabIndex = 1;
            this.listarSenhas.Text = "Listar senhas";
            this.listarSenhas.UseVisualStyleBackColor = true;
            this.listarSenhas.Click += new System.EventHandler(this.listarSenhas_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(245, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Qtde de guichês";
            // 
            // senhasLista
            // 
            this.senhasLista.Location = new System.Drawing.Point(45, 88);
            this.senhasLista.Name = "senhasLista";
            this.senhasLista.Size = new System.Drawing.Size(169, 176);
            this.senhasLista.TabIndex = 4;
            this.senhasLista.Text = "";
            // 
            // senhasAtendidas
            // 
            this.senhasAtendidas.Location = new System.Drawing.Point(358, 88);
            this.senhasAtendidas.Name = "senhasAtendidas";
            this.senhasAtendidas.Size = new System.Drawing.Size(309, 176);
            this.senhasAtendidas.TabIndex = 5;
            this.senhasAtendidas.Text = "";
            // 
            // listarAtendimentos
            // 
            this.listarAtendimentos.Location = new System.Drawing.Point(422, 270);
            this.listarAtendimentos.Name = "listarAtendimentos";
            this.listarAtendimentos.Size = new System.Drawing.Size(190, 23);
            this.listarAtendimentos.TabIndex = 6;
            this.listarAtendimentos.Text = "Listar Atendimentos";
            this.listarAtendimentos.UseVisualStyleBackColor = true;
            this.listarAtendimentos.Click += new System.EventHandler(this.listarAtendimentos_Click);
            // 
            // addGuiche
            // 
            this.addGuiche.Location = new System.Drawing.Point(249, 206);
            this.addGuiche.Name = "addGuiche";
            this.addGuiche.Size = new System.Drawing.Size(75, 23);
            this.addGuiche.TabIndex = 7;
            this.addGuiche.Text = "Adicionar";
            this.addGuiche.UseVisualStyleBackColor = true;
            this.addGuiche.Click += new System.EventHandler(this.addGuiche_Click);
            // 
            // qtGuiche
            // 
            this.qtGuiche.AutoSize = true;
            this.qtGuiche.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qtGuiche.Location = new System.Drawing.Point(271, 141);
            this.qtGuiche.Name = "qtGuiche";
            this.qtGuiche.Size = new System.Drawing.Size(31, 33);
            this.qtGuiche.TabIndex = 8;
            this.qtGuiche.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(378, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Guiche";
            // 
            // chamarGuiche
            // 
            this.chamarGuiche.Location = new System.Drawing.Point(422, 55);
            this.chamarGuiche.Name = "chamarGuiche";
            this.chamarGuiche.Size = new System.Drawing.Size(82, 20);
            this.chamarGuiche.TabIndex = 10;
            // 
            // btn_chamarGuiche
            // 
            this.btn_chamarGuiche.Location = new System.Drawing.Point(510, 54);
            this.btn_chamarGuiche.Name = "btn_chamarGuiche";
            this.btn_chamarGuiche.Size = new System.Drawing.Size(75, 23);
            this.btn_chamarGuiche.TabIndex = 11;
            this.btn_chamarGuiche.Text = "Chamar";
            this.btn_chamarGuiche.UseVisualStyleBackColor = true;
            this.btn_chamarGuiche.Click += new System.EventHandler(this.btn_chamarGuiche_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 389);
            this.Controls.Add(this.btn_chamarGuiche);
            this.Controls.Add(this.chamarGuiche);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.qtGuiche);
            this.Controls.Add(this.addGuiche);
            this.Controls.Add(this.listarAtendimentos);
            this.Controls.Add(this.senhasAtendidas);
            this.Controls.Add(this.senhasLista);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listarSenhas);
            this.Controls.Add(this.gerarSenha);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button gerarSenha;
        private System.Windows.Forms.Button listarSenhas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox senhasLista;
        private System.Windows.Forms.RichTextBox senhasAtendidas;
        private System.Windows.Forms.Button listarAtendimentos;
        private System.Windows.Forms.Button addGuiche;
        private System.Windows.Forms.Label qtGuiche;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox chamarGuiche;
        private System.Windows.Forms.Button btn_chamarGuiche;
    }
}

