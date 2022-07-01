namespace FichaDeInscricao.Entities
{
    public class CobrarCurso
    { //exercicio 06

        public double ValorCurso { get; private set; }
        public double ValorMulta { get; private set; }
        public double ValorDesconto { get; private set; }
        public double Resultado { get; set; }

        public CobrarCurso()
        {
        }

        public CobrarCurso(double valorCurso, double valorMulta, double valorDesconto)
        {
            ValorCurso = valorCurso;
            ValorMulta = valorMulta;
            ValorDesconto = valorDesconto;

        }


        ////exercicio 07


        public CobrarCurso(double valorCurso, double valorMulta, double valorDesconto, double resultado)
        {
            ValorCurso = valorCurso;
            ValorMulta = valorMulta;
            ValorDesconto = valorDesconto;
            Resultado = resultado;
        }


        //exercicio 08
        public void CalcularResultado()
        {
            Resultado = ValorMulta > 0 ? ValorCurso + ValorMulta : ValorCurso - ValorDesconto;
        }
    }
}
