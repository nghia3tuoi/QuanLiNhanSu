using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace QLNS.Models;

public partial class StatusNhanVien
{
    [MaxLength(100)]
    [Key]
    public string Ma { get; set; }
    [MaxLength(100)]
    public string Name { get; set; }
}
