using GeraEstoque.Models;
using GeraEstoque.Repositories;


namespace GeraEstoque.Screens
{
    public static class CriarProductScreen
    {
        public static void Iniciar(ProductRepository repository)
        {
            Console.Clear();
            MenuScreen.DrawCanvas();

            Console.SetCursorPosition(2, 1);
            Console.WriteLine("Cadastro de Produtos");
            Console.SetCursorPosition(2, 2);
            Console.WriteLine("=====================");

           

            //Product produtos = new Product();

            Console.SetCursorPosition(2, 5);
            Console.Write("Digite o nome do produto: ");
            var nome = Console.ReadLine();//variavel local/temporaria
            Console.SetCursorPosition(2, 6);
            Console.Write("Digite a quantidade em estoque: ");
            var quantidadeEmEstoque = int.Parse(Console.ReadLine());

            Console.SetCursorPosition(2, 7);
            Console.Write("Valor de Compra: ");
            var valorCompra = double.Parse(Console.ReadLine());

            Console.SetCursorPosition(2, 8);
            Console.Write("Valor de Venda: ");
            var valorVenda = double.Parse(Console.ReadLine());

            var Id = Guid.NewGuid().ToString();

            var produto = new Product(nome, quantidadeEmEstoque, valorCompra, valorVenda);

            Console.WriteLine(" Produto cadastrado com sucesso! ");
            repository.Produtos.Add(produto);

            Console.WriteLine(" pressione qualquer tecla para retornar ao menu. ");
            Console.ReadLine();
            

        }


    }
}
