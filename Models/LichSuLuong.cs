using System;
using System.Collections.Generic;

namespace QLNS.Models;

public partial class LichSuLuong
{
    public int Id { get; set; }

    public int? IdNv { get; set; }

    public int? IdLuong { get; set; }

    public int? IdPttt { get; set; }

    public int? SoNgayNghi { get; set; }

    public string? NoiDung { get; set; }

    public DateTime? NgayThanhToan { get; set; }

    public string? MaTrangThai { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdateAt { get; set; }

    public DateTime? Deleted { get; set; }

    public virtual Luong? IdLuongNavigation { get; set; }

    public virtual NhanVien? IdNvNavigation { get; set; }

    public virtual TrangThai? MaTrangThaiNavigation { get; set; }
}
