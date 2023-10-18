using System;
using System.Collections.Generic;

namespace QLNS.Models;

public partial class KyLuatAndKhenThuong
{
    public int Id { get; set; }

    public int? IdNv { get; set; }

    public string? MaTrangThai { get; set; }

    public string? NoiDung { get; set; }

    public virtual NhanVien? IdNvNavigation { get; set; }

    public virtual TrangThai? MaTrangThaiNavigation { get; set; }
}
