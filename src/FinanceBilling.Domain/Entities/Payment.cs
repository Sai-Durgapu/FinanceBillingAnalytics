using FinanceBilling.Domain.Common;
namespace FinanceBilling.Domain.Entities;
public class Payment : BaseEntity
{  
    public int InvoiceId { get; set; }
    public decimal AmountPaid { get; set; }
    public DateTime PaymentDate { get; set; }
    public string TransactionReference{ get; set;} = string.Empty;
    public string PaymentMethod {get; set;}= string.Empty;
    public Invoice? Invoice { get; set; }
}