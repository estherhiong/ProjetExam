using Microsoft.AspNetCore.Mvc;

namespace InstaApplication.Controllers
{
    public class AuthentificationController : Controller
    {
        public IActionResult Connexion()
        {
            return View();
        }
        public IActionResult Inscription()
        {
            return View();
        }
    }
}
