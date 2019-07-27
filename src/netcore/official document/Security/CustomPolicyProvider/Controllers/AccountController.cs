using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;

namespace CustomPolicyProvider.Controllers
{
    public class AccountController : Controller
    {
        [HttpGet]
        public IActionResult Signin(string returnUrl = null)
        {
            ViewData["ReturnUrl"] = returnUrl;
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Signin(string userName, DateTime? birthDate, string returnUrl = null)
        {
            if (string.IsNullOrEmpty(userName))
                return BadRequest("A user name is required");

            var claims = new List<Claim>();
            claims.Add(new Claim(ClaimTypes.Name, userName));
            if (birthDate.HasValue)
            {
                claims.Add(new Claim(ClaimTypes.DateOfBirth, birthDate.Value.ToShortDateString()));
            }

            var identity = new ClaimsIdentity(claims, "UserSpecified");
            await HttpContext.SignInAsync(new ClaimsPrincipal(identity));
            return Redirect(returnUrl ?? "/");
        }

        public async Task<IActionResult> Signout()
        {
            await HttpContext.SignOutAsync();
            return Redirect("/");
        }

        public IActionResult Denied()
        {
            return View();
        }
    }
}