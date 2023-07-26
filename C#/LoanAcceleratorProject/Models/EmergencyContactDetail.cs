using System;
using System.Collections.Generic;

namespace LoanAcceleratorProject.Models;

public partial class EmergencyContactDetail
{
    public int EmergencyContactId { get; set; }

    public string? Name { get; set; }

    public string? Relation { get; set; }

    public long? MobileNo { get; set; }

    public string? Address { get; set; }

    public int? LoanId { get; set; }

    public DateTime? Date { get; set; }

    public virtual LoanTable? Loan { get; set; }
}
