﻿using System;

namespace Exercio2e3GFT
{
    class Program
    {
         
        static void Main(string[] args)
        {
            double imposto = 0;
            int opcao = 0;
            string verificausado = "";
            Livro livro = new Livro();
            VideoGame game = new VideoGame();
           
                Console.WriteLine("Adiconar um Livro - Digite 1");
                Console.WriteLine("Adiconar um VideoGame - Digite 2");
                Console.WriteLine("----------------------------------");
                Console.WriteLine("Qual a sua opção? ");
                opcao = Convert.ToInt32(Console.ReadLine());
                switch (opcao)
                {
                    case 1:
                        Console.WriteLine("Qual o nome do Livro: ");
                        livro.Nome = Console.ReadLine();
                        Console.WriteLine("Qual o preço do Livro: ");
                        livro.Preco = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Qual a quantidade de Livros: ");
                        livro.Qtd = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Qual o nome do Autor: ");
                        livro.autor = Console.ReadLine();
                        Console.WriteLine("Qual o tema do Livro: ");
                        livro.Tema = Console.ReadLine();
                        Console.WriteLine("Qual a quantidade de páginas no Livro: ");
                        livro.QtdPag = Convert.ToInt32(Console.ReadLine());
                        imposto = cobrarImposto();
                        Console.WriteLine("Imposto = " + imposto.ToString());
                        break;
                    case 2:
                        Console.WriteLine("Qual o nome do VideoGame: ");
                        game.Nome = Console.ReadLine();
                        Console.WriteLine("Qual o preço do VideoGame: ");
                        game.Preco = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Qual a quantidade de VideoGames: ");
                        game.Qtd = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Qual a marca do VideoGame: ");
                        game.Marca = Console.ReadLine();
                        Console.WriteLine("Qual o modelo do VideoGame: ");
                        game.Modelo = Console.ReadLine();
                        Console.WriteLine("O VideoGame é usado: sim - s ou não - n ");
                        if (verificausado == "s") { game.IsUsado = true; } else { game.IsUsado = false; }
                        imposto = cobrarImposto();
                        Console.WriteLine("Imposto = " + imposto.ToString());
                        break;
                    default:
                    Console.WriteLine("opcao incorreta!!!");
                    break;
                double cobrarImposto()
                {
                    double resultImposto = 0;
                    if (opcao == 1)
                    {   
                        if (livro.tema != "educativo") {
                            resultImposto = (10 * livro.preco) / 100;
                        }
                    }
                    else if (opcao == 2)
                    {
                        if (game.IsUsado)
                        {
                            resultImposto = (25 * game.preco) / 100;
                        }
                        else {
                            resultImposto = (45 * game.preco) / 100;
                        }
                    }
                    return resultImposto;
                }


            }
            Console.ReadKey();
        }
        
    }
}
