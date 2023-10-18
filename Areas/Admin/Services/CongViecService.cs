using Microsoft.EntityFrameworkCore;
using QLNS.Models;

namespace QLNS.Areas.Admin.Services
{
    public class CongViecService
    {
        private readonly QlnsContext _context;
        public CongViecService(QlnsContext context) { 
            _context = context;
        }
        public async Task<List<CongViec>> GetListCV()
        {
            List<CongViec> congViecs = await _context.CongViecs.ToListAsync();
            return congViecs;
        }
    }
}
