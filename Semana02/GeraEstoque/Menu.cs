namespace GeraEstoque
{
    class Menu
    {
        public static void Mostrar()
        {

            Console.Clear();
            DrawCanvas();
            Options();

            var opcoes = short.Parse(Console.ReadLine());
            switch (opcoes)
            {
                case 1: CadastrarProdutos.Start(); break;
                case 2: break;
                case 3: break;
                case 4: break;
                case 0: break;

                default: Mostrar(); break;
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
        public static void PrintHorizontalLine()
        {
            Console.Write("+");
            for (int i = 0; i <= 50; i++)
                Console.Write("-");

            Console.Write("+");
            Console.Write(Environment.NewLine);
        }

        static void Options()
        {
            Console.SetCursorPosition(5, 2);
            Console.WriteLine("Seja bem vindo(a) ao GeraEstoque 1.0");
            Console.SetCursorPosition(5, 4);
            Console.WriteLine("===================================");
            Console.SetCursorPosition(5, 5);
            Console.WriteLine("1 - Cadastrar Produto");
            Console.SetCursorPosition(5, 6);
            Console.WriteLine("2 - Editar Produto");
            Console.SetCursorPosition(5, 7);
            Console.WriteLine("3 - Excluir Produto");
            Console.SetCursorPosition(5, 8);
            Console.WriteLine("0 - Sair");

            Console.SetCursorPosition(5, 11);
            Console.Write(" Digite a Opçao: ");

        }
    }

}
