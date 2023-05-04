// See https://aka.ms/new-console-template for more information
using Gamificacao_02;
using System.ComponentModel.Design;
using System.Runtime.InteropServices;

class Program
{


    static void Main(string[] args)
    {

        Menu menu = new Menu();
        CarrinhoDeCompras carrinho = new CarrinhoDeCompras();
        Camisetas camiseta = new Camisetas();
        Calcas calca = new Calcas();
        Sapatos sapato = new Sapatos();
       

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
                    Console.WriteLine("|Bolsas|");
                    Console.WriteLine("1 - Bolsa Social: R$ 150.00");
                    Console.WriteLine("2 - Bolsa Casual: R$ 100.00");
                    Console.WriteLine("3 - Ver Promocoes");
                    Console.WriteLine("0 - Voltar ao Menu");
                    Console.WriteLine();

                    string opcaoBolsa = Console.ReadLine();

                    switch (opcaoBolsa)
                    {
                        case "1":
                            Bolsa bolsasocial = new Bolsa 
                            { 
                                Nome = "Bolsa Social", 
                                Preco = 150.0, 
                                Categoria = CategoriaProduto.Bolsa, 
                                Tamanho = "20", 
                                Cor = "Preto", 
                                Compartimentos = 3 
                            };

                            carrinho.AdicionarProduto(bolsasocial);
                            Console.WriteLine("Bolsa Social adicionada ao carrinho de compras!");
                            Console.WriteLine();
                            break;

                        case "2":
                            Bolsa bolsacasual = new Bolsa
                            { Nome = "Bolsa Casual", 
                                Preco = 100.0, 
                                Categoria = CategoriaProduto.Bolsa, 
                                Tamanho = "18", 
                                Cor = "Rosa", 
                                Compartimentos = 2
                            };

                            carrinho.AdicionarProduto(bolsacasual);
                            Console.WriteLine("Bolsa Casual adicionada ao carrinho de compras!");
                            Console.WriteLine();
                            break;

                        case "3":
                            Console.WriteLine("|Promoções para Bolsas|");
                            Console.WriteLine("15% de desconto para todas as Bolsas");
                            break;

                        case "0":
                            break;
                    }                   
                    break;


                case "5":
                    carrinho.MostrarCarrinho();
                    break;
                case "0":
                    continuar = false;
                    break;
            }
        } while (continuar);


        double totalCompra = carrinho.CalcularValorTotal();
        Console.WriteLine($"Valor total da compra: R${totalCompra}");
    }
}










