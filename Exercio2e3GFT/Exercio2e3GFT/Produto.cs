using System;
using System.Collections.Generic;
using System.Text;

namespace Exercio2e3GFT
{
    public abstract class Produto
    {
        public string nome;
        public double preco;
        public int qtd;

        public Produto() {
        }
        public Produto(string nome, double preco, int qtd) {
            this.Nome = nome;
            this.Preco = preco;
            this.Qtd = qtd;
        }
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        public double Preco
        {
            get { return preco; }
            set { preco = value; }
        }
        public int Qtd
        {
            get { return qtd; }
            set { qtd = value; }
        }


    }
}
