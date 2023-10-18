using System;
using System.Collections.Generic;

namespace QLNS.Models;

public partial class ThongBao
{
    public int Id { get; set; }

    public int? IdNghiPhep { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? Deleted { get; set; }
}
