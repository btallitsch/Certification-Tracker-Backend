using Microsoft.AspNetCore.Mvc;
using ABA.CertificationTracker.Services;
using ABA.CertificationTracker.DTOs;

namespace ABA.CertificationTracker.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly IAuthService _authService;

        public AuthController(IAuthService authService)
        {
            _authService = authService;
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] LoginRequest request)
        {
            var token = await _authService.LoginAsync(request.Email, request.Password);
            if (token == null) return Unauthorized();

            return Ok(new { Token = token });
        }
    }
}