using System;
using System.Collections.Generic;

namespace QLNS.Models;

public partial class Luong
{
    public int IdNv { get; set; }

    public decimal? LuongCb { get; set; }

    public decimal? PhuCap { get; set; }

    public decimal? LuongTong { get; set; }

    public virtual NhanVien IdNvNavigation { get; set; } = null!;

    public virtual ICollection<LichSuLuong> LichSuLuongs { get; set; } = new List<LichSuLuong>();
}
