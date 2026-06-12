namespace FinanceBilling.Application.DTOs.Invoice;
public class UpdateInvoiceDto
{
    public int Id { get; set; }
    public decimal Amount { get; set; }
    public DateTime DueDate { get; set; }
}