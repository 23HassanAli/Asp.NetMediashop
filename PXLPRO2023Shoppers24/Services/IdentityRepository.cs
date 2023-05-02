using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using PXLPRO2023Shoppers24.Data.ViewModels;
using PXLPRO2023Shoppers24.Models;
using PXLPRO2023Shoppers24.Services;

namespace HrApp.Services
{
    public class IdentityRepository : IdentityRepoInterface
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        public IdentityRepository(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signinManager)
        {
            _userManager = userManager;
            _signInManager = signinManager;
        }
        public async Task<IdentityRepositoryResult> LoginAsync(LoginVM loginData)
        {
            var result = await GetIdentityUserAsync(loginData);
            if (result.Succeeded)
            {
                var signinResult = await _signInManager.PasswordSignInAsync(
                result.ApplicationUser,loginData.Password, false, false);
                if (signinResult.Succeeded)
                    result.Succeeded = true;
                else
                {
                    result.AddError("Wrong credentials. Please, try again!");
                    result.Succeeded = false;
                }
            }
            return result;
        }

        public async Task<IdentityRepositoryResult> LogoutAsync()
        {
            var result = new IdentityRepositoryResult();
            await _signInManager.SignOutAsync();
            result.Succeeded = true;
            return result;
        }

        public async Task<IdentityRepositoryResult> RegisterAsync(RegisterVm registerData)
        {
            var result = new IdentityRepositoryResult();
            var identityUser = new ApplicationUser()
            {
                FullName = registerData.FullName,
                UserName = registerData.UserName,
                Email = registerData.EmailAddress
            };
            var identityResult = await _userManager.CreateAsync(identityUser, registerData.Password);
            if (identityResult.Succeeded)
            {
                result.Succeeded = true;
            }
            else
            {
                foreach (var error in identityResult.Errors)
                {
                    result.AddError(error.Description);
                }
            }
            return result;
        }
        private async Task<IdentityRepositoryResult> GetIdentityUserAsync(LoginVM userData)
        {
            var result = new IdentityRepositoryResult();
            ApplicationUser user;
            if (userData.EmailAddress != null)
            {
                user = await _userManager.FindByEmailAsync(userData.EmailAddress);
                if (user == null)
                    result.AddError("Geen gebruiker gevonden met dit email adres!");
                else
                {
                    result.ApplicationUser = user;
                    result.Succeeded = true;
                }
            }
            return result;
        }
    }
}
