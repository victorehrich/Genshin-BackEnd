﻿// <auto-generated />
using System;
using GenshinApplication.DataContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace GenshinApplication.Migrations
{
    [DbContext(typeof(DataBaseContext))]
    [Migration("20230418152904_creating-tables")]
    partial class creatingtables
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("GenshinApplication.Models.Artifacts", b =>
                {
                    b.Property<Guid>("ArtifactsId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("ArtifactsType")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("SetId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Stars")
                        .HasColumnType("int");

                    b.HasKey("ArtifactsId");

                    b.HasIndex("SetId");

                    b.ToTable("Artifacts");
                });

            modelBuilder.Entity("GenshinApplication.Models.Characters", b =>
                {
                    b.Property<Guid>("CharactersId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Element")
                        .HasColumnType("int");

                    b.Property<int>("Gender")
                        .HasColumnType("int");

                    b.Property<int>("Location")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NumberOfStars")
                        .HasColumnType("int");

                    b.Property<int>("WeaponType")
                        .HasColumnType("int");

                    b.HasKey("CharactersId");

                    b.ToTable("Characters");
                });

            modelBuilder.Entity("GenshinApplication.Models.Constelation", b =>
                {
                    b.Property<Guid>("ConstelationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("CharactersId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("ContellationLevel")
                        .HasColumnType("int");

                    b.Property<string>("Effect")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ConstelationId");

                    b.HasIndex("CharactersId");

                    b.ToTable("Constelation");
                });

            modelBuilder.Entity("GenshinApplication.Models.Set", b =>
                {
                    b.Property<Guid>("SetId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SetBonusOne")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SetBonusTwo")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SetId");

                    b.ToTable("Set");
                });

            modelBuilder.Entity("GenshinApplication.Models.Weapon", b =>
                {
                    b.Property<Guid>("WeaponId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Effect")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Stars")
                        .HasColumnType("int");

                    b.HasKey("WeaponId");

                    b.ToTable("Weapons");
                });

            modelBuilder.Entity("GenshinApplication.Models.Artifacts", b =>
                {
                    b.HasOne("GenshinApplication.Models.Set", "Set")
                        .WithMany()
                        .HasForeignKey("SetId");

                    b.Navigation("Set");
                });

            modelBuilder.Entity("GenshinApplication.Models.Constelation", b =>
                {
                    b.HasOne("GenshinApplication.Models.Characters", "Characters")
                        .WithMany("Constelation")
                        .HasForeignKey("CharactersId");

                    b.Navigation("Characters");
                });

            modelBuilder.Entity("GenshinApplication.Models.Characters", b =>
                {
                    b.Navigation("Constelation");
                });
#pragma warning restore 612, 618
        }
    }
}
