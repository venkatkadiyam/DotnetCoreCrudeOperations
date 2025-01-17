﻿using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace jwt_token_based_authentication.models;

public partial class DotNetCoreContext : DbContext
{
    public DotNetCoreContext()
    {
    }

    public DotNetCoreContext(DbContextOptions<DotNetCoreContext> options)
        : base(options)
    {
    }

    public virtual DbSet<CredentialTable> CredentialTables { get; set; }

    public virtual DbSet<EmpList> EmpLists { get; set; }

    public virtual DbSet<JwtTokenEmpTable> JwtTokenEmpTables { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=ADMIN;database=DotNetCore;Trusted_Connection=True;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<CredentialTable>(entity =>
        {
            entity.ToTable("CredentialTable");

            entity.Property(e => e.Password).HasMaxLength(50);
            entity.Property(e => e.Role).HasMaxLength(50);
            entity.Property(e => e.UserName).HasMaxLength(50);
        });

        modelBuilder.Entity<EmpList>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__EmpList__3214EC07FB09ED85");

            entity.ToTable("EmpList");

            entity.Property(e => e.Designation).HasMaxLength(60);
            entity.Property(e => e.Name).HasMaxLength(60);
        });

        modelBuilder.Entity<JwtTokenEmpTable>(entity =>
        {
            entity.ToTable("Jwt_Token_EMP_Table");

            entity.Property(e => e.Designation).HasMaxLength(60);
            entity.Property(e => e.Name).HasMaxLength(60);
            entity.Property(e => e.Password).HasMaxLength(10);
            entity.Property(e => e.Role).HasMaxLength(60);
            entity.Property(e => e.Token).HasMaxLength(1000);
            entity.Property(e => e.UserName).HasMaxLength(60);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
