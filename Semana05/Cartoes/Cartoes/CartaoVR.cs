using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cartoes
{
    class CartaoVR : Cartao
    {
        public CartaoVR()
        {
        }

        public CartaoVR(string bandeira, double saldo, double valorTaxa) : base(bandeira, saldo, valorTaxa)
        {
        }

        public override double VerificarValorTaxaCartao()
        {
            const double taxaVR = 0.08;
            return base.Saldo * taxaVR;
        }
    }
}
