using Microsoft.AspNetCore.Mvc;
using System.Text.RegularExpressions;

namespace modulo2_semana6_api.Controllers;

/// <summary>
/// Exercicio 4
/// </summary>
[ApiController]
[Route("[controller]")]
public class ExercicioEmailController : ControllerBase
{
    /// <summary>
    /// Implementar a regra do exercicio 4 aqui dentro do GET
    /// </summary>
    /// <param name="email"></param>
    /// <returns></returns>
    [HttpGet("{email}")]
    public string Get(string email)
    {
        var minuto = DateTime.Now.Minute;
        if (minuto <= 30)
        {
            validaEmail(email);
            return "E-mail válido";
        }
        else
            throw new Exception("Erro na requisição o minuto está acima de 30");
    }

    private static void validaEmail(string email)
    {
        if (!Regex.IsMatch(email, @"^[\w-.]+@([\w-]+.)+[\w-]{2,4}$"))
            throw new Exception("E-mail inválido");
    }
}
