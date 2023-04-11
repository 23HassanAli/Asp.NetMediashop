using Microsoft.AspNetCore.Mvc;
using PXLPRO2023Shoppers24.Data.ViewModels;
using PXLPRO2023Shoppers24.Services;

namespace PXLPRO2023Shoppers24.Controllers
{
    public class AccountController : Controller
    {
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
    }
}
