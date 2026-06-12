namespace FinanceBilling.Application.DTOs.Invoice;
public class InvoiceDto
{
    public int Id { get; set; }
    public string InvoiceNumber { get; set; }=string.Empty;
    public decimal Amount { get; set; }
    public string Status { get; set; }= string.Empty;
}