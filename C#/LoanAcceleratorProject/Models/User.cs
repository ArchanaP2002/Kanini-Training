using System;
using System.Collections.Generic;

namespace LoanAcceleratorProject.Models;

public partial class User
{
    public int UserId { get; set; }

    public string? Name { get; set; }

    public Guid? UniqueId { get; set; }

    public string? EmailId { get; set; }

    public string? Password { get; set; }

    public int? RoleId { get; set; }

    public DateTime? Date { get; set; }

    public virtual ICollection<LoanTable> LoanTables { get; set; } = new List<LoanTable>();

    public virtual Role? Role { get; set; }
}
