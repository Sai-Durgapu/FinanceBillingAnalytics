namespace FinanceBilling.Application.DTOs.Invoice;
public class CreateInvoiceDto
{
    public string InvoiceNumber { get; set; }= string.Empty;
    public decimal Amount { get; set; }
    public DateTime InvoiceDate { get; set; }
    public DateTime DueDate { get; set; }
    public int CustomerId { get; set; }
}