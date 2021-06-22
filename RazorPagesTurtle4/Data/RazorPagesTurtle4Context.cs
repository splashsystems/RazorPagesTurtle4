using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RazorPagesTurtle4.Models;

namespace RazorPagesTurtle4.Data
{
    public class RazorPagesTurtle4Context : DbContext
    {
        public RazorPagesTurtle4Context (DbContextOptions<RazorPagesTurtle4Context> options)
            : base(options)
        {
        }

        public DbSet<RazorPagesTurtle4.Models.Turtle> Turtle { get; set; }
    }
}
