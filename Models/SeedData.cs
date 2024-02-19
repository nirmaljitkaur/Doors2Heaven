using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Doors2Heaven.Data;
using System;
using System.Linq;

namespace Doors2Heaven.Models;

public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new Doors2HeavenContext(
             serviceProvider.GetRequiredService<
                 DbContextOptions<Doors2HeavenContext>>()))
        {
            // Look for any movies.
            if (context.Doors.Any())
            {
                return;   // DB has been seeded
            }
            context.Doors.AddRange(
                new Doors
                {
                    Types_of_Door = "First Type of Door",
                    Style_of_Door = "First Style of Door",
                    Features = "First Features of Door",
                    Price = 1.99M,
                    Material = "First Material of Door",
                    Ratings = "First Rating of Door"
                },
                new Doors
                {
                    Types_of_Door = "Second Type of Door",
                    Style_of_Door = "Second Style of Door",
                    Features = "Second Features of Door",
                    Price = 2.99M,
                    Material = "second Material of Door",
                    Ratings = "Second Rating of Door"
                },
                new Doors
                {
                    Types_of_Door = "Third Type of Door",
                    Style_of_Door = "Third Style of Door",
                    Features = "Third Features of Door",
                    Price = 3.99M,
                    Material = "Third Material of Door",
                    Ratings = "Third Rating of Door"
                },
                new Doors
                {
                    Types_of_Door = "Fourth Type of Door",
                    Style_of_Door = "Fourth Style of Door",
                    Features = "Fourth Features of Door",
                    Price = 4.99M,
                    Material = "Fourth Material of Door",
                    Ratings = "Fourth Rating of Door"
                },
                new Doors
                {
                    Types_of_Door = "Fifth Type of Door",
                    Style_of_Door = "Fifth Style of Door",
                    Features = "Fifth Features of Door",
                    Price = 5.99M,
                    Material = "Fifth Material of Door",
                    Ratings = "Fifth Rating of Door"
                }
            );
            context.SaveChanges();
        }
    }
}
