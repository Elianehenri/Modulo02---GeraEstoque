namespace ExercicioSemana04Mod02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        //momento de simular a inscriçao do  curso
        private void btnSalvarDados_Click(object sender, EventArgs e)
        {
            //codigo
            MessageBox.Show("Eliane!!!!");
        }

        private void btnLimparDados_Click(object sender, EventArgs e)
        {
            txtNome.Text = "";
            txtDataDeNascimento.Text = "";
            txtIdade.Text = "";
            txtEscolaridade.Text = "";
            txtCurso.Text = "";
            txtValorCurso.Text = "";
            txtValorDesconto.Text = "";
            txtValorMulta.Text = "";

        }
    }
}