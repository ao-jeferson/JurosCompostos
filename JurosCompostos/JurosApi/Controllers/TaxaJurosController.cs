using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace JurosCompostos.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaxaJurosController : Controller
    {
        private readonly IConfiguration _configuration;

        public TaxaJurosController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        [Route("ObterTaxaAtual")]
        [HttpGet]
        public  ActionResult Index()
        {

            var TaxaAtual = _configuration["Parametros:TaxaAtual"];
            return Json(TaxaAtual);
        }

    }
} 