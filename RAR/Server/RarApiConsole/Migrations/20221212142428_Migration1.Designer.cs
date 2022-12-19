﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using RarApiConsole.providers;

#nullable disable

namespace RarApiConsole.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20221212142428_Migration1")]
    partial class Migration1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasDefaultSchema("public")
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("RarApiConsole.dataObjects.DoCandidate", b =>
                {
                    b.Property<int>("object_key")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("object_key"));

                    b.Property<int>("fk_profile")
                        .HasColumnType("integer");

                    b.Property<DateTime>("referred_at")
                        .HasColumnType("timestamp");

                    b.HasKey("object_key");

                    b.HasIndex("fk_profile");

                    b.ToTable("candidates", "public");
                });

            modelBuilder.Entity("RarApiConsole.dataObjects.DoProfile", b =>
                {
                    b.Property<int>("object_key")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("object_key"));

                    b.Property<string>("address")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("email")
                        .HasColumnType("varchar(40)");

                    b.Property<string>("initials")
                        .HasColumnType("varchar(10)");

                    b.Property<string>("name")
                        .HasColumnType("varchar(40)");

                    b.Property<string>("phone_number")
                        .HasColumnType("varchar(30)");

                    b.Property<string>("surname")
                        .HasColumnType("varchar(70)");

                    b.HasKey("object_key");

                    b.ToTable("profiles", "public");
                });

            modelBuilder.Entity("RarApiConsole.dataObjects.DoReferral", b =>
                {
                    b.Property<int>("object_key")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("object_key"));

                    b.Property<DateTime>("creation_dt")
                        .HasColumnType("timestamp");

                    b.Property<int>("fk_candidate")
                        .HasColumnType("integer");

                    b.Property<int>("fk_scoreboard")
                        .HasColumnType("integer");

                    b.Property<int>("fk_task")
                        .HasColumnType("integer");

                    b.Property<int>("fk_user")
                        .HasColumnType("integer");

                    b.Property<DateTime>("modification_dt")
                        .HasColumnType("timestamp");

                    b.HasKey("object_key");

                    b.HasIndex("fk_candidate");

                    b.HasIndex("fk_scoreboard");

                    b.HasIndex("fk_task");

                    b.HasIndex("fk_user");

                    b.ToTable("referrals", "public");
                });

            modelBuilder.Entity("RarApiConsole.dataObjects.DoReward", b =>
                {
                    b.Property<int>("object_key")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("object_key"));

                    b.Property<DateTime>("award_dt")
                        .HasColumnType("timestamp");

                    b.Property<int>("fk_user")
                        .HasColumnType("integer");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.HasKey("object_key");

                    b.HasIndex("fk_user");

                    b.ToTable("rewards", "public");
                });

            modelBuilder.Entity("RarApiConsole.dataObjects.DoScoreboard", b =>
                {
                    b.Property<int>("object_key")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("object_key"));

                    b.Property<DateTime?>("end_dt")
                        .HasColumnType("timestamp");

                    b.Property<int>("fk_user")
                        .HasColumnType("integer");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("varchar(40)");

                    b.Property<DateTime>("start_dt")
                        .HasColumnType("timestamp");

                    b.HasKey("object_key");

                    b.HasIndex("fk_user");

                    b.ToTable("scoreboards", "public");
                });

            modelBuilder.Entity("RarApiConsole.dataObjects.DoTask", b =>
                {
                    b.Property<int>("object_key")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("object_key"));

                    b.Property<string>("description")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<int>("points")
                        .HasColumnType("int");

                    b.HasKey("object_key");

                    b.ToTable("tasks", "public");
                });

            modelBuilder.Entity("RarApiConsole.dataObjects.DoUser", b =>
                {
                    b.Property<int>("object_key")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("object_key"));

                    b.Property<DateTime>("creation_dt")
                        .HasColumnType("timestamp");

                    b.Property<int?>("fk_profile")
                        .HasColumnType("integer");

                    b.Property<DateTime>("modification_dt")
                        .HasColumnType("timestamp");

                    b.Property<string>("password")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<int>("recruiter")
                        .HasColumnType("int");

                    b.Property<string>("username")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.HasKey("object_key");

                    b.HasIndex("fk_profile");

                    b.ToTable("users", "public");
                });

            modelBuilder.Entity("RarApiConsole.dataObjects.DoCandidate", b =>
                {
                    b.HasOne("RarApiConsole.dataObjects.DoProfile", null)
                        .WithMany()
                        .HasForeignKey("fk_profile")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("RarApiConsole.dataObjects.DoReferral", b =>
                {
                    b.HasOne("RarApiConsole.dataObjects.DoCandidate", null)
                        .WithMany()
                        .HasForeignKey("fk_candidate")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RarApiConsole.dataObjects.DoScoreboard", null)
                        .WithMany()
                        .HasForeignKey("fk_scoreboard")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RarApiConsole.dataObjects.DoTask", null)
                        .WithMany()
                        .HasForeignKey("fk_task")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RarApiConsole.dataObjects.DoUser", null)
                        .WithMany()
                        .HasForeignKey("fk_user")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("RarApiConsole.dataObjects.DoReward", b =>
                {
                    b.HasOne("RarApiConsole.dataObjects.DoUser", null)
                        .WithMany()
                        .HasForeignKey("fk_user")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("RarApiConsole.dataObjects.DoScoreboard", b =>
                {
                    b.HasOne("RarApiConsole.dataObjects.DoUser", null)
                        .WithMany()
                        .HasForeignKey("fk_user")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("RarApiConsole.dataObjects.DoUser", b =>
                {
                    b.HasOne("RarApiConsole.dataObjects.DoProfile", null)
                        .WithMany()
                        .HasForeignKey("fk_profile");
                });
#pragma warning restore 612, 618
        }
    }
}
