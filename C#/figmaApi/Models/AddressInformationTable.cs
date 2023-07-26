using System;
using System.Collections.Generic;

namespace figmaApi.Models;

public partial class AddressInformationTable
{
    public int AddressInformationId { get; set; }

    public string PresentAddress { get; set; } = null!;

    public string PermanentAddress { get; set; } = null!;

    public string? District { get; set; }

    public string? Country { get; set; }

    public string EmailId { get; set; } = null!;

    public long Mobile1 { get; set; }

    public long Mobile2 { get; set; }

    public long TelephoneNo { get; set; }

    public int? LoanId { get; set; }
}
