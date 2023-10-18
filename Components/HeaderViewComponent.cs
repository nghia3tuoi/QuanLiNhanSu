using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using QLNS.Models;

namespace QLNS.Components
{
    public class HeaderViewComponent : ViewComponent
    {
        private readonly QlnsContext _context;
        public HeaderViewComponent(QlnsContext context)
        {
            _context = context;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            if (User.Identity!.IsAuthenticated)
            {
                string usernameLogin = User.Identity?.Name!;
                NhanVien? nhanVien = await _context.NhanViens
                    .Include(u => u.IdVitriNavigation)
                    .FirstOrDefaultAsync(nv => nv.MaNv == usernameLogin);
                if (nhanVien != null)
                {
                    return View(nhanVien);
                }
                return View();
            }
            return View();
        }
    }
}
