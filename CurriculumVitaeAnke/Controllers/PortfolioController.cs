using Microsoft.AspNetCore.Mvc;

namespace CurriculumVitaeAnke.Controllers
{
    public class PortfolioController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
