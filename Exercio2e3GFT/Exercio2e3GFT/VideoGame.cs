using System;
using System.Collections.Generic;
using System.Text;

namespace Exercio2e3GFT
{
    public class VideoGame : Produto
    {
        public string marca;
        public string modelo;
        public bool isUsado;

        public VideoGame() { }
        public VideoGame(string nome, double preco, int qtd, string marca, string modelo, bool isUsado) {
            this.Nome = nome;
            this.Preco = preco;
            this.Qtd = qtd;
            this.Marca = marca;
            this.Modelo = modelo;
            this.IsUsado = isUsado;
        }
        public string Marca
        {
            get { return marca; }
            set { marca = value; }
        }
        public string Modelo
        {
            get { return modelo; }
            set { modelo = value; }
        }
        public bool IsUsado
        {
            get { return isUsado; }
            set { isUsado = value; }
        }

    }
}
