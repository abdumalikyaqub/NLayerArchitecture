using Microsoft.EntityFrameworkCore;
using StudentManagement.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement.Infrastructure.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
            bool isAvalaible = Database.CanConnect();
            // bool isAvalaible2 = await db.Database.CanConnectAsync();
            if (isAvalaible) Console.WriteLine("База данных доступна");
            else Console.WriteLine("База данных не доступна");
        }
        public DbSet<Student> Students { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Здесь вы можете настроить маппинг сущностей на таблицы, добавить индексы и т.д.
            base.OnModelCreating(modelBuilder);
            // modelBuilder.Entity<Student>().ToTable("students"); // Укажите имя существующей таблицы
            modelBuilder.Entity<Student>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("students_pkey");

                entity.ToTable("students");

                entity.Property(e => e.Id).HasColumnName("id");
                entity.Property(e => e.BasisOfStudy)
                    .HasMaxLength(50)
                    .HasColumnName("basis_of_study");
                entity.Property(e => e.Citizenship)
                    .HasMaxLength(100)
                    .HasColumnName("citizenship");
                entity.Property(e => e.FormOfStudy)
                    .HasMaxLength(50)
                    .HasColumnName("form_of_study");
                entity.Property(e => e.FullName)
                    .HasMaxLength(200)
                    .HasColumnName("full_name");
                entity.Property(e => e.MaritalStatus)
                    .HasMaxLength(20)
                    .HasColumnName("marital_status");
                entity.Property(e => e.Nationality)
                    .HasMaxLength(100)
                    .HasColumnName("nationality");
                entity.Property(e => e.PassportData)
                    .HasMaxLength(100)
                    .HasColumnName("passport_data");
                entity.Property(e => e.PhoneNumber)
                    .HasMaxLength(20)
                    .HasColumnName("phone_number");
            });

        }
    }
}
