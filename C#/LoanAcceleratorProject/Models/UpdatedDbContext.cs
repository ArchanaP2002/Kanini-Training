using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace LoanAcceleratorProject.Models;

public partial class UpdatedDbContext : DbContext
{
    public UpdatedDbContext()
    {
    }

    public UpdatedDbContext(DbContextOptions<UpdatedDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<AddressInformationTable> AddressInformationTables { get; set; }

    public virtual DbSet<EmergencyContactDetail> EmergencyContactDetails { get; set; }

    public virtual DbSet<EmployementTable> EmployementTables { get; set; }

    public virtual DbSet<FamilyDetail> FamilyDetails { get; set; }

    public virtual DbSet<FinancialInformationTable> FinancialInformationTables { get; set; }

    public virtual DbSet<LoanCategory> LoanCategories { get; set; }

    public virtual DbSet<LoanDocumentsTable> LoanDocumentsTables { get; set; }

    public virtual DbSet<LoanTable> LoanTables { get; set; }

    public virtual DbSet<LoanType> LoanTypes { get; set; }

    public virtual DbSet<PersonalInformationTable> PersonalInformationTables { get; set; }

    public virtual DbSet<Role> Roles { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("data source=LAPTOP-PKS4NBKU\\SQLEXPRESS; initial catalog=UpdatedDB; integrated security=SSPI;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<AddressInformationTable>(entity =>
        {
            entity.HasKey(e => e.AddressInformationId).HasName("PK__AddressI__E0EBE5A4A2B25607");

            entity.ToTable("AddressInformationTable");

            entity.Property(e => e.Country).HasMaxLength(50);
            entity.Property(e => e.Date)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.District).HasMaxLength(50);
            entity.Property(e => e.EmailId).HasMaxLength(50);
            entity.Property(e => e.PermanantAddress).HasMaxLength(100);
            entity.Property(e => e.PresentAddress).HasMaxLength(100);

            entity.HasOne(d => d.Loan).WithMany(p => p.AddressInformationTables)
                .HasForeignKey(d => d.LoanId)
                .HasConstraintName("FK__AddressIn__LoanI__6754599E");
        });

        modelBuilder.Entity<EmergencyContactDetail>(entity =>
        {
            entity.HasKey(e => e.EmergencyContactId).HasName("PK__Emergenc__E8A61D8E06B10C8D");

            entity.Property(e => e.Address).HasMaxLength(100);
            entity.Property(e => e.Date)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Name).HasMaxLength(59);
            entity.Property(e => e.Relation).HasMaxLength(25);

            entity.HasOne(d => d.Loan).WithMany(p => p.EmergencyContactDetails)
                .HasForeignKey(d => d.LoanId)
                .HasConstraintName("FK__Emergency__LoanI__68487DD7");
        });

