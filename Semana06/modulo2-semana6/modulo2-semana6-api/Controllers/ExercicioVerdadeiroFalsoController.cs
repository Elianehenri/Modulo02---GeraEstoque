using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace modulo2_semana6_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExercicioVerdadeiroFalsoController : ControllerBase
    {
       //exercicio 02
        [HttpGet("{tipo}")]
        public string Get(string tipo)
        {
            return "Texto diferente de verdadeiro ou falso";
        }
    }
}
