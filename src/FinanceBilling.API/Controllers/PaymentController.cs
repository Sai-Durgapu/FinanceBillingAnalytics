using FinanceBilling.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace FinanceBilling.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class PaymentController : ControllerBase
{
    private readonly IPaymentService _paymentService;

    public PaymentController(IPaymentService paymentService)
    {
        _paymentService = paymentService;
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        return Ok(await _paymentService.GetAllAsync());
    }
}