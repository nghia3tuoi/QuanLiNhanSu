using System;
using System.Collections.Generic;

namespace QLNS.Models;

public partial class CongViec
{
    public int Id { get; set; }

    public string? NameCv { get; set; }

    public virtual ICollection<HopDongLaoDong> HopDongLaoDongs { get; set; } = new List<HopDongLaoDong>();

    public virtual ICollection<NhanVien> NhanViens { get; set; } = new List<NhanVien>();
}
