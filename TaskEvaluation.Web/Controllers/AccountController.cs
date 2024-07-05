using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using TaskEvaluation.Core.Entities.DTOs;

namespace TaskEvaluation.Web.Controllers
{
	public class AccountController : Controller
	{
		public readonly UserManager<IdentityUser> _userManager;
		public readonly SignInManager<IdentityUser> _signInManager;

		public AccountController(UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager)
		{
			_userManager = userManager;
			_signInManager = signInManager;
		}
		#region Registration
		[HttpGet]
		public IActionResult Registration()
		{
			return View();
		}
		[HttpPost]
		public async Task<IActionResult> Register(RegisterDTO model)
		{
			if (ModelState.IsValid)
			{
				var user = new IdentityUser { UserName = model.Email, Email = model.Email , PhoneNumber = model.MobileNumber};
				var result = await _userManager.CreateAsync(user, model.Password);

				if (result.Succeeded)
				{
					await _signInManager.SignInAsync(user, isPersistent: false);
					return RedirectToAction("Index", "Home");
				}

				foreach (var error in result.Errors)
				{
					ModelState.AddModelError(string.Empty, error.Description);
				}
			}

			return View(model);
		}
		#endregion

		#region Login
		[HttpGet]
		public IActionResult Login()
		{
			return View();
		}

		[HttpPost]
		public async Task<IActionResult> Login(LoginDTO model)
		{
			if (ModelState.IsValid)
			{
				var result = await _signInManager.PasswordSignInAsync(model.Email, model.Password,model.RememberMe, lockoutOnFailure: false);

				if (result.Succeeded)
				{
					return RedirectToAction("Index", "Home");
				}

				ModelState.AddModelError(string.Empty, "Invalid login attempt.");
			}

			return View(model);
		}
		#endregion
	}
}