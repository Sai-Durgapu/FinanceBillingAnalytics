namespace FinanceBilling.Application.DTOs.Payment;

public class CreatePaymentDto
{
    public int InvoiceId { get; set; }

    public decimal AmountPaid { get; set; }

    public DateTime PaymentDate { get; set; }

    public string TransactionReference { get; set; }
        = string.Empty;

    public string PaymentMethod { get; set; }
        = string.Empty;
}