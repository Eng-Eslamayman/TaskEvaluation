using Castle.Core.Smtp;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using TaskEvaluation.Core.Entities.DTOs;
using TaskEvaluation.Web.Services;
using IEmailSender = TaskEvaluation.Web.Services.IEmailSender;

namespace TaskEvaluation.Web.Controllers
{
	public class AccountController : Controller
	{
		private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly IEmailSender _emailSender;

        public AccountController(UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager, IEmailSender emailSender)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _emailSender = emailSender;
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


        [HttpGet]
        public IActionResult ForgetPassword()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ForgetPassword(ForgetPasswordDTO model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var user = await _userManager.FindByEmailAsync(model.Email);
            if (user == null || !(await _userManager.IsEmailConfirmedAsync(user)))
            {
                // Don't reveal that the user does not exist or is not confirmed
                return RedirectToAction("ForgotPasswordConfirmation");
            }

            var token = await _userManager.GeneratePasswordResetTokenAsync(user);
            var callbackUrl = Url.Action("ResetPassword", "Account", new { token, email = model.Email }, protocol: HttpContext.Request.Scheme);
            await _emailSender.SendEmailAsync(model.Email, "Reset Password", $"Please reset your password by clicking here: <a href='{callbackUrl}'>link</a>");

            return RedirectToAction("ForgotPasswordConfirmation");
        }

        // GET: /Account/ForgotPasswordConfirmation
        [HttpGet]
        public IActionResult ForgotPasswordConfirmation()
        {
            return View();
        }
    }
}