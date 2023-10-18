using System;
using System.Collections.Generic;

namespace QLNS.Models;

public partial class NhanVienShip
{
    public int Id { get; set; }

    public int? IdNv { get; set; }

    public int? IdNnv { get; set; }

    public virtual NhomNhanVien? IdNnvNavigation { get; set; }

    public virtual NhanVien? IdNvNavigation { get; set; }
}
