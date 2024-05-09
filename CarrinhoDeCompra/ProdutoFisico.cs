using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarrinhoDeCompra
{
    public class ProdutoFisico : Produto
    {
        public bool entregue = false;
        
        public ProdutoFisico(string descricao, double preco) : base(descricao, preco)
        {

        }

        public void VerificarEntrega()
        {
 
        }

        
    }
}
