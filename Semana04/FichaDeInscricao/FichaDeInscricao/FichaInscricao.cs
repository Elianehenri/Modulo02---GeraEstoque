

namespace FichaDeInscricao
{
    class FichaInscricao
    {   //exercicio 01
        #region propriedades
        public string Nome { get; set; }
        public int Idade { get; }
        public string Curso { get; set; }
        public string Escolaridade { get; set; }
        public DateTime DataDeNascimento { get; set; }
        public double ValorCurso { get; set; }
        public double ValorDesconto { get; set; }
        public double ValorMulta { get; set; }

        #endregion

        //exercicio 02
        #region construtores
        public FichaInscricao(string nome, string curso, string escolaridade, DateTime dataDeNascimento, double valorCurso, double valorDesconto, double valorMulta)
        {
            Nome = nome;
            Curso = curso;
            Escolaridade = escolaridade;
            DataDeNascimento = dataDeNascimento;
            ValorCurso = valorCurso;
            ValorDesconto = valorDesconto;
            ValorMulta = valorMulta;

            Idade = CalcularIdade();
            #endregion

           

        }
        //exercicio 03
        #region metodo privado calcular idade 

        private int CalcularIdade()
        {
            return DateTime.Now.Year - DataDeNascimento.Year;
        }

        #endregion

    }
}
