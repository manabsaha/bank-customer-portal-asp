using Customer.Portal.Web.ViewModels;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Customer.Portal.Web.Services
{
    public interface IBankCustomerService
    {
        Task<IEnumerable<BankCustomerViewModel>> GetAllAsync();
        Task<BankCustomerViewModel> GetByIdAsync(int id);
        Task<BankCustomerViewModel> CreateAsync(BankCustomerCreateViewModel customer);
        Task<BankCustomerViewModel> UpdateAsync(int id, BankCustomerUpdateViewModel customer);
        Task DeleteAsync(int id);
        Task<int> GetCustomerCount();
    }
}
