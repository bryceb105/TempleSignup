﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TempleSignup.Models;

namespace TempleSignup.Migrations
{
    [DbContext(typeof(TempleContext))]
    [Migration("20220323215500_times")]
    partial class times
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.23");

            modelBuilder.Entity("TempleSignup.Models.TempleModel", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("GroupSize")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Phone")
                        .HasColumnType("TEXT");

                    b.Property<int>("TimeId")
                        .HasColumnType("INTEGER");

                    b.HasKey("id");

                    b.HasIndex("TimeId");

                    b.ToTable("responses");

                    b.HasData(
                        new
                        {
                            id = 1,
                            Email = "colesmith@email.com",
                            GroupSize = 4,
                            Name = "Smiths",
                            Phone = "775-222-111",
                            TimeId = 1
                        },
                        new
                        {
                            id = 2,
                            Email = "youth@email.com",
                            GroupSize = 12,
                            Name = "Youth Group",
                            TimeId = 2
                        });
                });

            modelBuilder.Entity("TempleSignup.Models.Time", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Available")
                        .HasColumnType("INTEGER");

                    b.Property<string>("DateTime")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("id");

                    b.ToTable("times");

                    b.HasData(
                        new
                        {
                            id = 1,
                            Available = false,
                            DateTime = "April 1st, 2022, 8:00AM"
                        },
                        new
                        {
                            id = 2,
                            Available = false,
                            DateTime = "April 1st, 2022, 9:00AM"
                        },
                        new
                        {
                            id = 3,
                            Available = true,
                            DateTime = "April 1st, 2022, 10:00AM"
                        },
                        new
                        {
                            id = 4,
                            Available = true,
                            DateTime = "April 1st, 2022, 11:00AM"
                        },
                        new
                        {
                            id = 5,
                            Available = true,
                            DateTime = "April 1st, 2022, 12:00PM"
                        },
                        new
                        {
                            id = 6,
                            Available = true,
                            DateTime = "April 1st, 2022, 1:00PM"
                        },
                        new
                        {
                            id = 7,
                            Available = true,
                            DateTime = "April 1st, 2022, 2:00PM"
                        },
                        new
                        {
                            id = 8,
                            Available = true,
                            DateTime = "April 1st, 2022, 3:00PM"
                        },
                        new
                        {
                            id = 9,
                            Available = true,
                            DateTime = "April 1st, 2022, 4:00PM"
                        },
                        new
                        {
                            id = 10,
                            Available = true,
                            DateTime = "April 1st, 2022, 5:00PM"
                        },
                        new
                        {
                            id = 11,
                            Available = true,
                            DateTime = "April 1st, 2022, 6:00PM"
                        },
                        new
                        {
                            id = 12,
                            Available = true,
                            DateTime = "April 1st, 2022, 7:00PM"
                        },
                        new
                        {
                            id = 13,
                            Available = true,
                            DateTime = "April 1st, 2022, 8:00PM"
                        });
                });

            modelBuilder.Entity("TempleSignup.Models.TempleModel", b =>
                {
                    b.HasOne("TempleSignup.Models.Time", "Time")
                        .WithMany()
                        .HasForeignKey("TimeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}