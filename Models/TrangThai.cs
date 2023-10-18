using System;
using System.Collections.Generic;

namespace QLNS.Models;

public partial class TrangThai
{
    public string Ma { get; set; } = null!;

    public string? Name { get; set; }

    public virtual ICollection<ChamCong> ChamCongs { get; set; } = new List<ChamCong>();

    public virtual ICollection<DaoTao> DaoTaos { get; set; } = new List<DaoTao>();

    public virtual ICollection<HopDongLaoDong> HopDongLaoDongs { get; set; } = new List<HopDongLaoDong>();

    public virtual ICollection<KyLuatAndKhenThuong> KyLuatAndKhenThuongs { get; set; } = new List<KyLuatAndKhenThuong>();

    public virtual ICollection<LichSuLuong> LichSuLuongs { get; set; } = new List<LichSuLuong>();
}
