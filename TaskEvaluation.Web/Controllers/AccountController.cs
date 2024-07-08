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
		public IActionResult RegisterCompleted()
		{
			return View();	
		}
        [HttpGet]
		public IActionResult Registration()
		{
			return View();
		}
        [HttpPost]
        public async Task<IActionResult> Registration(RegisterDTO registerdto)
        {
            if (!ModelState.IsValid) return View(registerdto);

            var user = await _userManager.FindByEmailAsync(registerdto.Email);
            if (user != null)
            {
                TempData["Error"] = "This email address is already in use";
                return View(registerdto);
            }

            var newUser = new IdentityUser()
            {
                UserName = registerdto.UserName,
                Email = registerdto.Email,
                PhoneNumber=registerdto.MobileNumber
            };
            var newUserResponse = await _userManager.CreateAsync(newUser, registerdto.Password);

            if (newUserResponse.Succeeded)
			{ 
                await _signInManager.SignInAsync(newUser, isPersistent: false);
            return View("RegisterCompleted");
            }
            return View(registerdto);
        }
       
        #endregion

        #region Login
        [HttpGet]
		public IActionResult Login()
		{
			return View();
		}

		[HttpPost]
		public async Task<IActionResult> Login(LoginDTO loginVM)
		{
			if (!ModelState.IsValid) return View(loginVM);

			var user = await _userManager.FindByEmailAsync(loginVM.Email);
			if (user != null)
			{
				var passwordCheck = await _userManager.CheckPasswordAsync(user, loginVM.Password);
				if (passwordCheck)
				{
					var result = await _signInManager.PasswordSignInAsync(user, loginVM.Password, false, false);
					if (result.Succeeded)
					{
						return RedirectToAction("Index", "Home");
					}
				}
				TempData["Error"] = "Wrong credentials. Please, try again!";
				return View(loginVM);
			}

			TempData["Error"] = "Wrong credentials. Please, try again!";
			return View(loginVM);
		}
		#endregion
	}
}