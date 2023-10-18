
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace QLNS.Models;

public partial class NhanVien
{
    public int Id { get; set; }

    public string? MaNv { get; set; }

    public string? FistName { get; set; }

    public string? LastName { get; set; }

    public string? Address { get; set; }

    public string? Image { get; set; }

    public DateTime? NgaySinh { get; set; }

    public string? GioiTinh { get; set; }
    public string? TrinhDo { get; set; }

    public string? ChuyenNganh { get; set; }

    public int? IdVitri { get; set; }

    public int? IdCongViec { get; set; }
    public string? maStatus { get; set; }

    [ForeignKey("maStatus")]
    public virtual StatusNhanVien? StatusNhanVien { get; set; }
    public virtual ICollection<ChamCong> ChamCongs { get; set; } = new List<ChamCong>();

    public virtual ICollection<DaoTao> DaoTaos { get; set; } = new List<DaoTao>();

    public virtual ICollection<HieuSuat> HieuSuats { get; set; } = new List<HieuSuat>();

    public virtual HopDongLaoDong? HopDongLaoDong { get; set; }

    public virtual CongViec? IdCongViecNavigation { get; set; }

    public virtual ViTri? IdVitriNavigation { get; set; }

    public virtual ICollection<KyLuatAndKhenThuong> KyLuatAndKhenThuongs { get; set; } = new List<KyLuatAndKhenThuong>();

    public virtual ICollection<LichSuLuong> LichSuLuongs { get; set; } = new List<LichSuLuong>();

    public virtual ICollection<LichSuNghiPhep> LichSuNghiPheps { get; set; } = new List<LichSuNghiPhep>();

    public virtual Luong? Luong { get; set; }

    public virtual ICollection<NhanVienShip> NhanVienShips { get; set; } = new List<NhanVienShip>();

    public virtual ICollection<PhongBan> PhongBans { get; set; } = new List<PhongBan>();
}