        modelBuilder.Entity<EmployementTable>(entity =>
        {
            entity.HasKey(e => e.EmploymentId).HasName("PK__Employem__FDC872B6C718B17D");

            entity.ToTable("EmployementTable");

            entity.Property(e => e.CompanyName).HasMaxLength(50);
            entity.Property(e => e.Date)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Designation).HasMaxLength(30);
            entity.Property(e => e.EmailId).HasMaxLength(50);
            entity.Property(e => e.EmployeeStatus).HasMaxLength(30);
            entity.Property(e => e.EmploymentType).HasMaxLength(9);
            entity.Property(e => e.OfficeAddress).HasMaxLength(100);

            entity.HasOne(d => d.Loan).WithMany(p => p.EmployementTables)
                .HasForeignKey(d => d.LoanId)
                .HasConstraintName("FK__Employeme__LoanI__693CA210");
        });

        modelBuilder.Entity<FamilyDetail>(entity =>
        {
            entity.HasKey(e => e.FamilyDetailsId).HasName("PK__FamilyDe__41067C25E079716D");

            entity.Property(e => e.Date)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.EmailId).HasMaxLength(50);
            entity.Property(e => e.JointAccount).HasMaxLength(5);
            entity.Property(e => e.NameOfOrganisation).HasMaxLength(50);
            entity.Property(e => e.Profession).HasMaxLength(25);
            entity.Property(e => e.SpouseName).HasMaxLength(25);

            entity.HasOne(d => d.Loan).WithMany(p => p.FamilyDetails)
                .HasForeignKey(d => d.LoanId)
                .HasConstraintName("FK__FamilyDet__LoanI__6A30C649");
        });

        modelBuilder.Entity<FinancialInformationTable>(entity =>
        {
            entity.HasKey(e => e.FinancialInformationId).HasName("PK__Financia__713EF8511A247550");

            entity.ToTable("FinancialInformationTable");

            entity.Property(e => e.FinancialInformationId).HasColumnName("FinancialInformationID");
            entity.Property(e => e.Cfwob)
                .HasMaxLength(5)
                .HasColumnName("CFWOB");
            entity.Property(e => e.Date)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Dwob)
                .HasMaxLength(5)
                .HasColumnName("DWOB");
            entity.Property(e => e.Education).HasColumnType("money");
            entity.Property(e => e.FoodAndClothing).HasColumnType("money");
            entity.Property(e => e.IncomeRent).HasColumnType("money");
            entity.Property(e => e.IncomeSalary).HasColumnType("money");
            entity.Property(e => e.InterstRate).HasColumnType("money");
            entity.Property(e => e.LoanRepayment)
                .HasColumnType("money")
                .HasColumnName("LoanREpayment");
            entity.Property(e => e.OtherExpenses).HasColumnType("money");
            entity.Property(e => e.OtherIncome).HasColumnType("money");
            entity.Property(e => e.RentAndUtility).HasColumnType("money");

            entity.HasOne(d => d.Loan).WithMany(p => p.FinancialInformationTables)
                .HasForeignKey(d => d.LoanId)
                .HasConstraintName("FK__Financial__LoanI__6B24EA82");
        });

        modelBuilder.Entity<LoanCategory>(entity =>
        {
            entity.HasKey(e => e.CategoryId).HasName("PK__LoanCate__19093A0BC7DD1985");

            entity.ToTable("LoanCategory");
        });

        modelBuilder.Entity<LoanDocumentsTable>(entity =>
        {
            entity.HasKey(e => e.LoanDocuments).HasName("PK__LoanDocu__D50F95AFB8F08C67");

            entity.ToTable("LoanDocumentsTable");

            entity.Property(e => e.Date)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.IdProof).HasMaxLength(100);
            entity.Property(e => e.PassportSizePhoto).HasMaxLength(100);
            entity.Property(e => e.SignaturePhoto).HasMaxLength(100);

            entity.HasOne(d => d.Loan).WithMany(p => p.LoanDocumentsTables)
                .HasForeignKey(d => d.LoanId)
                .HasConstraintName("FK__LoanDocum__LoanI__6C190EBB");
        });

        modelBuilder.Entity<LoanTable>(entity =>
        {
            entity.HasKey(e => e.LoanId).HasName("PK__LoanTABL__4F5AD4578BA4EE1E");

            entity.ToTable("LoanTABLE");

            entity.Property(e => e.Amount).HasColumnType("money");
            entity.Property(e => e.Date).HasColumnType("date");
            entity.Property(e => e.ExpectedExpenditure).HasColumnType("money");
            entity.Property(e => e.PurposeOfLoan).HasMaxLength(50);
            entity.Property(e => e.Tenure).HasMaxLength(10);

            entity.HasOne(d => d.LoanCategory).WithMany(p => p.LoanTables)
                .HasForeignKey(d => d.LoanCategoryId)
                .HasConstraintName("FK_categoryId");

            entity.HasOne(d => d.LoanType).WithMany(p => p.LoanTables)
                .HasForeignKey(d => d.LoanTypeId)
                .HasConstraintName("FK_typeId");

            entity.HasOne(d => d.User).WithMany(p => p.LoanTables)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK_Loan_User");
        });

        modelBuilder.Entity<LoanType>(entity =>
        {
            entity.HasKey(e => e.TypeId).HasName("PK__LoanType__516F03B594A0876B");

            entity.ToTable("LoanType");
        });

        modelBuilder.Entity<PersonalInformationTable>(entity =>
        {
            entity.HasKey(e => e.PersonalInformationId).HasName("PK__Personal__09730AF8F392FC19");

            entity.ToTable("PersonalInformationTable");

            entity.Property(e => e.CountryOfInsurance).HasMaxLength(50);
            entity.Property(e => e.CoutryOfBirth).HasMaxLength(50);
            entity.Property(e => e.Date)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.DateOfInsurance).HasColumnType("date");
            entity.Property(e => e.DistrictofBirth).HasMaxLength(50);
            entity.Property(e => e.Dob)
                .HasColumnType("date")
                .HasColumnName("DOB");
            entity.Property(e => e.EducationQualification).HasMaxLength(50);
            entity.Property(e => e.FathersName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Fullname).HasMaxLength(50);
            entity.Property(e => e.Gender).HasMaxLength(11);
            entity.Property(e => e.IsExistingCustomer).HasMaxLength(5);
            entity.Property(e => e.MaritalStatus).HasMaxLength(9);
            entity.Property(e => e.MothersName).HasMaxLength(50);
            entity.Property(e => e.NationalId).HasMaxLength(50);
            entity.Property(e => e.Nationality).HasMaxLength(50);
            entity.Property(e => e.ResidentialStatus).HasMaxLength(50);

            entity.HasOne(d => d.Loan).WithMany(p => p.PersonalInformationTables)
                .HasForeignKey(d => d.LoanId)
                .HasConstraintName("FK__PersonalI__LoanI__6FE99F9F");
        });

        modelBuilder.Entity<Role>(entity =>
        {
            entity.HasKey(e => e.RoleId).HasName("PK__Role__8AFACE1A5045D7D5");

            entity.ToTable("Role");

            entity.Property(e => e.Role1)
                .HasMaxLength(10)
                .HasColumnName("Role");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.UserId).HasName("PK__Users__1788CC4C43E96C8D");

            entity.Property(e => e.Date)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.EmailId).HasMaxLength(50);
            entity.Property(e => e.Name).HasMaxLength(50);
            entity.Property(e => e.Password).HasMaxLength(100);
            entity.Property(e => e.UniqueId).HasDefaultValueSql("(newid())");

            entity.HasOne(d => d.Role).WithMany(p => p.Users)
                .HasForeignKey(d => d.RoleId)
                .HasConstraintName("FK_User_RoleId");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
