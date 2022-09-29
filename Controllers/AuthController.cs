using Customer.Portal.Web.Services;
using Customer.Portal.Web.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;

namespace Customer.Portal.Web.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class AuthController: ControllerBase
    {
        private readonly IAuthService _service;
        private readonly ILogger<AuthController> _logger;

        public AuthController(IAuthService service, ILoggerFactory logger)
        {
            _service = service;
            _logger = logger.CreateLogger<AuthController>();
        }

        [HttpPost("register")]
        public async Task<IActionResult> RegisterAsync(UserCreateViewModel user)
        {
            await _service.RegisterAsync(user);
            return NoContent();
        }

        [HttpPost("login")]
        public async Task<ActionResult<JwtViewModel>> LoginAsync(LoginViewModel login)
        {
            return Ok(await _service.LoginAsync(login));
        }
    }
}
