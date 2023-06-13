using Gamificacao_02;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Gamificacao_02.Promocao;

namespace Gamificação_02
{
    public class PromocaoUI
    {
        public static void GerenciarPromocoes(CarrinhoUI carrinho)
        {
            bool continuar = true;
            do
            {
                Console.Clear();
                Console.WriteLine("1 - Cadastrar promocao");
                Console.WriteLine("2 - Ver promocoes");
                Console.WriteLine("0 - Voltar");
                Console.Write("Escolha uma opção: ");
                string opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        CadastrarPromocao();
                        break;
                    case "2":
                        VerPromocao(carrinho);
                        break;

                    case "0":
                        continuar = false;
                        break;
                    default:
                        Console.WriteLine("Opção inválida!");
                        break;

                }
                Console.WriteLine("Pressione qualquer tecla para continuar...");
                Console.ReadKey();
                Console.Clear();
            } while (continuar);
        }

     
        private static void CadastrarPromocao()
        {
            Console.WriteLine("  |Cadastro de Promocao| ");
            Console.WriteLine("Informe o Tipo da Promocao: ");
            Console.WriteLine("0 - Porcentagem ");
            Console.WriteLine("1 - Valor Fixo ");
            
            int tipo = int.Parse(Console.ReadLine());
            TipoDesconto tipoDesconto = (TipoDesconto)tipo;

            Console.WriteLine("Informe o Valor da Promocao: ");
            double valorDesconto = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe a Categoria da Promocao: ");
            Console.WriteLine("0 - Camiseta");
            Console.WriteLine("1 - Calca");
            Console.WriteLine("2 - Sapato");
            Console.WriteLine("3 - Bolsa");
            Console.WriteLine("4 - Acessorio");
            int categ = int.Parse(Console.ReadLine());
            CategoriaProduto categoria = (CategoriaProduto)categ;
            
            

            Promocao novaPromocao = new Promocao(valorDesconto, tipoDesconto, categoria);
            
            
            promocoes.Add(novaPromocao);
        }

        private static void VerPromocao(CarrinhoUI carrinho)
        {
          foreach(var promocao in promocoes)
            {
                Console.WriteLine($"Tipo: {promocao.Desconto} | Valor: {promocao.ValorDesconto} | Categoria: {promocao.CategoriaP}");
            }
        }


    }
}

