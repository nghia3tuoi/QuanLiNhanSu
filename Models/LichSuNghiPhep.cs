using System;
using System.Collections.Generic;

namespace QLNS.Models;

public partial class LichSuNghiPhep
{
    public int Id { get; set; }

    public int? IdNv { get; set; }

    public int? IdNghiPhep { get; set; }

    public string? NoiDung { get; set; }

    public DateTime? NgayNghi { get; set; }

    public DateTime? NgayKetThucNghi { get; set; }

    public string? MaTrangThai { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? Deleted { get; set; }

    public virtual NhanVien? IdNvNavigation { get; set; }
}
