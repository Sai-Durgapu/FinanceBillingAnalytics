using FinanceBilling.Domain.Entities;
using FinanceBilling.Infrastructure.Security;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using FinanceBilling.Infrastructure.Identity;

namespace FinanceBilling.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class AuthController : ControllerBase
{
    private readonly UserManager<ApplicationUser> _userManager;
    private readonly JwtTokenGenerator _jwtTokenGenerator;

    public AuthController(
        UserManager<ApplicationUser> userManager,
        JwtTokenGenerator jwtTokenGenerator)
    {
        _userManager = userManager;
        _jwtTokenGenerator = jwtTokenGenerator;
    }

    [HttpPost("login")]
    public async Task<IActionResult> Login(
        string email,
        string password)
    {
        var user =
            await _userManager.FindByEmailAsync(email);

        if (user == null)
        {
            return Unauthorized();
        }

        var validPassword =
            await _userManager.CheckPasswordAsync(
                user,
                password);

        if (!validPassword)
        {
            return Unauthorized();
        }

        var roles =
            await _userManager.GetRolesAsync(user);

        var token =
            _jwtTokenGenerator.GenerateToken(
                user,
                roles);

        return Ok(new
        {
            Token = token
        });
    }
}