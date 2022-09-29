using Customer.Portal.Web.ViewModels;
using System.Collections;
using System.Threading.Tasks;

namespace Customer.Portal.Web.Services
{
    public interface IAuthService
    {
        Task RegisterAsync(UserCreateViewModel user);
        Task<JwtViewModel> LoginAsync(LoginViewModel loginViewModel);
    }
}
