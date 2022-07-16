using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modulo2_semana6_tests
{
    public class SomaTeste : ConfiguracaoHostApi
    {
        [Theory]
        [InlineData(1, 1)]
        [InlineData(5, 4)]
        [InlineData(5, 3)]
        public async Task Teste_Exercicio_8_Soma_Sucesso(int num1, int num2)
        {
            var resultado = await client.GetAsync($"/Exercicio8/{num1}/{num2}");

            Assert.NotNull(resultado);

            var responseApi = await resultado.Content.ReadAsStringAsync();

            Assert.NotNull(responseApi);
            Assert.Equal((num1 + num2).ToString(), responseApi);
        }

        [Theory]
        [InlineData(80, 2)]
        [InlineData(90, 5)]
        [InlineData(102, 7)]
        public async Task Teste_Exercicio_8_Soma_Erro(int num1, int num2)
        {
            var resultado = await client.GetAsync($"/Exercicio8/{num1}/{num2}");

            Assert.NotNull(resultado);

            var responseApi = await resultado.Content.ReadAsStringAsync();

            Assert.NotNull(responseApi);
            string soma = (num1 + num2).ToString();
            Assert.NotEqual(soma, responseApi);
        }
    }
}
