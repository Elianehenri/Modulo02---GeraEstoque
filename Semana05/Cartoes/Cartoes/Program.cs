using System.Globalization;
namespace Cartoes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.WriteLine("Exercicios 02 a 04 da Semana 05!");
            Console.WriteLine("********************************");

            
            CartaoVR cartaoVR = new CartaoVR("MasterCard", 2000, 0.0);
            Console.WriteLine($" O cartao VR da Bandeira: { cartaoVR.Bandeira}, tem saldo disponivel de limite { cartaoVR.Saldo.ToString("F2", CultureInfo.InvariantCulture)}  , com uma taxa de {cartaoVR.VerificarValorTaxaCartao().ToString("c")}.");
            Console.WriteLine();     

            CartaoVA cartaoVA = new CartaoVA("Elo", 5500.00, 0.0);
            Console.WriteLine($" O cartao VA da Bandeira: {cartaoVA.Bandeira}, tem saldo disponivel de limite {cartaoVA.Saldo.ToString("F2", CultureInfo.InvariantCulture)}  , com uma taxa de {cartaoVA.VerificarValorTaxaCartao().ToString("c")}.");
            Console.WriteLine();

            CartaoVT cartaoVT = new CartaoVT("HiperCard", 15000.00, 0.0);
            Console.WriteLine($" O cartao VT da Bandeira: {cartaoVT.Bandeira}, tem saldo disponivel de limite {cartaoVT.Saldo.ToString("F2", CultureInfo.InvariantCulture)}  , com uma taxa de {cartaoVT.VerificarValorTaxaCartao().ToString("c")}.");
            Console.WriteLine();

            //upCasting

            Console.WriteLine("UpCasting");
            Cartao cartaoUp1 = new CartaoVT();
            CartaoVT cartaoUp = new CartaoVT();
            Cartao novoCartao = cartaoUp;
            Console.WriteLine(novoCartao == cartaoUp);

            //downCasting
            Console.WriteLine("DownCasting");
            CartaoVT cartaoDown = (CartaoVT)cartaoUp1;
            Console.WriteLine(cartaoDown == cartaoUp1);

        }
    }
}
