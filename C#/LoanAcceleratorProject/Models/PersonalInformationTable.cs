using System;
using System.Collections.Generic;

namespace LoanAcceleratorProject.Models;

public partial class PersonalInformationTable
{
    public int PersonalInformationId { get; set; }

    public string? Fullname { get; set; }

    public DateTime? Dob { get; set; }

    public string? DistrictofBirth { get; set; }

    public string? CoutryOfBirth { get; set; }

    public int? TaxId { get; set; }

    public string? EducationQualification { get; set; }

    public string? ResidentialStatus { get; set; }

    public int? ResidingFor { get; set; }

    public string? Gender { get; set; }

    public string? IsExistingCustomer { get; set; }

    public string? FathersName { get; set; }

    public string? MothersName { get; set; }

    public string? NationalId { get; set; }

    public DateTime? DateOfInsurance { get; set; }

    public string? CountryOfInsurance { get; set; }

    public string? Nationality { get; set; }

    public string? MaritalStatus { get; set; }

    public int? LoanId { get; set; }

    public DateTime? Date { get; set; }

    public virtual LoanTable? Loan { get; set; }
}
