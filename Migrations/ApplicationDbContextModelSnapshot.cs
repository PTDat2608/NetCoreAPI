﻿// <auto-generated />
using DemoMVC.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DemoMvc.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.8");

            modelBuilder.Entity("DemoMVC.Models.Entities.Person", b =>
                {
                    b.Property<string>("PersonID")
                        .HasColumnType("TEXT");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasMaxLength(8)
                        .HasColumnType("TEXT");

                    b.Property<string>("HoTen")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("QueQuan")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("PersonID");

                    b.ToTable("people");

                    b.HasDiscriminator().HasValue("Person");

                    b.UseTphMappingStrategy();
                });

            modelBuilder.Entity("DemoMVC.Models.Entities.Student", b =>
                {
                    b.Property<string>("StudentID")
                        .HasColumnType("TEXT");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Fullname")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("StudentID");

                    b.ToTable("Student");
                });

            modelBuilder.Entity("DemoMVC.Models.Entities.Employee", b =>
                {
                    b.HasBaseType("DemoMVC.Models.Entities.Person");

                    b.Property<string>("Company")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("EmployeeID")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasDiscriminator().HasValue("Employee");
                });
#pragma warning restore 612, 618
        }
    }
}
