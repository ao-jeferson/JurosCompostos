using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RepositorioController : Controller
    {
        private readonly IConfiguration _configuration;

        public RepositorioController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        [Route("RepositoGit")]
        [HttpGet]
        public ActionResult Index()
        {
            var RepoGitHub = _configuration["Parametros:TaxaAtual"];
            return Json(RepoGitHub);
        }


    }
}
