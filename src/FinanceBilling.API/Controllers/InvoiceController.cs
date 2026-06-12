using FinanceBilling.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace FinanceBilling.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class InvoiceController : ControllerBase
{
    private readonly IInvoiceService _invoiceService;

    public InvoiceController(IInvoiceService invoiceService)
    {
        _invoiceService = invoiceService;
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        return Ok(await _invoiceService.GetAllAsync());
    }
}