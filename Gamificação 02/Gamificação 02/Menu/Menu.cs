using System;

namespace Gamificacao_02
	{
    // Menus e Submenus
	public class Menu
	{

        public void MenuPrincipal()
        {
            Console.WriteLine("|Menu|");
            Console.WriteLine("1 - Camisetas ");
            Console.WriteLine("2 - Calcas ");
            Console.WriteLine("3 - Sapatos ");
            Console.WriteLine("4 - Bolsas ");
            Console.WriteLine("5 - Carrinho de Compras ");
            Console.WriteLine("0 - Finalizar Compra");
            Console.WriteLine();
        }


        public void MenuCamiseta()
		{
           Console.WriteLine("|Camisetas|");
           Console.WriteLine("1 - Camiseta Azul: R$ 70.00");
           Console.WriteLine("2 - Camiseta Branca: R$ 70.00");
           Console.WriteLine("3 - Camiseta Estampada: R$ 100.00");
           Console.WriteLine("4 - Ver Promocoes");
           Console.WriteLine("0 - Voltar ao Menu");
           Console.WriteLine();

		}


        public void MenuCalca()
        {
            Console.WriteLine("|Calças|");
            Console.WriteLine("1 - Calça Jeans: R$ 120.00");
            Console.WriteLine("2 - Calça Social: R$ 150.00");
            Console.WriteLine("3 - Ver Promocoes");
            Console.WriteLine("0 - Voltar ao Menu");
            Console.WriteLine();
        }
      

        public void MenuSapato()
        {
            Console.WriteLine("|Sapatos|");
            Console.WriteLine("1 - Sapato Social: R$ 150.00");
            Console.WriteLine("2 - Sapato Casual: R$ 120.00");
            Console.WriteLine("3 - Tenis Corrida: R$ 200.00");
            Console.WriteLine("4 - Ver Promocoes");
            Console.WriteLine("0 - Voltar ao Menu");
            Console.WriteLine();
        }

        public void MenuBolsa() 
        {
            Console.WriteLine("|Bolsas|");
            Console.WriteLine("1 - Bolsa Social: R$ 150.00");
            Console.WriteLine("2 - Bolsa Casual: R$ 100.00");
            Console.WriteLine("3 - Ver Promocoes");
            Console.WriteLine("0 - Voltar ao Menu");
            Console.WriteLine();
        }
	}
}
