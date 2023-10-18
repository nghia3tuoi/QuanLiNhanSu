using System;
using System.Collections.Generic;

namespace QLNS.Models;

public partial class HopDongLaoDong
{
    public int IdNv { get; set; }

    public int? IdLuong { get; set; }

    public int? IdPb { get; set; }

    public string? MaTrangThai { get; set; }

    public int? IdCv { get; set; }

    public int? IdVt { get; set; }

    public DateTime? NgayLamViec { get; set; }

    public DateTime? NgayKetThuc { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public DateTime? Deleted { get; set; }

    public virtual CongViec? IdCvNavigation { get; set; }

    public virtual NhanVien IdNvNavigation { get; set; } = null!;

    public virtual PhongBan? IdPbNavigation { get; set; }

    public virtual ViTri? IdVtNavigation { get; set; }

    public virtual TrangThai? MaTrangThaiNavigation { get; set; }
}
