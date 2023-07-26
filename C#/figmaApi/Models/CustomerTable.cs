using System;
using System.Collections.Generic;

namespace figmaApi.Models;

public partial class CustomerTable
{
    public int CustomerId { get; set; }

    public string? Name { get; set; }

    public string? EmailId { get; set; }

    public long? Password { get; set; }
}
