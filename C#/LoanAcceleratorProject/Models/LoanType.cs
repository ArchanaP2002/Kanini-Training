using System;
using System.Collections.Generic;

namespace LoanAcceleratorProject.Models;

public partial class LoanType
{
    public int TypeId { get; set; }

    public int? Type { get; set; }

    public virtual ICollection<LoanTable> LoanTables { get; set; } = new List<LoanTable>();
}
