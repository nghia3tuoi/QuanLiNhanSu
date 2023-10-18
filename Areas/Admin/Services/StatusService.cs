using Microsoft.EntityFrameworkCore;
using QLNS.Models;

namespace QLNS.Areas.Admin.Services
{
    public class StatusService
    {
        private readonly QlnsContext _context;
        public StatusService(QlnsContext context) { 
            _context = context;
        }
        public async Task<List<StatusNhanVien>> GetListStatusNhanVien()
        {
            List<StatusNhanVien> statusNhanViens = await _context.StatusNhanviens.ToListAsync();
            return statusNhanViens;
        }
    }
}
