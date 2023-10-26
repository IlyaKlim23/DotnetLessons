using Microsoft.AspNetCore.Mvc;

namespace Extensions.Controllers;

public class CalculatorController: Controller
{
    public IActionResult Index()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Calculate(double num1, double num2, string operation)
    {
        double result = 0;

        switch (operation)
        {
            case "+":
                result = num1 + num2;
                break;
            case "-":
                result = num1 - num2;
                break;
            case "*":
                result = num1 * num2;
                break;
            case "/":
                if (num2 != 0)
                {
                    result = num1 / num2;
                }
                else
                {
                    ViewBag.Error = "Деление на ноль!";
                    return View("Index");
                }
                break;
        }

        return View("Index", result);
    }
}