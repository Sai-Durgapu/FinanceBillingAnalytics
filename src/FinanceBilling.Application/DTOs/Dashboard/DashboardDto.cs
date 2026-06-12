namespace FinanceBilling.Application.DTOs.Dashboard;
public class DashboardDto
{
    public int TotalCustomers { get; set; }
    public int TotalInvoices { get; set; }
    public int TotalPayments { get; set; }
    public decimal TotalRevenue { get; set; }
    public decimal PendingRevenue { get; set; }
}