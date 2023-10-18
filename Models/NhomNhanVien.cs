using System;
using System.Collections.Generic;

namespace QLNS.Models;

public partial class NhomNhanVien
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string NoiDung { get; set; } = null!;

    public virtual ICollection<NhanVienShip> NhanVienShips { get; set; } = new List<NhanVienShip>();
}
