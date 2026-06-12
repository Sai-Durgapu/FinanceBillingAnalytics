using Microsoft.AspNetCore.Mvc;

namespace FinanceBilling.Web.Controllers;

public class DashboardController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}