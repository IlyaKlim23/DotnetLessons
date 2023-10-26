using Microsoft.AspNetCore.Mvc;

namespace ASPNETFIRST.Controllers;

public class AboutController: Controller
{
    public IActionResult Index()
    {
        return View();
    }
}