using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using PXLPRO2023Shoppers24.Data.ViewModels;
using PXLPRO2023Shoppers24.Models;
using PXLPRO2023Shoppers24.Services;
using System.Security.Claims;

namespace PXLPRO2023Shoppers24.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly IdentityRepoInterface _identityRepoInterface;
        public AccountController(IdentityRepoInterface identityRepoInterface)
        {
            _identityRepoInterface = identityRepoInterface;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Login() => View(new LoginVM());
        [HttpPost]
        public async Task<IActionResult> Login(LoginVM loginVM)
        {
            if (ModelState.IsValid)
            {
                IdentityRepositoryResult result = await _identityRepoInterface.LoginAsync(loginVM);
                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    foreach (string error in result.Errors)
                    {
                        ModelState.AddModelError(string.Empty, error);

                    }
                    return View(loginVM);
                }
            }
            return View(loginVM);
           
        }
        public IActionResult Register() => View(new RegisterVm());
        [HttpPost]
        public async Task<IActionResult> Register(RegisterVm registerVm)
        {
            if (ModelState.IsValid)
            {
                var result = await _identityRepoInterface.RegisterAsync(registerVm);
                if (result.Succeeded)
                {
                    return View("RegisterCompleted");
                }
                else
                {
                    return View(registerVm);
                }
            }
            return View(registerVm);
   
        }

        #region Facebook
        public IActionResult FacebookLogin()
        {
            string redirectUrl = Url.Action("FacebookResponse", "Account");
            var properties =
            _signInManager.ConfigureExternalAuthenticationProperties("Facebook", redirectUrl);
            return new ChallengeResult("Facebook", properties);
        }
        public async Task<IActionResult> FacebookResponse()
        {
            //retrieve information that was send in the http request (by facebook)
            ExternalLoginInfo externalLoginInfo =
            await _signInManager.GetExternalLoginInfoAsync();
            if (externalLoginInfo == null)
            {
                //user did not login properly with facebook -> redirect to login page
                return RedirectToAction(nameof(Login));
            }
            //Put info provided by facebook (claims) into a viewmodel
            string userName = externalLoginInfo.Principal.FindFirst(ClaimTypes.Name).Value;
            //make sure username is unique
            UserVM model = new UserVM()
            {
                UserName = userName,
                Email = externalLoginInfo.Principal.FindFirst(ClaimTypes.Email).Value
            };
            Microsoft.AspNetCore.Identity.SignInResult result = await _signInManager.ExternalLoginSignInAsync(externalLoginInfo.LoginProvider, externalLoginInfo.ProviderKey, false);
            if (result.Succeeded)
            {
                return RedirectToAction("Index", "Test");
            }
            else
            {
                var identityResult = await CreateIdentityUserAsync(externalLoginInfo);
                if (identityResult.Succeeded)
                {
                    return RedirectToAction("Index", "Test");
                }
            }
            return View("login");
        }


        #endregion
        #region Google
        public IActionResult GoogleLogin()
        {
            string redirectUrl = Url.Action("GoogleResponse", "Account");
            var properties =
            _signInManager.ConfigureExternalAuthenticationProperties("Google", redirectUrl);
            return new ChallengeResult("Google", properties);
        }
        public async Task<IActionResult> GoogleResponse()
        {
            //retrieve information that was send in the http request (by facebook)
            ExternalLoginInfo externalLoginInfo =
            await _signInManager.GetExternalLoginInfoAsync();
            if (externalLoginInfo == null)
            {
                //user did not login properly with facebook -> redirect to login page
                return RedirectToAction(nameof(Login));
            }
            //Put info provided by facebook (claims) into a viewmodel
            string userName = externalLoginInfo.Principal.FindFirst(ClaimTypes.Name).Value;
            //make sure username is unique
            UserVM model = new UserVM()
            {
                UserName = userName,
                Email = externalLoginInfo.Principal.FindFirst(ClaimTypes.Email).Value
            };
            Microsoft.AspNetCore.Identity.SignInResult result = await _signInManager.ExternalLoginSignInAsync(externalLoginInfo.LoginProvider, externalLoginInfo.ProviderKey, false);
            if (result.Succeeded)
            {
                return RedirectToAction("Index", "Home");
            }
            else
            {
                var identityResult = await CreateIdentityUserAsync(externalLoginInfo);
                if (identityResult.Succeeded)
                {
                    return RedirectToAction("Index", "Home");
                }
            }
            return View("login");
        }
        #endregion
        #region Duende
        public IActionResult DuendeLogin()
        {
            string redirectUrl = Url.Action("DuendeResponse", "Account");
            string scheme = "oidc";
            var properties =
            _signInManager.ConfigureExternalAuthenticationProperties(
            scheme, redirectUrl);
            return new ChallengeResult(scheme, properties);
        }
        public async Task<IActionResult> DuendeResponse()
        {
            //retrieve information that was send in the http request (by identityserver)
            ExternalLoginInfo externalLoginInfo =
            await _signInManager.GetExternalLoginInfoAsync();
            if (externalLoginInfo == null)
            {
                //user did not login properly with identityserver -> redirect to login page
                return RedirectToAction(nameof(Login));
            }
            //Put info provided by google (claims) into a viewmodel
            string userName = externalLoginInfo.Principal.FindFirst("name").Value;
            //make sure username is unique
            UserVM model = new UserVM
            {
                UserName = userName,
                Email = externalLoginInfo.Principal.FindFirst("email").Value
            };
            Microsoft.AspNetCore.Identity.SignInResult result = await _signInManager.ExternalLoginSignInAsync(
                externalLoginInfo.LoginProvider, externalLoginInfo.ProviderKey, false);
            if (!result.Succeeded)
            {
                var identityResult = await CreateIdenntityUserAsync(externalLoginInfo, model);
                if (identityResult.Succeeded)
                {
                    return View("Login");
                }
            }
            return View(model);//goto DuendeResponse View
        }
          private async Task<IdentityResult>  CreateIdenntityUserAsync(ExternalLoginInfo info, UserVM model)
        {
            ApplicationUser user = GetIdentityUser(info, model);
            IdentityResult identityResult = await _userManager.CreateAsync(user);
            if(identityResult.Succeeded)
            {
                identityResult = await _userManager.AddLoginAsync(user, info);
                if (identityResult.Succeeded)
                {
                    await _signInManager.SignInAsync(user, false);
                }
                else
                {
                    return IdentityResult.Failed(new IdentityError
                    {
                        Description = "error in AddLogin"
                    });
                }
            }
            return identityResult;
        }
        private ApplicationUser GetIdentityUser(ExternalLoginInfo info, UserVM model)
        {
            string userName = $"{model.UserName}_{info.LoginProvider}_{info.ProviderKey}";
            ApplicationUser user = new ApplicationUser(userName)
            {
                Email = model.Email
            };
            return user;    
        }
        #endregion


        private ApplicationUser GetIdentityUser(ExternalLoginInfo info)
        {
            string userName = info.Principal.FindFirst(ClaimTypes.Name).Value;
            userName = $"{userName}_{info.LoginProvider}_{info.ProviderKey}";
            string email = info.Principal.FindFirst(ClaimTypes.Email).Value;
            ApplicationUser user = new ApplicationUser(userName)
            {
                Email = email
            };
            return user;
        }

        private async Task<IdentityResult> CreateIdentityUserAsync(
                    ExternalLoginInfo externalLoginInfo)
        {
            //Put info provided by external provider (claims) into a viewmodel
            //Sign in failed -> user does not exist yet in our database -> create one
            ApplicationUser user = GetIdentityUser(externalLoginInfo);
            IdentityResult identityResult = await _userManager.CreateAsync(user);
            if (identityResult.Succeeded)
            {
                //link the created user to the facebook login info
                identityResult = await _userManager.AddLoginAsync(
                user, externalLoginInfo);
                if (identityResult.Succeeded)
                {
                    await _signInManager.SignInAsync(user, false);
                }
                else
                {
                    return IdentityResult.Failed(
                    new IdentityError { Description = "error in AddLogin" });
                }
            }
            return identityResult;
        }

    }
}
