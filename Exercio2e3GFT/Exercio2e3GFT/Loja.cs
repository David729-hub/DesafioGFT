using System;
using System.Collections.Generic;
using System.Text;

namespace Exercio2e3GFT
{
    class Loja
    {
        public string nome;
        public string cnpj;
        public List<Livro> livros;
        public List<VideoGame> videogames;
        public Loja() { }
        public Loja(string nome, string cnpj, List<Livro> livros, List<VideoGame> videogames) {
            this.Nome = nome;
            this.Cnpj = cnpj;
            this.livros = livros; 
            this.videogames = videogames; 
        }
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        public string Cnpj
        {
            get { return cnpj; }
            set { cnpj = value; }
        }
        public void exibirListaLivro() {
            foreach(Livro l in livros) {
                Console.WriteLine(" Nome: " + l.Nome + " Autor: " + l.Autor + " Tema: " + l.Tema + " Paginas " + l.QtdPag);
            }
        }
    }
}
