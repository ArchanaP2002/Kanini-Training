using System;
using System.Collections.Generic;

namespace LoanAcceleratorProject.Models;

public partial class LoanCategory
{
    public int CategoryId { get; set; }

    public int? Category { get; set; }

    public virtual ICollection<LoanTable> LoanTables { get; set; } = new List<LoanTable>();
}
