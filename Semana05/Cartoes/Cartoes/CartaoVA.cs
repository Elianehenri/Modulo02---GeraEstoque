using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cartoes
{
    class CartaoVA : Cartao
    {
        //consturores
        public CartaoVA()
        {
        }

         public CartaoVA(string bandeira, double saldo, double valorTaxa): base(bandeira, saldo, valorTaxa)
        {
        }

        public override double VerificarValorTaxaCartao()
        {
           const double taxaVA = 0.05;
            return Saldo * taxaVA;
        }

    }
}
