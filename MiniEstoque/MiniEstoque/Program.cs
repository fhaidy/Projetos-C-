using System;
using System.Globalization;

namespace MiniEstoque {
    class Program {
        static void Main(string[] args) {

            Produto produto = new Produto();

            Console.WriteLine("Entre os dados do produto:");
            Console.Write("Nome: ");
            produto.Nome = Console.ReadLine();
            Console.Write("Preço: ");
            produto.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade no Estoque: ");
            produto.Quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine("\nDados do produto: " + produto);

            Console.Write("\nDigite o nº de produtos a ser adicionado no estoque: ");
            produto.AdicionarProdutos(int.Parse(Console.ReadLine()));
            Console.WriteLine("\nDados Atualizado: " + produto);

            Console.Write("\nDigite o nº de produtos a ser removido no estoque: ");
            produto.RemoverProdutos(int.Parse(Console.ReadLine()));
            Console.WriteLine("\nDados Atualizado: " + produto);

        }
    }
}
