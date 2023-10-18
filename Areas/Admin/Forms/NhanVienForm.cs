using QLNS.Models;
using System.ComponentModel.DataAnnotations;

namespace QLNS.Areas.Admin.Forms
{
    public class NhanVienForm
    {
        public string? MaNv { get; set; }

       
        public string? FirstName { get; set; }
       
        public string? LastName { get; set; }
       
        public string? Address { get; set; }
      
        public IFormFile? Image { get; set; }
       
        public DateTime? NgaySinh { get; set; }
      
        public string? GioiTinh { get; set; }
        
        public string? TrinhDo { get; set; }
        
        public string? ChuyenNganh { get; set; }
      
        public int? IdVitri { get; set; }
      
        public int? IdCongViec { get; set; }
       
        public string? maStatusNV { get; set; }
    }
}
