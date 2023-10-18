using System;
using System.Collections.Generic;

namespace QLNS.Models;

public partial class ChamCong
{
    public int Id { get; set; }

    public int? IdNv { get; set; }

    public string? MaTrangThai { get; set; }

    public DateTime? GioVaoLam { get; set; }

    public DateTime? GioRaLam { get; set; }

    public int? TongSoGio { get; set; }

    public virtual NhanVien? IdNvNavigation { get; set; }

    public virtual TrangThai? MaTrangThaiNavigation { get; set; }
}
