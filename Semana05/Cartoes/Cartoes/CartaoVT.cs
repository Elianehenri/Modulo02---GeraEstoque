using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cartoes
{
    class CartaoVT : Cartao
    {
        public CartaoVT()
        {
        }

        public CartaoVT(string bandeira, double saldo, double valorTaxa) : base(bandeira, saldo, valorTaxa)
        {
        }

        public override double VerificarValorTaxaCartao()
        {
            const double taxaVT = 0.10;
            return base.Saldo * taxaVT;
        }
    }
}
