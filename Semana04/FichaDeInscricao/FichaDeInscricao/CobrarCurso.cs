

namespace FichaDeInscricao
{
    internal class CobrarCurso
    {
        private double valorCurso;
        private double valorMulta;
        private double valorDesconto;
        private double resultado;

        public CobrarCurso(double valorCurso, double valorMulta, double valorDesconto)
        {
            this.valorCurso = valorCurso;
            this.valorMulta = valorMulta;
            this.valorDesconto = valorDesconto;
        }

        public double ValorCurso { get; set; }
        public double ValorMulta { get; set; }
        public double ValorDesconto { get; set; }
        public double Resultado { get => this.resultado; }

        public void CalcularResultado()
        {
            resultado = valorMulta > 0 ? valorCurso + valorMulta : valorCurso - valorDesconto;
        }
    }
}
