// See https://aka.ms/new-console-template for more information
using Gamificação_02;


class Program
{


    static void Main(string[] args)
    {

        CarrinhoDeCompras carrinho = new CarrinhoDeCompras();

        bool continuar = true;
        do
        {

            Console.WriteLine("|Menu|");
            Console.WriteLine("1 - Camisetas ");
            Console.WriteLine("2 - Calcas ");
            Console.WriteLine("3 - Sapatos ");
            Console.WriteLine("4 - Bolsas ");
            Console.WriteLine("5 - Carrinho de Compras ");
            Console.WriteLine("0 - Finalizar Compra");
            Console.WriteLine();

            string opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    Console.WriteLine("|Camisetas|");
                    Console.WriteLine("1 - Camiseta Azul: R$ 70.00");
                    Console.WriteLine("2 - Camiseta Branca: R$ 70.00");
                    Console.WriteLine("3 - Camiseta Estampada: R$ 100.00");
                    Console.WriteLine("4 - Ver Promocoes");
                    Console.WriteLine("0 - Voltar ao Menu");
                    Console.WriteLine();

                    string opcaoCamiseta = Console.ReadLine();

                    switch (opcaoCamiseta)
                    {
                        case "1":
                            Produto camisetaazul = new Produto { Nome = "Camiseta Azul", Preco = 70.0, Categoria = CategoriaProduto.Camiseta };
                            carrinho.AdicionarProduto(camisetaazul);
                            Console.WriteLine("Camiseta Azul adicionada ao carrinho de compras!");
                            Console.WriteLine();
                            break;

                        case "2":
                            Produto camisetabranca = new Produto { Nome = "Camiseta Branca", Preco = 70.0, Categoria = CategoriaProduto.Camiseta };
                            carrinho.AdicionarProduto(camisetabranca);
                            Console.WriteLine("Camiseta Branca adicionada ao carrinho de compras!");
                            Console.WriteLine();
                            break;

                        case "3":
                            Produto camisetaestampada = new Produto { Nome = "Camiseta Estampada", Preco = 100.0, Categoria = CategoriaProduto.Camiseta };
                            carrinho.AdicionarProduto(camisetaestampada);
                            Console.WriteLine("Camiseta Estampada adicionada ao carrinho de compras!");
                            Console.WriteLine();
                            break;

                        case "4":
                            Console.WriteLine("|Promoções para Camisetas|");
                            Console.WriteLine("10% de desconto para todas as Camisetas");
                            break;


                        case "0":
                            break;
                    }
                    break;
                    

                case "2":
                    Console.WriteLine("|Calças|");
                    Console.WriteLine("1 - Calça Jeans: R$ 120.00");
                    Console.WriteLine("2 - Calça Social: R$ 150.00");
                    Console.WriteLine("3 - Ver Promocoes");
                    Console.WriteLine("0 - Voltar ao Menu");
                    Console.WriteLine();

                    string opcaoCalca = Console.ReadLine();

                    switch (opcaoCalca)
                    {
                        case "1":
                            Produto calcaJeans = new Produto { Nome = "Calca Jeans", Preco = 120.0, Categoria = CategoriaProduto.Calca };
                            carrinho.AdicionarProduto(calcaJeans);
                            Console.WriteLine("Calca Jeans adicionada ao carrinho de compras!");
                            Console.WriteLine();
                            break;

                        case "2":
                            Produto calcaSocial = new Produto { Nome = "Calca Social", Preco = 150.0, Categoria = CategoriaProduto.Calca };
                            carrinho.AdicionarProduto(calcaSocial);
                            Console.WriteLine("Calca Social adicionada ao carrinho de compras!");
                            Console.WriteLine();
                            break;

                        case "3":
                            Console.WriteLine("|Promoções para Calcas|");
                            Console.WriteLine("20% de desconto para todas as Calcas");
                            break;

                        case "0":
                            break;
                    }
                    break;


                case "3":
                    Console.WriteLine("|Sapatos|");
                    Console.WriteLine("1 - Sapato Social: R$ 150.00");
                    Console.WriteLine("2 - Sapato Casual: R$ 120.00");
                    Console.WriteLine("3 - Tenis Corrida: R$ 200.00");
                    Console.WriteLine("4 - Ver Promocoes");
                    Console.WriteLine("0 - Voltar ao Menu");
                    Console.WriteLine();

                    string opcaoSapato = Console.ReadLine();

                    switch (opcaoSapato)
                    {
                        case "1":
                            Sapato sapatoSocial = new Sapato { Nome = "Sapato Social", Preco = 150.0, Categoria = CategoriaProduto.Sapato, Tamanho = "39", Cor = "Preto", Material = "Couro" };
                            carrinho.AdicionarProduto(sapatoSocial);
                            Console.WriteLine("Sapato Social adicionado ao carrinho de compras!");
                            Console.WriteLine();
                            break;

                        case "2":
                            Sapato sapatoCasual = new Sapato { Nome = "Sapato Casual", Preco = 120.0, Categoria = CategoriaProduto.Sapato, Tamanho = "40", Cor = "Branco", Material = "Couro" };
                            carrinho.AdicionarProduto(sapatoCasual);
                            Console.WriteLine("Sapato Casual adicionado ao carrinho de compras!");
                            Console.WriteLine();
                            break;

                        case "3":
                            Sapato tenisCorrida = new Sapato { Nome = "Tenis Corrida", Preco = 200.0, Categoria = CategoriaProduto.Sapato, Tamanho = "40", Cor = "Preto", Material = "Couro" };
                            carrinho.AdicionarProduto(tenisCorrida);
                            Console.WriteLine("Tenis de Corrida adicionado ao carrinho de compras!");
                            Console.WriteLine();
                            break;

                        case "4":
                            Console.WriteLine("|Promoções para Sapatos|");
                            Console.WriteLine("10% de desconto para todos os Sapatos");
                            break;

                        case "0":
                            break;
                    }
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
                            Bolsa bolsasocial = new Bolsa { Nome = "Bolsa Social", Preco = 150.0, Categoria = CategoriaProduto.Bolsa, Tamanho = "20", Cor = "Preto", Compartimentos = 3 };
                            carrinho.AdicionarProduto(bolsasocial);
                            Console.WriteLine("Bolsa Social adicionada ao carrinho de compras!");
                            Console.WriteLine();
                            break;

                        case "2":
                            Bolsa bolsacasual = new Bolsa { Nome = "Bolsa Casual", Preco = 100.0, Categoria = CategoriaProduto.Bolsa, Tamanho = "18", Cor = "Rosa", Compartimentos = 2};
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


        //Promocao promocaocamiseta = new Promocao
        //{
        //    Categoria = CategoriaProduto.Camiseta,
        //   Desconto = Promocao.TipoDesconto.Porcentagem,
        //    ValorDesconto = 10.0
        //};
        
        //promocoes.Add( promocaocamiseta );


        double totalCompra = carrinho.CalcularValorTotal();
        Console.WriteLine($"Valor total da compra: R${totalCompra}");
    }
}










