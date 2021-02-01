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
        public Loja(string nome, string cnpj, List<Livro> livros, List<VideoGame> videogames) { }
    }
}
