using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Figma.Models;

public partial class FigmaContext : DbContext
{
    public FigmaContext()
    {
    }

    public FigmaContext(DbContextOptions<FigmaContext> options)
        : base(options)
    {
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    => optionsBuilder.UseSqlServer("data source=LAPTOP-PKS4NBKU\\SQLEXPRESS; initial catalog=figma; integrated security=SSPI; TrustServerCertificate=True;");
    Login customer { get; set; }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
