﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OP_beContext.EFContext;

#nullable disable

namespace OP_beContext.Migrations
{
    [DbContext(typeof(OPbeContext))]
    partial class OPbeContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("OP_beModel.Entities.Closet", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("UserId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("Closet", (string)null);
                });

            modelBuilder.Entity("OP_beModel.Entities.Item", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"), 1L, 1);

                    b.Property<long>("ClosetId")
                        .HasColumnType("bigint");

                    b.Property<string>("Colour")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Fit")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ItemType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Size")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ClosetId");

                    b.ToTable("Item", (string)null);
                });

            modelBuilder.Entity("OP_beModel.Entities.Person", b =>
                {
                    b.Property<long>("PersonId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("PersonId"), 1L, 1);

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasMaxLength(13)
                        .HasColumnType("nvarchar(13)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PersonId");

                    b.ToTable("Persons", (string)null);

                    b.HasDiscriminator<string>("Discriminator").HasValue("Person");
                });

            modelBuilder.Entity("OP_beModel.Entities.Report", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"), 1L, 1);

                    b.Property<DateTime>("SnapshotDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Reports", (string)null);
                });

            modelBuilder.Entity("OP_beModel.Entities.Ticket", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Subject")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("UserId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Tickets", (string)null);
                });

            modelBuilder.Entity("ReportUser", b =>
                {
                    b.Property<long>("ReportsId")
                        .HasColumnType("bigint");

                    b.Property<long>("UsersPersonId")
                        .HasColumnType("bigint");

                    b.HasKey("ReportsId", "UsersPersonId");

                    b.HasIndex("UsersPersonId");

                    b.ToTable("ReportUser");
                });

            modelBuilder.Entity("OP_beModel.Entities.Administrator", b =>
                {
                    b.HasBaseType("OP_beModel.Entities.Person");

                    b.Property<int>("Level")
                        .HasColumnType("int");

                    b.Property<string>("Token")
                        .HasColumnType("nvarchar(max)");

                    b.ToTable("Persons", (string)null);

                    b.HasDiscriminator().HasValue("Administrator");
                });

            modelBuilder.Entity("OP_beModel.Entities.User", b =>
                {
                    b.HasBaseType("OP_beModel.Entities.Person");

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DateOfBirth")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Firstname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gender")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Lastname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.ToTable("Persons", (string)null);

                    b.HasDiscriminator().HasValue("User");
                });

            modelBuilder.Entity("OP_beModel.Entities.Closet", b =>
                {
                    b.HasOne("OP_beModel.Entities.User", "User")
                        .WithOne("Closet")
                        .HasForeignKey("OP_beModel.Entities.Closet", "UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("OP_beModel.Entities.Item", b =>
                {
                    b.HasOne("OP_beModel.Entities.Closet", "Closet")
                        .WithMany("Items")
                        .HasForeignKey("ClosetId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Closet");
                });

            modelBuilder.Entity("OP_beModel.Entities.Ticket", b =>
                {
                    b.HasOne("OP_beModel.Entities.User", "User")
                        .WithMany("Ticket")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("ReportUser", b =>
                {
                    b.HasOne("OP_beModel.Entities.Report", null)
                        .WithMany()
                        .HasForeignKey("ReportsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("OP_beModel.Entities.User", null)
                        .WithMany()
                        .HasForeignKey("UsersPersonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("OP_beModel.Entities.Closet", b =>
                {
                    b.Navigation("Items");
                });

            modelBuilder.Entity("OP_beModel.Entities.User", b =>
                {
                    b.Navigation("Closet");

                    b.Navigation("Ticket");
                });
#pragma warning restore 612, 618
        }
    }
}
