using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarrinhoDeCompra
{
    internal class ProdutoDigital : Produto
    {
        public bool baixado = false;

        public ProdutoDigital(string descricao, double preco) : base(descricao, preco)
        {

        }
    }
}
