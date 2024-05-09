using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarrinhoDeCompra
{
    public class Pedido
    {
        public List<Produto> produtosCarrinho = new();
        public double totalCarrinho = 0;
        public bool statusCompra = false;
        public Pedido instance = null;

        public Pedido() { }

        public Pedido GetInstance()
        {
            if (instance == null)
            {
                return instance = new Pedido();
            }
            return instance;
        }

        public void AddProduto(Produto produto)
        {
            produtosCarrinho.Add(produto);
        }

        public void CalcularTotal()
        {
            foreach (var item in produtosCarrinho)
            {
                totalCarrinho += item.Preco;
            }
            Console.WriteLine(totalCarrinho);
        }

        public void ProcessarPedido()
        {
            statusCompra = true;
            Console.WriteLine($"O pagamento de R${totalCarrinho} foi realizado com sucesso.");
        }

        public void EntregarPedido()
        {
            if (statusCompra == true)
            {
                Console.WriteLine("O pedido pode ser entregue.");
            }
            else
            {
                Console.WriteLine("Favor realizar o pagamento para a entrega do pedido.");
            }
        }

        public void BaixarProduto()
        {
            if (statusCompra == true)
            {
                Console.WriteLine("O pedido pode ser baixado.");
            }
            else
            {
                Console.WriteLine("Favor realizar o pagamento.");
            }
        }

    }
}
