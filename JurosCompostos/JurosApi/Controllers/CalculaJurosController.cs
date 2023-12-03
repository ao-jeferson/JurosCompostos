using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;

namespace JurosCompostos.Controllers
{
    [Route("/")]
    [ApiController]
    public class CalculaJurosController : Controller
    {
        private readonly IConfiguration _configuration;
        public CalculaJurosController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        //Valor Final = Valor Inicial * (1 + juros) ^ Tempo
        [HttpGet]
        [Route("CalculaJuros")]
        public ActionResult JurosPeriodo(double ValorInicial, int TempoEmMeses)
        {
            double JurosAtual = Convert.ToDouble(_configuration["Parametros:TaxaAtual"].Replace("%",""));

            double valorFinal = ValorInicial * Math.Pow(1 + (JurosAtual / 100), TempoEmMeses);

            return Json(Math.Round(valorFinal,2).ToString("0.00"));
        }

        [Route("showmethecode")]
        [HttpGet]
        public ActionResult Index()
        {
            var RepoGitHub = _configuration["Parametros:RepoGitHub"];
            return Json(RepoGitHub);
        }


    }
}
