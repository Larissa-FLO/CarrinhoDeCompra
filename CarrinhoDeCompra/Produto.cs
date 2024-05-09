using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarrinhoDeCompra
{
    public class Produto
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public double Preco { get; set; }
        private static int UltimoCodigo = 1;
        public static List<Produto> Produtos = new();

        public Produto(string descricao, double preco) 
        {
            Id = UltimoCodigo;
            Descricao = descricao;
            Preco = preco;
        }

        public Produto ShallowCopy()
        {
            return (Produto)MemberwiseClone();
        }

        public static void CadastrarProduto()
        {
            Produto produto = new Produto("Impressora", 350.58);
            produto.Id = UltimoCodigo;
            Console.WriteLine($"Produto cadastrado com sucesso: \n " +
                $"{produto.Id}: {produto.Descricao} - {produto.Preco}");
            Produtos.Add(produto);
            UltimoCodigo++;
        }

    }
}
