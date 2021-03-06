using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using RazorPagesTurtle4.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RazorPagesTurtle4.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new RazorPagesTurtle4Context(
                serviceProvider.GetRequiredService<
                    DbContextOptions<RazorPagesTurtle4Context>>()))
            {
                // Look for any turtles.
                if (context.Turtle.Any())
                {
                    return;   // DB has been seeded
                }

                context.Turtle.AddRange(
                    new Turtle
                    {
                        TurtleName = "FlubbaDubba",
                        ReleaseDate = DateTime.Parse("1949-8-24"),
                        Type = "Tortoise",
                        Price = 232.00M,
                        Rating = "T2"
                    },

                    new Turtle
                    {
                        TurtleName = "Chimichanga",
                        ReleaseDate = DateTime.Parse("2015-12-24"),
                        Type = "Sea Turtle",
                        Price = 125.50M,
                        Rating = "T2"
                    },

                    new Turtle
                    {
                        TurtleName = "Swim",
                        ReleaseDate = DateTime.Parse("2018-11-27"),
                        Type = "Sea Turtle",
                        Price = 58.98M,
                        Rating = "T2"
                    },

                    new Turtle
                    {
                        TurtleName = "Boxer",
                        ReleaseDate = DateTime.Parse("2020-1-1"),
                        Type = "Western Box Turtle",
                        Price = 15.00M,
                        Rating = "T2"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
