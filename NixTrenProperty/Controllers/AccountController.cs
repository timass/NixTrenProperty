using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using OnionApp.Domain.Core;
using NixTrenProperty.Models;
using System.Threading.Tasks;
using NixTrenProperty.ViewModels;
using Microsoft.AspNetCore.Authentication;

namespace NixTrenProperty.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;
        public AccountController(UserManager<User> userManager, SignInManager<User> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            
        }
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }      
        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                User user = new User { Email = model.Email, UserName = model.UserName, Name = model.Name, Telephone = model.Telephone };
                // add user
                var result = await _userManager.CreateAsync(user, model.Password);
                
                if (result.Succeeded)
                {
                    // set cookie
                    await _signInManager.SignInAsync(user, false);
                    //set roles
                    await _userManager.AddToRoleAsync(user, "user");
                    if (user.Telephone != null)
                    {
                        await _userManager.AddToRoleAsync(user, "seller");
                    }
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError(string.Empty, error.Description);
                    }
                }
            }
            return View(model);
        }
        
        [HttpGet]
        public IActionResult Login(string returnUrl = null)
        {
            return View(new LoginViewModel { ReturnUrl = returnUrl });
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                var result =
                    await _signInManager.PasswordSignInAsync(model.UserName, model.Password, model.RememberMe, false);
                if (result.Succeeded)
                {                    
                    if (!string.IsNullOrEmpty(model.ReturnUrl) && Url.IsLocalUrl(model.ReturnUrl))
                    {
                        return Redirect(model.ReturnUrl);
                    }
                    else
                    {
                        return RedirectToAction("Index", "User");
                    }
                }
                else
                {
                    ModelState.AddModelError("","Incorrect login and/or password ");
                }
            }
            return View(model);
        }

        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Logout()
        //{
        //    await _signInManager.SignOutAsync();
        //    return RedirectToAction("Index", "Home");
        //}
        public async Task Logout()
        {
            await SignOut("Home/Index");
        }


        public async Task SignOut(string redirectUri)
        {
            await _signInManager.SignOutAsync();
            await HttpContext.SignOutAsync("Cookies");
            var prop = new AuthenticationProperties()
            {
                RedirectUri = redirectUri
            };
            await HttpContext.SignOutAsync("Microsoft", prop);
        }
    }
}
