using FinanceBilling.Domain.Common;
namespace FinanceBilling.Domain.Entities;
public class DashboardMetric : BaseEntity
{    
     public decimal TotalRevenue { get; set; } 
     public decimal TotalPayments { get; set; }
     public decimal PendingRevenue { get; set; }
     public int TotalCustomers { get; set; }
     public int TotalInvoices { get; set; }
}