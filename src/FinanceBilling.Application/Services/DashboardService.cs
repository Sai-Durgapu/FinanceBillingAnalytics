using FinanceBilling.Application.DTOs.Dashboard;
using FinanceBilling.Application.Interfaces;

namespace FinanceBilling.Application.Services;

public class DashboardService : IDashboardService
{
    public Task<DashboardDto> GetDashboardAsync()
    {
        return Task.FromResult(new DashboardDto());
    }

    public Task<RevenueSummaryDto> GetRevenueSummaryAsync()
    {
        return Task.FromResult(new RevenueSummaryDto());
    }
}