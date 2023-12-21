using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace StudentManagement.Infrastructure;

public partial class PsStudentContext : DbContext
{
    public PsStudentContext()
    {
    }

    //public PsStudentContext(DbContextOptions<PsStudentContext> options)
    //    : base(options)
    //{
    //}

    //public virtual DbSet<Student> Students { get; set; }

    //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    //    => optionsBuilder.UseNpgsql("Name=ConnectionStrings:DefaultConnection");

    //protected override void OnModelCreating(ModelBuilder modelBuilder)
    //{
    //    modelBuilder.Entity<Student>(entity =>
    //    {
    //        entity.HasKey(e => e.Id).HasName("students_pkey");

    //        entity.ToTable("students");

    //        entity.Property(e => e.Id).HasColumnName("id");
    //        entity.Property(e => e.BasisOfStudy)
    //            .HasMaxLength(50)
    //            .HasColumnName("basis_of_study");
    //        entity.Property(e => e.Citizenship)
    //            .HasMaxLength(100)
    //            .HasColumnName("citizenship");
    //        entity.Property(e => e.FormOfStudy)
    //            .HasMaxLength(50)
    //            .HasColumnName("form_of_study");
    //        entity.Property(e => e.FullName)
    //            .HasMaxLength(200)
    //            .HasColumnName("full_name");
    //        entity.Property(e => e.MaritalStatus)
    //            .HasMaxLength(20)
    //            .HasColumnName("marital_status");
    //        entity.Property(e => e.Nationality)
    //            .HasMaxLength(100)
    //            .HasColumnName("nationality");
    //        entity.Property(e => e.PassportData)
    //            .HasMaxLength(100)
    //            .HasColumnName("passport_data");
    //        entity.Property(e => e.PhoneNumber)
    //            .HasMaxLength(20)
    //            .HasColumnName("phone_number");
    //    });

    //    OnModelCreatingPartial(modelBuilder);
    //}

    //partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
