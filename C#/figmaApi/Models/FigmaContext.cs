using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace figmaApi.Models;

public partial class FigmaContext : DbContext
{
    public FigmaContext()
    {
    }

    public FigmaContext(DbContextOptions<FigmaContext> options)
        : base(options)
    {
    }

    public virtual DbSet<AddressInformationTable> AddressInformationTables { get; set; }

    public virtual DbSet<CustomerTable> CustomerTables { get; set; }

 

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("data source=LAPTOP-PKS4NBKU\\SQLEXPRESS; initial catalog=Figma; integrated security=SSPI; TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<AddressInformationTable>(entity =>
        {
            entity.HasKey(e => e.AddressInformationId).HasName("PK__AddressI__E0EBE5A48C449BB2");

            entity.ToTable("AddressInformationTable");

            entity.Property(e => e.AddressInformationId).ValueGeneratedNever();
            entity.Property(e => e.Country).HasMaxLength(20);
            entity.Property(e => e.District).HasMaxLength(10);
            entity.Property(e => e.EmailId).HasMaxLength(30);
            entity.Property(e => e.PermanentAddress).HasMaxLength(100);
            entity.Property(e => e.PresentAddress).HasMaxLength(100);
        });

        modelBuilder.Entity<CustomerTable>(entity =>
        {
            entity.HasKey(e => e.CustomerId).HasName("PK__Customer__A4AE64D83C976A59");

            entity.ToTable("CustomerTable");

            entity.Property(e => e.CustomerId).ValueGeneratedNever();
            entity.Property(e => e.EmailId).HasMaxLength(30);
            entity.Property(e => e.Name).HasMaxLength(25);
        });
 

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
