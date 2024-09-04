using System.Drawing;
using System.Windows.Forms;
using System;

namespace ProjetoCalculadora
{
    partial class Form1
    {

        private void AdicionarBotoes()
        {
            AdicionarBotaoNumero("numero 0", "0", new EventHandler(MeuBotao_Click), new Point((0 + 1) * 50 + 50, 50));
            AdicionarBotaoNumero("numero 1", "1", new EventHandler(MeuBotao_Click), new Point((1 + 1) * 50 + 50, 50));
            AdicionarBotaoNumero("numero 2", "2", new EventHandler(MeuBotao_Click), new Point((2 + 1) * 50 + 50, 50));
            AdicionarBotaoNumero("numero 3", "3", new EventHandler(MeuBotao_Click), new Point((3 + 1) * 50 + 50, 50));
            AdicionarBotaoNumero("numero 4", "4", new EventHandler(MeuBotao_Click), new Point((4 + 1) * 50 + 50, 50));
            AdicionarBotaoNumero("numero 5", "5", new EventHandler(MeuBotao_Click), new Point((5 + 1) * 50 + 50, 50));
            AdicionarBotaoNumero("numero 6", "6", new EventHandler(MeuBotao_Click), new Point((6 + 1) * 50 + 50, 50));
            AdicionarBotaoNumero("numero 7", "7", new EventHandler(MeuBotao_Click), new Point((7 + 1) * 50 + 50, 50));
            AdicionarBotaoNumero("numero 8", "8", new EventHandler(MeuBotao_Click), new Point((8 + 1) * 50 + 50, 50));
            AdicionarBotaoNumero("numero 9", "9", new EventHandler(MeuBotao_Click), new Point((9 + 1) * 50 + 50, 50));
        }
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

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>

        private void AdicionarBotaoNumero(string name, string text, EventHandler evento, Point location)
        {
            // Cria uma nova instância do botão
            Button meuBotao = new Button();

            // Define as propriedades do botão
            meuBotao.Name = name;
            meuBotao.Text = text;
            meuBotao.Size = new Size(50, 50);

            meuBotao.Location = location;

            // Adiciona o evento de clique
            meuBotao.Click += new EventHandler(evento);

            // Adiciona o botão ao formulário
            this.Controls.Add(meuBotao);
        }

        private void MeuBotao_Click(object sender, EventArgs e)
        {
            // Recupera o botão que disparou o evento
            Button botaoClicado = sender as Button;

            var textoBotao = botaoClicado.Text;

            // Acessa o Label pelo seu Name e altera o texto
            Label meuTexto = this.Controls["visor"] as Label;
            if (meuTexto != null && textoBotao != "0")
                meuTexto.Text += textoBotao;
        }

        private void AdicionarTexto()
        {
            // Cria uma nova instância do Label
            Label meuTexto = new Label();

            // Define as propriedades do Label
            meuTexto.Name = "visor";
            meuTexto.Text = "";
            meuTexto.Size = new Size(200, 30);
            meuTexto.Location = new Point(50, 120);

            // Adiciona o Label ao formulário
            this.Controls.Add(meuTexto);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 450);
            this.Text = "Form1";

            AdicionarTexto();
            AdicionarBotoes();
        }
    }
}

