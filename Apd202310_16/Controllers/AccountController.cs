using App202310_16.ModelsView;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace App202310_16.Controllers
{
    public class AccountController : Controller
    {
        private UserManager<IdentityUser> _userManager;
        private SignInManager<IdentityUser> _signInManager;
        private RoleManager<IdentityRole> _roleManager;

        public AccountController(UserManager<IdentityUser>userManager, 
                                    SignInManager<IdentityUser> signInManager, 
                                    RoleManager<IdentityRole> roleManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _roleManager = roleManager;
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginAccountVw model)
        {
            IdentityUser user = null;
            if (model.Email.Contains("@"))
            {
                user = await _userManager.FindByNameAsync(model.Email);
            }
            if (user == null)
            {
                ModelState.AddModelError("","Login o Password Errati");
                return View(model);
            }
            var result = await _signInManager.PasswordSignInAsync(user, model.Password, model.Ricordami, true);
            
            if (result.IsLockedOut)
            {
                ModelState.AddModelError("", "Login bloccato attendere alcuni minuti prima di riprovare");
                return View(model);
            }
            else if (!result.Succeeded)
            {
                ModelState.AddModelError("", "Login o Password Errati");
                return View(model);
            }

            return RedirectToAction("Index","Home");
        }

        [HttpGet]
        public IActionResult Registrazione()
        {
            return View();
        }
        
        [HttpPost]
        public async Task<IActionResult>Registrazione(RegistrazioneAccountVw model)
        {
            if (ModelState.IsValid)
            {
                IdentityUser user = new IdentityUser()
                {
                    Email = model.Email,
                    UserName = model.Email
                };
                
                IdentityResult result = await _userManager.CreateAsync(user,model.Password);
                
                if (result.Succeeded) 
                { 
                   await  _signInManager.SignInAsync(user, isPersistent: false);
                    //---- attribuire un ruolo all'utente in questo caso sarà User
                    //---- in altre ruolo di tipo admin
                    //---- in altre ruolo manager  oppure è anche uno sviluppatore un ruolo amministrazione
                    return RedirectToAction("Index","Home");
                }

                if (!result.Succeeded)
                {
                    foreach (var item in result.Errors)
                    {
                        ModelState.AddModelError("", item.Description);
                    }

                }
            }
            return View(model);
        }
    }
}
