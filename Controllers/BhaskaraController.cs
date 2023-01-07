using BhascaraModel;
using BhaskaraService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace bhaskara1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BhaskaraController : ControllerBase
    {
        [HttpGet]
        [Route("ObterResultado")]
        public RetornoXX ObterResultado(double a, double b, double c)
        {
            var x = new Calculo().CalculoBhaskara(a, b, c);
            return x;

        }
    }
}
