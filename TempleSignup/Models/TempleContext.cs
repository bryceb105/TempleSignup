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
        public DbSet<Time> times { get; set; }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<Time>().HasData(

                new Time
                {
                    id = 1,
                    DateTime = "April 1st, 2022, 8:00AM",
                    Available = false
                    
                },
                                new Time
                                {
                                    id = 2,
                                    DateTime = "April 1st, 2022, 9:00AM",
                                    Available = false

                                },
                                new Time
                                {
                                    id = 3,
                                    DateTime = "April 1st, 2022, 10:00AM",
                                    Available = true

                                }, new Time
                                {
                                    id = 4,
                                    DateTime = "April 1st, 2022, 11:00AM",
                                    Available = true

                                }, new Time
                                {
                                    id = 5,
                                    DateTime = "April 1st, 2022, 12:00PM",
                                    Available = true

                                }, new Time
                                {
                                    id = 6,
                                    DateTime = "April 1st, 2022, 1:00PM",
                                    Available = true

                                }, new Time
                                {
                                    id = 7,
                                    DateTime = "April 1st, 2022, 2:00PM",
                                    Available = true

                                }, new Time
                                {
                                    id = 8,
                                    DateTime = "April 1st, 2022, 3:00PM",
                                    Available = true

                                }, new Time
                                {
                                    id = 9,
                                    DateTime = "April 1st, 2022, 4:00PM",
                                    Available = true

                                }, new Time
                                {
                                    id = 10,
                                    DateTime = "April 1st, 2022, 5:00PM",
                                    Available = true

                                }, new Time
                                {
                                    id = 11,
                                    DateTime = "April 1st, 2022, 6:00PM",
                                    Available = true

                                }, new Time
                                {
                                    id = 12,
                                    DateTime = "April 1st, 2022, 7:00PM",
                                    Available = true

                                }, new Time
                                {
                                    id = 13,
                                    DateTime = "April 1st, 2022, 8:00PM",
                                    Available = true

                                }


                );




            mb.Entity<TempleModel>().HasData(
                new TempleModel
                {
                    id = 1,
                    Name = "Smiths",
                    TimeId = 1,
                    GroupSize = 4,
                    Email = "colesmith@email.com",
                    Phone = "775-222-111"
                },
                new TempleModel
                {
                    id = 2,
                    Name = "Youth Group",
                    TimeId = 2,
                    GroupSize = 12,
                    Email = "youth@email.com"
                }

                );
        }
    }
}
