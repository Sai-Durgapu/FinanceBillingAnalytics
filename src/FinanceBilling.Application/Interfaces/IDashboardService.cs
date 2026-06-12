using FinanceBilling.Application.DTOs.Dashboard;
namespace FinanceBilling.Application.Interfaces;
public interface IDashboardService
{    Task<DashboardDto> GetDashboardAsync();
    Task<RevenueSummaryDto> GetRevenueSummaryAsync();
}