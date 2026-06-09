using Microsoft.AspNetCore.Mvc;
using Todo_Backend.Data;
using Todo_Backend.Models;

namespace Todo_Backend.Controllers;

[ApiController]
[Route("api/auth")]
public class AuthController : ControllerBase
{
    private readonly ApplicationDbContext _context;

    public AuthController(ApplicationDbContext context)
    {
        _context = context;
    }

    [HttpPost("signup")]
    public async Task<IActionResult> Signup(RegisterDto dto)
    {
        // Create User
        return Ok();
    }

    [HttpPost("signin")]
    public async Task<IActionResult> Signin(LoginDto dto)
    {
        // Validate User
        // Return JWT
        return Ok();
    }
}