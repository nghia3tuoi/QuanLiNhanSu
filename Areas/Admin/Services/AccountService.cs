using Microsoft.AspNetCore.Identity;
using QLNS.Forms;
using QLNS.Models;

namespace QLNS.Areas.Admin.Services
{
    public class AccountService
    {
        private readonly QlnsContext _qlnsContext;
        private readonly UserManager<IdentityUser> _userManager;
       
        public AccountService(QlnsContext qlnsContext, UserManager<IdentityUser> userManager) {
            _qlnsContext = qlnsContext;
        }
        
    }
}
