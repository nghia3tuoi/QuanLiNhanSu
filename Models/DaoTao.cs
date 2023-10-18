using System;
using System.Collections.Generic;

namespace QLNS.Models;

public partial class DaoTao
{
    public int Id { get; set; }

    public int? IdNv { get; set; }

    public string? MaTrangThai { get; set; }

    public int? IdPbDaoTao { get; set; }

    public DateTime? NgayDaoTao { get; set; }

    public DateTime? NgayKetThucDt { get; set; }

    public string? NdDaoTao { get; set; }

    public virtual NhanVien? IdNvNavigation { get; set; }

    public virtual PhongBan? IdPbDaoTaoNavigation { get; set; }

    public virtual TrangThai? MaTrangThaiNavigation { get; set; }
}
