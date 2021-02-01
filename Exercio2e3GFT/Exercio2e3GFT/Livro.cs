using System;
using System.Collections.Generic;
using System.Text;

namespace Exercio2e3GFT
{
    public class Livro : Produto
    {
        public string autor;
        public string tema;
        public int qtdPag;
        public Livro() {
        
        }
        public Livro(string nome, double preco, int qtd, string autor, string tema, int qtdPag)
        {
            this.Nome = nome;
            this.Preco = preco;
            this.Qtd = qtd;
            this.Autor = autor;
            this.Tema = tema;
            this.QtdPag = qtdPag;
        }
        public string Autor
        {
            get { return autor; }
            set { autor = value; }
        }
        public string Tema
        {
            get { return tema; }
            set { tema = value; }
        }
        public int QtdPag
        {
            get { return qtdPag; }
            set { qtdPag = value; }
        }
    }
}
