using Microsoft.EntityFrameworkCore;
using QLNS.Areas.Admin.Forms;
using QLNS.Models;

namespace QLNS.Areas.Admin.Services
{
    public class NhanVienService
    {
        private readonly QlnsContext _context;
        public NhanVienService(QlnsContext context) { 
            _context = context;
        }
        public async Task<List<NhanVien>> GetListNV()
        {
            List<NhanVien> nhanViens = await _context.NhanViens
                .Include(n => n.IdVitriNavigation)
                .Include(n => n.IdCongViecNavigation)
                .Include(n => n.StatusNhanVien)
                .ToListAsync();
            return nhanViens;
        }
        public async Task<NhanVien?> GetNV(string maNV)
        {
            NhanVien? nhanViens = await _context.NhanViens.Where(n => n.MaNv == maNV).FirstOrDefaultAsync();
            return nhanViens;
        }
        public async Task<NhanVien?> updateNV(string maNV)
        {
            NhanVien? nhanViens = await _context.NhanViens.Where(nv => nv.MaNv == maNV).FirstOrDefaultAsync();
            return nhanViens;
        }
        public async Task ThemNhanVienAsync(NhanVienForm nhanVienForm)
        {
            NhanVien? nhanVien = await GetNV(nhanVienForm.MaNv!);
            if (nhanVien != null)
            {
                throw new Exception("Nhân viên đã tồn tại!");
            }
            NhanVien? nhanVienNew = new NhanVien() {
                MaNv = nhanVienForm.MaNv,
                FistName = nhanVienForm.FirstName,
                LastName = nhanVienForm.LastName,
                Address = nhanVienForm.Address, 
                Image = nhanVienForm.Image?.FileName,
                NgaySinh = nhanVienForm.NgaySinh, 
                GioiTinh = nhanVienForm.GioiTinh,
                TrinhDo = nhanVienForm.TrinhDo, 
                ChuyenNganh = nhanVienForm.ChuyenNganh, 
                IdVitri = nhanVienForm.IdVitri,
                IdCongViec = nhanVienForm.IdCongViec,
                maStatus = nhanVienForm.maStatusNV
            };
            await _context.NhanViens.AddAsync(nhanVienNew);
            await _context.SaveChangesAsync();
        }
    }
}
