using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarrinhoDeCompra
{
    class Compra
    {
        public Compra() { }

        public Compra(List<Produto> produtos, double total, string status)
        {
            this.produtosCarrinho = produtos;
            this.totalCarrinho = total;
            this.status = status;
        }

        public List<Produto> produtosCarrinho = new();
        public double totalCarrinho { get; set; }
        public string status { get; set; }
    }
}
