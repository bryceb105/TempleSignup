using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TempleSignup.Models
{
    public class TempleContext : DbContext
    {
        public TempleContext (DbContextOptions<TempleContext> options) : base(options)
        {

        }

        public DbSet<TempleModel> responses { get; set; }

        protected override void OnModelCreating(ModelBuilder mb)
        {



            mb.Entity<TempleModel>().HasData(
                new TempleModel
                {
                    id = 1,
                    Name = "Smiths",
                    DateTime = "April 1st, 2022, 8:00am",
                    GroupSize = 4,
                    Email = "colesmith@email.com",
                    Phone = "775-222-111"
                },
                new TempleModel
                {
                    id = 9,
                    Name = "Youth Group",
                    DateTime = "April 1st, 2022, 3:00pm",
                    GroupSize = 12,
                    Email = "youth@email.com"
                },
                new TempleModel
                {
                    id = 3,
                    DateTime = "April 1st, 2022, 9:00am",
                },
                new TempleModel
                {
                    id = 4,
                    DateTime = "April 1st, 2022, 10:00am",
                },
                new TempleModel
                {
                    id = 5,
                    DateTime = "April 1st, 2022, 11:00am",
                },
                new TempleModel
                {
                    id = 6,
                    DateTime = "April 1st, 2022, 12:00pm",
                },
                new TempleModel
                {
                    id = 7,
                    DateTime = "April 1st, 2022, 1:00pm",
                },
                new TempleModel
                {
                    id = 8,
                    DateTime = "April 1st, 2022, 2:00pm",
                },
                new TempleModel
                {
                    id = 10,
                    DateTime = "April 1st, 2022, 4:00pm",
                },
                new TempleModel
                {
                    id = 11,
                    DateTime = "April 1st, 2022, 5:00pm",
                },
                new TempleModel
                {
                    id = 12,
                    DateTime = "April 1st, 2022, 6:00pm",
                },
                new TempleModel
                {
                    id = 13,
                    DateTime = "April 1st, 2022, 7:00pm",
                },
                new TempleModel
                {
                    id = 14,
                    DateTime = "April 1st, 2022, 8:00pm",
                }




                );
        }
    }
}
