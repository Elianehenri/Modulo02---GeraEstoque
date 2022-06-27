

namespace FichaDeInscricao
{
    internal class CobrarCurso
    { //exercicio 06
        private double valorCurso;
        private double valorMulta;
        private double valorDesconto;
        private double resultado;
        ////exercicio 07
        public CobrarCurso(double valorCurso, double valorMulta, double valorDesconto)
        {
            this.valorCurso = valorCurso;
            this.valorMulta = valorMulta;
            this.valorDesconto = valorDesconto;
        }

       
        //exercicio 08
        public void CalcularResultado()
        {
            resultado = valorMulta > 0 ? valorCurso + valorMulta : valorCurso - valorDesconto;
        }
    }
}
