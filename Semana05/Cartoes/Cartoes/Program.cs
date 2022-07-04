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

            //
            CartaoVR cartaoVR = new CartaoVR("MasterCard", 2000, 0.0);
            Console.WriteLine($" O cartao VR da Bandeira: { cartaoVR.Bandeira}, tem saldo disponivel de limite { cartaoVR.Saldo.ToString("F2", CultureInfo.InvariantCulture)}  , com uma taxa de {cartaoVR.VerificarValorTaxaCartao().ToString("c")}.");
                  
            CartaoVA cartaoVA = new CartaoVA();
            

            CartaoVT cartaoVT = new CartaoVT();
         

        }
    }
}
