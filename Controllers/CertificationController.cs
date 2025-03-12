using Microsoft.AspNetCore.Mvc;
using ABA.CertificationTracker.Services;

namespace ABA.CertificationTracker.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CertificationController : ControllerBase
    {
        private readonly ICertificationService _certificationService;

        public CertificationController(ICertificationService certificationService)
        {
            _certificationService = certificationService;
        }

        [HttpGet("status")]
        public async Task<IActionResult> GetCertificationStatus()
        {
            var status = await _certificationService.GetCertificationStatusAsync();
            return Ok(status);
        }
    }
}