using Microsoft.EntityFrameworkCore;
using QLNS.Models;

namespace QLNS.Areas.Admin.Services
{
    public class ViTriService
    {
        private readonly QlnsContext _context;
        public ViTriService(QlnsContext context) { 
            _context = context;
        }
        public async Task<List<ViTri>> GetListVT()
        {
            List<ViTri> congViecs = await _context.ViTris.ToListAsync();
            return congViecs;
        }
    }
}
