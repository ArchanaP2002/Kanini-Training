using System;
using System.Collections.Generic;

namespace EmployeeCRUD.Models;

public partial class Employee
{
    public Guid Id { get; set; }

    public string? Name { get; set; }

    public string? PhoneNo { get; set; }

    public string? Email { get; set; }
}
