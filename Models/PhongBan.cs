using System;
using System.Collections.Generic;

namespace QLNS.Models;

public partial class PhongBan
{
    public int Id { get; set; }

    public int? IdNguoiQuanLi { get; set; }

    public string? NamePb { get; set; }

    public string? DuAnThamGia { get; set; }

    public int? SoLuongNvtg { get; set; }

    public virtual ICollection<DaoTao> DaoTaos { get; set; } = new List<DaoTao>();

    public virtual ICollection<HopDongLaoDong> HopDongLaoDongs { get; set; } = new List<HopDongLaoDong>();

    public virtual NhanVien? IdNguoiQuanLiNavigation { get; set; }
}
