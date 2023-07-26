using System;
using System.Collections.Generic;

namespace LoanAcceleratorProject.Models;

public partial class FamilyDetail
{
    public int FamilyDetailsId { get; set; }

    public string? SpouseName { get; set; }

    public string? Profession { get; set; }

    public string? NameOfOrganisation { get; set; }

    public long? MobileNo { get; set; }

    public long? OfficeContactNo { get; set; }

    public string? EmailId { get; set; }

    public string? JointAccount { get; set; }

    public int? LoanId { get; set; }

    public DateTime? Date { get; set; }

    public virtual LoanTable? Loan { get; set; }
}
