using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JurosCompostos.Controllers
{
    public class TaxaJurosController : Controller
    {
        // GET: TaxaJurosController
        public ActionResult Index()
        {
            return View();
        }
    }
}
