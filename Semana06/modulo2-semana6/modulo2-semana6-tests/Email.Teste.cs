using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modulo2_semana6_tests
{
    public class Email : ConfiguracaoHostApi
    {
        [Theory]
        [InlineData("eliane@email.com")]
        [InlineData("email@email.com")]
        [InlineData("teste.com")]
        public async Task Teste_Exercicio_6_Validacao_Email_Sucesso(string email)
        {

            var resultado = await client.GetAsync($"/Exercicio4/{email}");
            Assert.NotNull(resultado);

            var responseApi = await resultado.Content.ReadAsStringAsync();

            Assert.NotNull(responseApi);
            Assert.Equal("E-mail válido", responseApi);
        }

        [Theory]
        [InlineData("eliane@email")]
        [InlineData("email.com")]
        [InlineData("teste.com")]
        [InlineData("teste@email.com")]
        public async Task Teste_Exercicio_6_Validacao_Email_Erro(string email)
        {

            var resultado = await client.GetAsync($"/Exercicio4/{email}");
            Assert.NotNull(resultado);

            var responseApi = await resultado.Content.ReadAsStringAsync();

            Assert.NotNull(responseApi);
            Assert.Equal("E-mail inválido", responseApi);
        }
    }
}
