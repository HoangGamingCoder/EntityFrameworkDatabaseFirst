﻿using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

public partial class SinhVien
{
    public int SinhVienId { get; set; }

    public string? Ten { get; set; }

    public int? Tuoi { get; set; }

    public int? LopId { get; set; }

    public virtual Lop? Lop { get; set; }
}
