// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TempleSignup.Models;

namespace TempleSignup.Migrations
{
    [DbContext(typeof(TempleContext))]
    [Migration("20220324055532_times")]
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

                    b.Property<string>("DateTime")
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasColumnType("TEXT");

                    b.Property<int>("GroupSize")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("Phone")
                        .HasColumnType("TEXT");

                    b.HasKey("id");

                    b.ToTable("responses");

                    b.HasData(
                        new
                        {
                            id = 1,
                            DateTime = "April 1st, 2022, 8:00am",
                            Email = "colesmith@email.com",
                            GroupSize = 4,
                            Name = "Smiths",
                            Phone = "775-222-111"
                        },
                        new
                        {
                            id = 9,
                            DateTime = "April 1st, 2022, 3:00pm",
                            Email = "youth@email.com",
                            GroupSize = 12,
                            Name = "Youth Group"
                        },
                        new
                        {
                            id = 3,
                            DateTime = "April 1st, 2022, 9:00am",
                            GroupSize = 0
                        },
                        new
                        {
                            id = 4,
                            DateTime = "April 1st, 2022, 10:00am",
                            GroupSize = 0
                        },
                        new
                        {
                            id = 5,
                            DateTime = "April 1st, 2022, 11:00am",
                            GroupSize = 0
                        },
                        new
                        {
                            id = 6,
                            DateTime = "April 1st, 2022, 12:00pm",
                            GroupSize = 0
                        },
                        new
                        {
                            id = 7,
                            DateTime = "April 1st, 2022, 1:00pm",
                            GroupSize = 0
                        },
                        new
                        {
                            id = 8,
                            DateTime = "April 1st, 2022, 2:00pm",
                            GroupSize = 0
                        },
                        new
                        {
                            id = 10,
                            DateTime = "April 1st, 2022, 4:00pm",
                            GroupSize = 0
                        },
                        new
                        {
                            id = 11,
                            DateTime = "April 1st, 2022, 5:00pm",
                            GroupSize = 0
                        },
                        new
                        {
                            id = 12,
                            DateTime = "April 1st, 2022, 6:00pm",
                            GroupSize = 0
                        },
                        new
                        {
                            id = 13,
                            DateTime = "April 1st, 2022, 7:00pm",
                            GroupSize = 0
                        },
                        new
                        {
                            id = 14,
                            DateTime = "April 1st, 2022, 8:00pm",
                            GroupSize = 0
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
