using System;
using System.Collections.Generic;

namespace LoanAcceleratorProject.Models;

public partial class LoanDocumentsTable
{
    public int LoanDocuments { get; set; }

    public int? LoanId { get; set; }

    public string? PassportSizePhoto { get; set; }

    public string? SignaturePhoto { get; set; }

    public string? IdProof { get; set; }

    public DateTime? Date { get; set; }

    public virtual LoanTable? Loan { get; set; }
}
