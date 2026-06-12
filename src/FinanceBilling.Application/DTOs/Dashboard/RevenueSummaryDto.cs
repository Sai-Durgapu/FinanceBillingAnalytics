namespace FinanceBilling.Application.DTOs.Dashboard;
public class RevenueSummaryDto
{
    public decimal TotalRevenue { get; set; }
    public decimal CollectedRevenue { get; set; }
    public decimal PendingRevenue { get; set; }
}