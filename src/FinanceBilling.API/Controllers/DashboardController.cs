using FinanceBilling.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace FinanceBilling.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class DashboardController : ControllerBase
{
    private readonly IDashboardService _dashboardService;

    public DashboardController(
        IDashboardService dashboardService)
    {
        _dashboardService = dashboardService;
    }

    [HttpGet]
    public async Task<IActionResult> GetDashboard()
    {
        return Ok(
            await _dashboardService.GetDashboardAsync());
    }
}