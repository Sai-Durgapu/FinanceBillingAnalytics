using Microsoft.AspNetCore.Identity;

namespace FinanceBilling.Infrastructure.Identity;

public class ApplicationUser : IdentityUser
{
    public string FullName { get; set; } = string.Empty;
}