using Microsoft.AspNetCore.Mvc;

namespace FantasyButtonWebGame.Controllers
{
    public class ButtonController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
