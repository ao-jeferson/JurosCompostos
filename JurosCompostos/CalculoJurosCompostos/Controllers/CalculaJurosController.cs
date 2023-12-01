using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JurosCompostos.Controllers
{
    [Route("/")]
    public class CalculaJurosController : Controller
    {
        // GET: CalculaJurosController
        public ActionResult Index()
        {

            return View();
        }       
    }
}
