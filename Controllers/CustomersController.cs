using Customer.Portal.Web.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Threading.Tasks;
using System;
using Customer.Portal.Web.Models;
using Customer.Portal.Web.ViewModels;
using Microsoft.AspNetCore.Authorization;

namespace Customer.Portal.Web.Controllers
{
    [Authorize]
    [Route("api/v1/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        private readonly IBankCustomerService _service;
        private readonly ILogger<CustomersController> _logger;

        public CustomersController(IBankCustomerService service, ILoggerFactory logger)
        {
            _service = service;
            _logger = logger.CreateLogger<CustomersController>();
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<BankCustomerViewModel>>> GetAllAsync()
        {
            return Ok(await _service.GetAllAsync());
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<IEnumerable<BankCustomerViewModel>>> GetByIdAsync(int id)
        {
            return Ok(await _service.GetByIdAsync(id));
        }

        [HttpPost]
        public async Task<ActionResult<BankCustomerViewModel>> CreateAsync(BankCustomerCreateViewModel customer)
        {
            return Ok(await _service.CreateAsync(customer));
        }

        [HttpPut("{id:int}")]
        public async Task<ActionResult<BankCustomerViewModel>> UpdateAsync(int id, BankCustomerUpdateViewModel customer)
        {
            return Ok(await _service.UpdateAsync(id, customer));
        }

        [HttpDelete("{id:int}")]
        public async Task<IActionResult> DeleteAsync(int id)
        {
            await _service.DeleteAsync(id);
            return Ok();
        }

        [HttpGet("count")]
        public async Task<ActionResult<int>> GetCustomerCount()
        {
            return Ok(await _service.GetCustomerCount());
        }
    }
}
