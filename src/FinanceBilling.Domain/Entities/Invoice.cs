using FinanceBilling.Domain.Common;
using FinanceBilling.Domain.Enums;
namespace FinanceBilling.Domain.Entities;
public class Invoice : BaseEntity
{
    public string InvoiceNumber { get; set; } = string.Empty;
    public DateTime InvoiceDate { get; set; }
    public DateTime DueDate { get; set; }
    public decimal Amount { get; set; }
    public InvoiceStatus Status { get; set; }
    public int CustomerId { get; set; }
    public Customer? Customer { get; set; }
    public ICollection<Payment> Payments{get; set;} = new List<Payment>();
}