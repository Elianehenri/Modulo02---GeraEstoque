using GeraEstoque.Repositories;
using GeraEstoque.Screens;
using GeraEstoque.Models;

namespace GeraEstoque.Screens
{
   public static class MenuScreen
    {
        public static void Mostrar(ProductRepository repository)
        {

            Console.Clear();
            DrawCanvas();
          

            Console.SetCursorPosition(5, 2);
            Console.WriteLine("Seja bem vindo(a) ao GeraEstoque 1.0");
            Console.SetCursorPosition(5, 4);
            Console.WriteLine("===================================");
            Console.SetCursorPosition(5, 5);
            Console.WriteLine("1 - Cadastrar Produto");
            Console.SetCursorPosition(5, 6);
            Console.WriteLine("2 - Consultar Produto");
            Console.SetCursorPosition(5, 7);
            Console.WriteLine("3 - Editar Produto");
            Console.SetCursorPosition(5, 8);
            Console.WriteLine("4 - Excluir Produto");
            Console.SetCursorPosition(5, 9);
            Console.WriteLine("5 - Listar Produto");
            Console.SetCursorPosition(5, 10);
            Console.WriteLine("0 - Sair");

            Console.SetCursorPosition(5, 11);
            Console.Write(" Digite a Opçao: ");


            var opcoes = short.Parse(Console.ReadLine());
            switch (opcoes)
            {
                case 1: CriarProductScreen.Iniciar(repository); Mostrar(repository);break;
                case 2: break;
                case 3: break;
                case 4: break;
                case 5: ListarProductScreen.Iniciar(repository); Mostrar(repository);  break;
                case 0: Console.Clear(); Environment.Exit(0); break;

                default:    break;
            }

        }

        public static void DrawCanvas()
        {
            Console.BackgroundColor = ConsoleColor.DarkBlue;

            PrintHorizontalLine();
            for (int i = 0; i < 25; i++)
            {
                Console.Write("|");
                for (int line = 0; line <= 50; line++)
                    Console.Write(" ");

                Console.Write("|");
                Console.Write(Environment.NewLine);
            }
            PrintHorizontalLine();
        }

        internal static void Mostrar()
        {
            throw new NotImplementedException();
        }

        public static void PrintHorizontalLine()
        {
            Console.Write("+");
            for (int i = 0; i <= 50; i++)
                Console.Write("-");

            Console.Write("+");
            Console.Write(Environment.NewLine);
        }

    }
}
