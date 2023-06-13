using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gamificação_02;

namespace Gamificacao_02
{
    
    public class CarrinhoDeCompras
    {
        private List<ProdutoModel> produtos = new List<ProdutoModel>();
       

        
        public void AdicionarProduto(ProdutoModel produto)
        {
            produtos.Add(produto);
        }

        
        public void AplicarPromocao(Promocao promocao)
        {
            Promocao.promocoes.Add(promocao);
        }

        
        public double CalcularValorTotal()
        {
            double valorTotal = 0.0;


            foreach (ProdutoModel produto in produtos)
            {

                double valorDesconto = 0.0;
                foreach (Promocao promocao in Promocao.promocoes)
                {
                    if (produto.Categoria == promocao.CategoriaP)
                    {                   
                        valorDesconto += promocao.CalcularValorDesconto(produto.Preco);
                        Console.WriteLine($" Valor Desconto: {valorDesconto}");
                    }
                }
                

                valorTotal += produto.Preco - valorDesconto;
            }

            return valorTotal;
        }

        public void MostrarCarrinho()
        {
            Console.WriteLine("| Carrinho de Compras |");
            Console.WriteLine("Produtos adicionados:");

            foreach (ProdutoModel produto in produtos)
            {
                Console.WriteLine($"{produto.Nome} - {produto.Preco:C}");
            }

            Console.WriteLine($"Total: {CalcularValorTotal():C}");
            Console.WriteLine();
        }

        public bool RemoverProduto(int idProduto)
        {
            ProdutoModel produto = produtos.Find(p => p.ProdutoID == idProduto);

            if (produto != null)
            {
                produtos.Remove(produto);
                return true;
            }

            return false;
        }

    }

}
