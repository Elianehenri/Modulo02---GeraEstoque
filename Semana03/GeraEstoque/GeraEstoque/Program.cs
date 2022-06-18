using GeraEstoque.Repositories;
using GeraEstoque.Screens;



namespace GeraEstoque
{ class Program
    {
        static void Main(string[] args)
        {
            //Menu.Mostrar();
            var repository = new ProductRepository();
            MenuScreen.Mostrar(repository);
        }
    }
}
