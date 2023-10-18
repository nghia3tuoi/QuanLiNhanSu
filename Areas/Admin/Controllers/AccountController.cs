using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using QLNS.Areas.Admin.Forms;
using QLNS.Forms;

namespace QLNS.Areas.Admin.Controllers;

[Area("Admin")]
public class AccountController : Controller
{
    private readonly UserManager<IdentityUser> _userManager;
    private readonly SignInManager<IdentityUser> _signInManager;
    private readonly RoleManager<IdentityRole> _roleManager;
    public AccountController(UserManager<IdentityUser> userManager, RoleManager<IdentityRole> roleManager, IConfiguration configuration, SignInManager<IdentityUser> signInManager)
    {
        _userManager = userManager;
        _roleManager = roleManager;
        _signInManager = signInManager;
    }


    public IActionResult Index()
    {
        var users = _userManager.Users.ToList();
        var taikhoan = new List<TaiKhoan>();
        foreach (var user in users)
        {
            var taiKhoan = new TaiKhoan
            {
                id = user.Id,
                Email = user.Email,
                Username = user.UserName,
                BlockOutEnd = user.LockoutEnd

                // Các thông tin khác bạn muốn chuyển đổi
            };
            taikhoan.Add(taiKhoan);
        }
        if (taikhoan != null)
        {
            return View(taikhoan);
        }
        return View();
    }
    [HttpGet]
    public IActionResult CreateAccountStaff()
    {
        return View();
    }
    [HttpPost]
    public async Task<IActionResult> CreateAccountStaff([Bind("Username,Password,PasswordAgain")] RegisterForm model)
    {
        if (ModelState.IsValid)
        {
            var userExists = await _userManager.FindByNameAsync(model.Username!);
            if (userExists != null)
            {
                ViewBag.userExists = "Mã nhân viên đã tồn tại!";
                return View(model);
            }
            if (model.PasswordAgain != model.Password)
            {
                ViewBag.passwordNoMatch = "Mật khẩu không khớp";
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
                        ViewBag.passwordErr = error.Description;
                    }
                    else
                    {
                        ViewBag.passwordErr = error.Description;
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
            return View(model);
        }
        return View(model);
    }
    public IActionResult BlockAccount(string idUser)
    {
        return View();
    }
}