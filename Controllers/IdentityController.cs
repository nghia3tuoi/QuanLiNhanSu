
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using QLNS.Forms;


namespace QLNS.Controllers
{
    public class IdentityController : Controller
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly IConfiguration _configuration;
        public IdentityController(UserManager<IdentityUser> userManager, RoleManager<IdentityRole> roleManager, IConfiguration configuration, SignInManager<IdentityUser> signInManager)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _configuration = configuration;
            _signInManager = signInManager;
        }
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Login([Bind("Username,Password")] LoginForm model)
        {
            if (ModelState.IsValid)
            {
                var result = await _signInManager.PasswordSignInAsync(model.Username!, model.Password!, false, false);

                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Home");
                }

                ModelState.AddModelError(string.Empty, "Invalid login attempt.");
            }
            ViewBag.login = "Đăng nhập thất bại sai tài khoản hoặc mật khẩu!";
            return View(model);
        }
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Register([Bind("Username,Password,PasswordAgain")] RegisterForm model)
        {
            if (ModelState.IsValid)
            {
                var userExists = await _userManager.FindByNameAsync(model.Username!);
                if (userExists != null)
                {
                    ModelState.AddModelError("Username", "Tên người dùng đã tồn tại.");
                    return View(model);
                }
                if (model.PasswordAgain != model.Password)
                {
                    ModelState.AddModelError("PasswordAgain", "2 Mật khẩu không khớp.");
                    return View(model);
                }
                IdentityUser user = new()
                {
                    SecurityStamp = Guid.NewGuid().ToString(),
                    UserName = model.Username
                };
                var result = await _userManager.CreateAsync(user, model.Password!);
                if (!result.Succeeded)
                {
                    foreach (var error in result.Errors)
                    {
                        // Kiểm tra nếu lỗi liên quan đến mật khẩu
                        if (error.Code.Contains("Password"))
                        {
                            ModelState.AddModelError("Password", error.Description);
                        }
                        else
                        {
                            ModelState.AddModelError(string.Empty, error.Description);
                        }
                    }
                    return View(model);
                }
                if (!await _roleManager.RoleExistsAsync(UserRoleForms.User))
                    await _roleManager.CreateAsync(new IdentityRole(UserRoleForms.User));
                if (await _roleManager.RoleExistsAsync(UserRoleForms.User))
                {
                    await _userManager.AddToRoleAsync(user, UserRoleForms.User);
                }
                ViewBag.Success = "Đăng kí thành công!";
                return RedirectToAction("Login");
            }
            return View(model);
        }
        //
        [HttpPost]
        public IActionResult Logout() => View();
    }
}
