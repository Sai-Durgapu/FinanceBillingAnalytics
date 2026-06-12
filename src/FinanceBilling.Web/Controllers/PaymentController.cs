using Microsoft.AspNetCore.Mvc;

namespace FinanceBilling.Web.Controllers;

public class PaymentController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Create()
    {
        return View();
    }

    public IActionResult Details(int id)
    {
        return View();
    }
}