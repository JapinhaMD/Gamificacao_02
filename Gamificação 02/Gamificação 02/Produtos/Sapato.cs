using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace Gamificacao_02
{
    class Sapatos
    {
        public string Sapato(CarrinhoDeCompras carrinho)
        {
            string opcaoSapato = Console.ReadLine();

            switch (opcaoSapato)
            {
                case "1":
                    Sapato sapatoSocial = new Sapato
                    {
                        Nome = "Sapato Social",
                        Preco = 150.0,
                        Categoria = CategoriaProduto.Sapato,
                        Tamanho = "39",
                        Cor = "Preto",
                        Material = "Couro"
                    };

                    carrinho.AdicionarProduto(sapatoSocial);
                    Console.WriteLine("Sapato Social adicionado ao carrinho de compras!");
                    Console.WriteLine();
                    break;

                case "2":
                    Sapato sapatoCasual = new Sapato
                    {
                        Nome = "Sapato Casual",
                        Preco = 120.0,
                        Categoria = CategoriaProduto.Sapato,
                        Tamanho = "40",
                        Cor = "Branco",
                        Material = "Couro"
                    };

                    carrinho.AdicionarProduto(sapatoCasual);
                    Console.WriteLine("Sapato Casual adicionado ao carrinho de compras!");
                    Console.WriteLine();
                    break;

                case "3":
                    Sapato tenisCorrida = new Sapato
                    {
                        Nome = "Tenis Corrida",
                        Preco = 200.0,
                        Categoria = CategoriaProduto.Sapato,
                        Tamanho = "40",
                        Cor = "Preto",
                        Material = "Couro"
                    };

                    carrinho.AdicionarProduto(tenisCorrida);
                    Console.WriteLine("Tenis de Corrida adicionado ao carrinho de compras!");
                    Console.WriteLine();
                    break;

                case "4":
                    Console.WriteLine("|Promoções para Sapatos|");
                    Console.WriteLine("20% de desconto para todos os Sapatos");
                    break;

                case "0":
                    break;
            }
            return opcaoSapato;
        }
    }
}