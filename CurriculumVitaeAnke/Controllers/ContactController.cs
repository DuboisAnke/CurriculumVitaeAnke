using Microsoft.AspNetCore.Mvc;

namespace CurriculumVitaeAnke.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
