namespace FinanceBilling.Application.DTOs.Payment;

public class PaymentDto
{
    public int Id { get; set; }
    public int InvoiceId { get; set; }
    public decimal AmountPaid { get; set; }
    public DateTime PaymentDate { get; set; }
}