using System.ComponentModel.DataAnnotations;
using FinanceBilling.Domain.Common;

namespace FinanceBilling.Domain.Entities;

public class Customer : BaseEntity
{
    public string CustomerCode { get; set; } = string.Empty;
    [Required]
    public string Name { get; set; } = string.Empty;
    [Required]
    public string Email { get; set; } = string.Empty;
    public string Phone { get; set; } = string.Empty;
    public string Address { get; set; } = string.Empty;
    public ICollection<Invoice> Invoices { get; set; } = new List<Invoice>();
}