using PXLPRO2023Shoppers24.Data.ViewModels;

namespace PXLPRO2023Shoppers24.Services
{
    public interface IdentityRepoInterface
    {
        Task<IdentityRepositoryResult> LoginAsync(LoginVM loginData);
        Task<IdentityRepositoryResult> RegisterAsync(
        RegisterVm registerData);
        Task<IdentityRepositoryResult> LogoutAsync();
    }
}
