﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace EmployeePortal.Model;

[Keyless]
[Table("EmployeeLogin_h", Schema = "history")]
public partial class EmployeeLoginH
{
    public Guid EmployeeId { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? EmployeeEmail { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string? EmployeePassword { get; set; }
}
