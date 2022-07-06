using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static MobileZone.Models.ViewModel.UserViewModels;

namespace MobileZone.Controllers
{
    [Authorize]
    public class AccountController : Controller
    {
       
            private readonly SignInManager<IdentityUser> _signInManager;
            private readonly UserManager<IdentityUser> _userManager;
            private readonly RoleManager<IdentityRole> _roleManager;
            private string _role = "Client";

            public AccountController(UserManager<IdentityUser> userManager,
            SignInManager<IdentityUser> signInManager, RoleManager<IdentityRole> roleManager)
            {
                _userManager = userManager;
                _signInManager = signInManager;
                _roleManager = roleManager;
            }
            [AllowAnonymous]
            public IActionResult Login(string returnUrl)
            {
                return View(new LoginModel
                {
                    ReturnUrl = returnUrl
                });
            }

            [HttpPost]
            [ValidateAntiForgeryToken]
            [AllowAnonymous]
            public async Task<IActionResult> Login(LoginModel loginModel)
            {
                if (ModelState.IsValid)
                {
                    IdentityUser user =
                      await _userManager.FindByNameAsync(loginModel.Name);
                    if (user != null)
                    {
                        var result = await _signInManager.PasswordSignInAsync(user,
                          loginModel.Password, false, false);
                        if (result.Succeeded)
                        {
                            return Redirect(loginModel?.ReturnUrl ?? "/Home/Index");
                        }
                    }
                }
                ModelState.AddModelError("", "Invalid name or password");
                return View(loginModel);
            }
            [HttpGet]
            [AllowAnonymous]
            public IActionResult Register()
            {
                return View();
            }

            [HttpPost]
            [AllowAnonymous]
            public async Task<IActionResult> Register(RegisterModel registerModel)
            {
                if (ModelState.IsValid)
                {
                    if (await _roleManager.FindByNameAsync(_role) == null)
                    {
                        await _roleManager.CreateAsync(new IdentityRole(_role));
                    }
                    var user = new IdentityUser
                    {
                        UserName = registerModel.UserName,
                        Email = registerModel.Email
                    };
                    var result = await _userManager.CreateAsync(user, registerModel.Password);
                    if (result.Succeeded)
                    {
                        await _userManager.AddToRoleAsync(user, _role);
                        return RedirectToAction("Login", "Account");
                    }
                    else
                    {
                        ModelState.AddModelError("", "Unable to register new user");
                    }
                }
                return View(registerModel);
            }


            [HttpPost]
            public async Task<IActionResult> Logout()
            {
                await _signInManager.SignOutAsync();
                return RedirectToAction("Index", "Home");
            }
            [AllowAnonymous]
            public IActionResult AccessDenied()
            {
                return View();
            }

        
    }
}

