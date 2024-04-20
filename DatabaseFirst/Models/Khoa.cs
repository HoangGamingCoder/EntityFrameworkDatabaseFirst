using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

public partial class Khoa
{
    public int KhoaId { get; set; }

    public string? TenKhoa { get; set; }

    public virtual ICollection<Lop> Lops { get; set; } = new List<Lop>();
}
