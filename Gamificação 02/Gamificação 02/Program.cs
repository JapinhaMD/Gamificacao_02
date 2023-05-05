// See https://aka.ms/new-console-template for more information
using Gamificacao_02;
using System.ComponentModel.Design;
using System.Runtime.InteropServices;
using System.Collections.Generic;

class Program
{


    static void Main(string[] args)
    {

        Menu menu = new Menu();
        CarrinhoDeCompras carrinho = new CarrinhoDeCompras();
        Promocao promocoes = new Promocao();
        Camisetas camiseta = new Camisetas();
        Calcas calca = new Calcas();
        Sapatos sapato = new Sapatos();
        Bolsas bolsa = new Bolsas();
       

        bool continuar = true;
        do
        {

            menu.MenuPrincipal();

            string opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":

                    menu.MenuCamiseta();
                    camiseta.Camiseta(carrinho);

                    break;
                    

                case "2":

                    menu.MenuCalca();
                    calca.Calca(carrinho);
                  
                    break;


                case "3":

                    menu.MenuSapato();
                    sapato.Sapato(carrinho);

                    break;


                case "4":

                    menu.MenuBolsa();
                    bolsa.Bolsa(carrinho);
                           
                    break;


                case "5":
                    carrinho.MostrarCarrinho();
                    break;
                case "0":
                    continuar = false;
                    break;
            }
        } while (continuar);

        // Aplicar Promoções desejadas

        // Alterar promocoes 
        Promocao promocaocamiseta = new Promocao
        {
            Categoria = CategoriaProduto.Camiseta,
            Desconto = Promocao.TipoDesconto.Porcentagem,
            ValorDesconto = 10.0
        };

        Promocao promocaocalca = new Promocao
        {
            Categoria = CategoriaProduto.Calca,
            Desconto = Promocao.TipoDesconto.Porcentagem,
            ValorDesconto = 15.0
        };

        Promocao promocaosapato = new Promocao
        {
            Categoria = CategoriaProduto.Sapato,
            Desconto = Promocao.TipoDesconto.Porcentagem,
            ValorDesconto = 20.0
        };

        Promocao promocaobolsa = new Promocao
        {
            Categoria = CategoriaProduto.Bolsa,
            Desconto = Promocao.TipoDesconto.Porcentagem,
            ValorDesconto = 10.0
        };

        carrinho.AplicarPromocao(promocaocamiseta);
        carrinho.AplicarPromocao(promocaocalca);
        carrinho.AplicarPromocao(promocaosapato);
        carrinho.AplicarPromocao(promocaobolsa);

        double totalCompra = carrinho.CalcularValorTotal();
        Console.WriteLine($"Valor total da compra: R${totalCompra}");
    }
}










