using ASPNETFIRST.Models;
using Microsoft.AspNetCore.Mvc;

namespace ASPNETFIRST.Controllers;

public class ProductsController: Controller
{
    private List<ProductViewModel> _products = new List<ProductViewModel>()
    {
        new (){Id = 1, Name = "Мерседес", Price = 100000, Description = "Супер тачка ваще"},
        new (){Id = 2, Name = "БЭМЕВЕ", Price = 5, Description = "Ну норм"},
        new (){Id = 3, Name = "Лада калина", Price = 100000000000000000, Description = "Зверь"},
        new (){Id = 4, Name = "Hendai", Price = 38000000, Description = "Семейная машина норм"}
    };
    
    public IActionResult Index()
    {
        return View(_products);
    }

    [HttpGet]
    public IActionResult AboutProduct(int id)
    {
        return View(_products.FirstOrDefault(x => x.Id == id));
    }
}