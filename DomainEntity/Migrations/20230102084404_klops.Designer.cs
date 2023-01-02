﻿// <auto-generated />
using System;
using DomainEntity.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DomainEntity.Migrations
{
    [DbContext(typeof(pishroContext))]
    [Migration("20230102084404_klops")]
    partial class klops
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("DomainEntity.Models.Customer", b =>
                {
                    b.Property<int>("CustomerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CustomerId"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("CodeMelli")
                        .HasColumnType("int");

                    b.Property<string>("Family")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Mobile")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("CustomerId");

                    b.ToTable("Customer");
                });

            modelBuilder.Entity("DomainEntity.Models.InvoiceCustomer", b =>
                {
                    b.Property<int>("InvoiceCustomerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("InvoiceCustomerId"));

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<int>("InvoiceId")
                        .HasColumnType("int");

                    b.HasKey("InvoiceCustomerId");

                    b.HasIndex("CustomerId");

                    b.HasIndex("InvoiceId");

                    b.ToTable("InvoiceCustomer");
                });

            modelBuilder.Entity("DomainEntity.Models.InvoiceRegister", b =>
                {
                    b.Property<int>("InvoiceRegisterId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("InvoiceRegisterId"));

                    b.Property<int>("InvoiceId")
                        .HasColumnType("int");

                    b.Property<int>("ProductCost")
                        .HasColumnType("int");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("ProductNumber")
                        .HasColumnType("int");

                    b.HasKey("InvoiceRegisterId");

                    b.HasIndex("InvoiceId");

                    b.ToTable("InvoiceRegister");
                });

            modelBuilder.Entity("DomainEntity.Models.Invoices", b =>
                {
                    b.Property<int>("InvoiceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("InvoiceId"));

                    b.Property<DateTime>("InvoiceDate")
                        .HasColumnType("datetime");

                    b.Property<string>("InvoiceName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("InvoiceId")
                        .HasName("PK_Invoice");

                    b.ToTable("Invoices");
                });

            modelBuilder.Entity("DomainEntity.Models.InvoiceCustomer", b =>
                {
                    b.HasOne("DomainEntity.Models.Customer", "Customer")
                        .WithMany("InvoiceCustomer")
                        .HasForeignKey("CustomerId")
                        .IsRequired()
                        .HasConstraintName("FK_InvoiceCustomer_Customer");

                    b.HasOne("DomainEntity.Models.Invoices", "Invoice")
                        .WithMany("InvoiceCustomer")
                        .HasForeignKey("InvoiceId")
                        .IsRequired()
                        .HasConstraintName("FK_InvoiceCustomer_Invoices");

                    b.Navigation("Customer");

                    b.Navigation("Invoice");
                });

            modelBuilder.Entity("DomainEntity.Models.InvoiceRegister", b =>
                {
                    b.HasOne("DomainEntity.Models.Invoices", "Invoice")
                        .WithMany("InvoiceRegister")
                        .HasForeignKey("InvoiceId")
                        .IsRequired()
                        .HasConstraintName("FK_InvoiceRegister_Invoices");

                    b.Navigation("Invoice");
                });

            modelBuilder.Entity("DomainEntity.Models.Customer", b =>
                {
                    b.Navigation("InvoiceCustomer");
                });

            modelBuilder.Entity("DomainEntity.Models.Invoices", b =>
                {
                    b.Navigation("InvoiceCustomer");

                    b.Navigation("InvoiceRegister");
                });
#pragma warning restore 612, 618
        }
    }
}
