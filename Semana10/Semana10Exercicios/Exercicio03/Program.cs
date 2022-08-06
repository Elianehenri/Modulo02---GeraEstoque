// See https://aka.ms/new-console-template for more information
using System.Text;
using System.Text.Json;

using System.Net.Http.Headers;


void ExemploGet()
{
    Console.WriteLine("Exercicio  03!");
    Console.WriteLine("Exemplo utilização http livros - verbo GET - anapioficeandfire ");
    Console.WriteLine("Obter livro específico");
    using var livros = new HttpClient();

    var request = new HttpRequestMessage(
        HttpMethod.Get,
        "https://www.anapioficeandfire.com/api/books/12"
    );

    Console.WriteLine("-- Requisição get");

    using var response = livros.Send(request);

    Console.WriteLine($"Retorno: ");
    Console.WriteLine($"Status Code: {response.StatusCode}");
    Console.WriteLine($"Corpo: {response.Content.ReadAsStringAsync().Result}");
    Console.WriteLine($"Headers: {string.Join(',', response.Headers.Select(h => $"{h.Key}={string.Join(',', h.Value)}"))}");

    Console.WriteLine("**************************************************************");
    Console.WriteLine();
}

void ExemploPost()
{
    Console.WriteLine("Exemplo utilização http livros - verbo POST - anapioficeandfire");

    using var livros = new HttpClient();

    var json = JsonSerializer.Serialize(new
    {
        text = "I love so much programming"
    });


    var request = new HttpRequestMessage(HttpMethod.Post, "https://www.anapioficeandfire.com/api/books/12")
    {
        Headers = {
            { "Accept", "application/json" }
        },
        Content = new StringContent(json, Encoding.UTF8, "application/json")
    };

    using var response = livros.Send(request);

    Console.WriteLine($"Retorno: ");
    Console.WriteLine($"Status Code: {response.StatusCode}");
    Console.WriteLine($"Corpo: {response.Content.ReadAsStringAsync().Result}");
    Console.WriteLine($"Headers: {string.Join(',', response.Headers.Select(h => $"{h.Key}={string.Join(',', h.Value)}"))}");
}

