

namespace GeraEstoque
{
    public static class CadastrarProdutos
    {
        public static void Start()
        {
            Console.Clear();
            Menu.DrawCanvas();

            Console.SetCursorPosition(2, 1);
            Console.WriteLine("Cadastro de Produtos");
            Console.SetCursorPosition(2, 2);
            Console.WriteLine("=====================");

            CadastrarProduto();
        }
        public static void CadastrarProduto()
        {
            Produtos produtos = new Produtos();

            Console.SetCursorPosition(2, 5);
            Console.Write("Digite o nome do produto: ");
            produtos.Nome = Console.ReadLine();
            Console.SetCursorPosition(2, 6);
            Console.Write("Digite a quantidade em estoque: ");
            produtos.QuantidadeEmEstoque = int.Parse(Console.ReadLine());

            Console.SetCursorPosition(2, 7);
            Console.Write("Valor de Compra: ");
            produtos.ValorCompra = double.Parse(Console.ReadLine());

            Console.SetCursorPosition(2, 8);
            Console.Write("Valor de Venda: ");
            produtos.ValorVenda = double.Parse(Console.ReadLine());

            Console.WriteLine(" Produto cadastrado com sucesso! ");
            Console.WriteLine(" pressione qualquer tecla para retornar ao menu. ");
            Console.ReadLine();
            Menu.Mostrar();
        }

        
    }
}