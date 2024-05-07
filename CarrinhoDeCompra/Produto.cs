using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarrinhoDeCompra
{
    class Produto
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public double Preco { get; set; }
        public static int UltimoCodigo = 1;

        public static List<Produto> Produtos = new();

        public static void CadastrarProduto()
        {
            Produto produto = new Produto();
            produto.Id = UltimoCodigo;

            Console.WriteLine("Informe a descrição do produto");
            produto.Descricao = Console.ReadLine();
            Console.WriteLine("Informe o preço do produto");
            produto.Preco = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"Produto cadastrado com sucesso: \n {produto.Id}: {produto.Descricao} - {produto.Preco}");
            Produtos.Add(produto);
            UltimoCodigo++;
        }

    }
}
