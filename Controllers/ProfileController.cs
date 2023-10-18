using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using QLNS.Models;

namespace QLNS.Controllers
{
    public class ProfileController : Controller
    {
        private readonly QlnsContext _context;
        private readonly UserManager<IdentityUser> _userManager;
        public ProfileController(QlnsContext context, UserManager<IdentityUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        [Route("user/profile")]
        public IActionResult Index()
        {
           
            var data = _context.NhanViens.ToList();
            return View();
        }
    }
}
