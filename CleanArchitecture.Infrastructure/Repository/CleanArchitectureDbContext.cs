using System;
using System.Collections.Generic;
using CleanArchitecture.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace CleanArchitecture.Infrastructure.Repository;

public partial class CleanArchitectureDbContext : DbContext
{
    public CleanArchitectureDbContext()
    {
    }

    public CleanArchitectureDbContext(DbContextOptions<CleanArchitectureDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<InitModel> InitModels { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlite("Name=ConnectionStrings:Default");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<InitModel>(entity =>
        {
            entity.ToTable("InitModel");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
