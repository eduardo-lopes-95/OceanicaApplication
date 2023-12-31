﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Oceanica.API.Data;

#nullable disable

namespace Oceanica.API.Migrations
{
    [DbContext(typeof(OceanicaContext))]
    [Migration("20230809190717_FirstMigration")]
    partial class FirstMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.21")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Oceanica.API.Models.CrewMember", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("DepartamentId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("DepartamentId");

                    b.ToTable("Crews");
                });

            modelBuilder.Entity("Oceanica.API.Models.Departament", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("VesselId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("VesselId");

                    b.ToTable("Departaments");
                });

            modelBuilder.Entity("Oceanica.API.Models.Vessel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("BuildAt")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("PhotoFileName")
                        .HasColumnType("longtext");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Vessels");
                });

            modelBuilder.Entity("Oceanica.API.Models.CrewMember", b =>
                {
                    b.HasOne("Oceanica.API.Models.Departament", "Departament")
                        .WithMany("Crew")
                        .HasForeignKey("DepartamentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Departament");
                });

            modelBuilder.Entity("Oceanica.API.Models.Departament", b =>
                {
                    b.HasOne("Oceanica.API.Models.Vessel", "Vessel")
                        .WithMany("Departaments")
                        .HasForeignKey("VesselId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Vessel");
                });

            modelBuilder.Entity("Oceanica.API.Models.Departament", b =>
                {
                    b.Navigation("Crew");
                });

            modelBuilder.Entity("Oceanica.API.Models.Vessel", b =>
                {
                    b.Navigation("Departaments");
                });
#pragma warning restore 612, 618
        }
    }
}
