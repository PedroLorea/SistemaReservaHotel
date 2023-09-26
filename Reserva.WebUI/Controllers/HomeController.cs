using Microsoft.AspNetCore.Mvc;

namespace Reserva.WebUI.Controllers;

public class HomeController : Controller{

    public IActionResult Index() {
        return View();
    }

    public IActionResult Entrar() {
        return RedirectToAction("Index", "Hotel");
    }
}