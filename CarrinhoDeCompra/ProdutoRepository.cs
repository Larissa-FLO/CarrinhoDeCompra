using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarrinhoDeCompra
{
    class ProdutoRepository
    {
        private List<Produto> produtos = null;

        private static ProdutoRepository instance = null;

        private ProdutoRepository()
        {
            produtos = new List<Produto>();
        }

        public static ProdutoRepository getInstance()
        {
            if (instance == null)
            {
                instance = new ProdutoRepository();
            }
            return instance;
        }

        public List<Produto> getProdutos()
        {
            return instance.produtos;
        }

        public void addProduto(Produto produto)
        {
            produtos.Add(produto);

        }
    }
}
