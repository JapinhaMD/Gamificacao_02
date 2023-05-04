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


        double totalCompra = carrinho.CalcularValorTotal();
        Console.WriteLine($"Valor total da compra: R${totalCompra}");
    }
}










