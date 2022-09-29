using Customer.Portal.Web.Services;
using Customer.Portal.Web.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Customer.Portal.Web.Controllers
{
    [Authorize]
    [Route("api/v1/[controller]")]
    [ApiController]
    public class AccountsController : ControllerBase
    {
        private readonly IAccountService _service;
        private readonly ILogger<AccountsController> _logger;

        public AccountsController(IAccountService service, ILoggerFactory logger)
        {
            _service = service;
            _logger = logger.CreateLogger<AccountsController>();
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<AccountViewModel>>> GetAllAsync()
        {
            return Ok(await _service.GetAllAsync());
        }

        [HttpGet("{id:int}")]   
        public async Task<ActionResult<IEnumerable<AccountViewModel>>> GetByIdAsync(int id)
        {
            return Ok(await _service.GetByIdAsync(id));
        }

        [HttpGet("by-customer/{id:int}")]
        public async Task<ActionResult<IEnumerable<AccountViewModel>>> GetByCustomerAsync(int id)
        {
            return Ok(await _service.GetByCustomerAsync(id));
        }

        [HttpPost]
        public async Task<ActionResult<AccountViewModel>> CreateAsync(AccountCreateViewModel account)
        {
            return Ok(await _service.CreateAsync(account));
        }

        [HttpPut("{id:int}")]
        public async Task<ActionResult<AccountViewModel>> UpdateAsync(int id, AccountUpdateViewModel account)
        {
            return Ok(await _service.UpdateAsync(id, account));
        }

        [HttpDelete("{id:int}")]
        public async Task<IActionResult> DeleteAsync(int id)
        {
            await _service.DeleteAsync(id);
            return Ok();
        }

        [HttpGet("count")]
        public async Task<ActionResult<int>> GetAccountCount()
        {
            return Ok(await _service.GetAccountCount());
        }
    }
}
