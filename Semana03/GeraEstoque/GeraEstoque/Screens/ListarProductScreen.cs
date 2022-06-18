using GeraEstoque.Repositories;
using GeraEstoque.Models;


namespace GeraEstoque.Screens
{
    public class ListarProductScreen
    {

        public static void Iniciar(ProductRepository repository)
        {
            Console.Clear();
            Console.WriteLine("Lista de Produtos Cadastrados.");
            Console.WriteLine("-------------------------------");
            foreach (var product in repository.Produtos)
            {
                Console.WriteLine(product.ToString());
            }
            Console.ReadLine();
        }



    }
}
