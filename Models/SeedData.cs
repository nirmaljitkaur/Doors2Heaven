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
                    Types_of_Door = "Traditional Wooden Panel Door",
                    Style_of_Door = "Classic and timeless design with raised panels",
                    Features = "Solid wood construction, intricate detailing, various finish options",
                    Price = 56.99M,
                    Material = "Solid hardwood like oak, mahogany, or cherry",
                    Ratings = "4.5"
                },
                new Doors
                {
                    Types_of_Door = "Modern Glass Pivot Door",
                    Style_of_Door = "Sleek and contemporary, featuring a pivoting mechanism",
                    Features = "Large glass panels, minimalistic metal frame, pivot hinge for smooth operation",
                    Price = 60.99M,
                    Material = "Tempered glass, aluminum or steel frame",
                    Ratings = "4"
                },
                new Doors
                {
                    Types_of_Door = "French Patio Door",
                    Style_of_Door = "Elegant and inviting with multiple glass panes and a wide frame",
                    Features = "Double doors that open outward, allowing ample natural light",
                    Price = 65.99M,
                    Material = "Wooden or fiberglass frame, double-pane insulated glass",
                    Ratings = "4.2"
                },
                new Doors
                {
                    Types_of_Door = "Sliding Barn Door",
                    Style_of_Door = "Rustic and trendy, sliding horizontally on a track",
                    Features = "Reclaimed wood, exposed hardware, space-saving",
                    Price = 63.99M,
                    Material = "Reclaimed barn wood, metal track and rollers",
                    Ratings = "4.3"
                },
                new Doors
                {
                    Types_of_Door = "Fiberglass Entry Door with Sidelights",
                    Style_of_Door = "Versatile, mimicking the look of wood but with added durability",
                    Features = "Sidelights for additional natural light, energy-efficient core",
                    Price = 79.99M,
                    Material = "Fiberglass with a textured wood grain finish, double-pane glass sidelights",
                    Ratings = "4.7"
                },
                new Doors
                {
                    Types_of_Door = "Pocket Doors",
                    Style_of_Door = "Space-saving and contemporary, sliding into the wall",
                    Features = "Concealed when open, smooth sliding mechanism",
                    Price = 59.99M,
                    Material = "Wooden or metal frame, variety of panel options",
                    Ratings = "4.6"
                },
                new Doors
                {
                    Types_of_Door = "Dutch Door",
                    Style_of_Door = "Charming and traditional, divided horizontally to allow for separate operation",
                    Features = "Upper and lower halves can be opened independently, ideal for ventilation",
                    Price = 49.99M,
                    Material = "Solid wood or fiberglass",
                    Ratings = "4.4"
                },
                new Doors
                {
                    Types_of_Door = "Steel Security Door",
                    Style_of_Door = "Industrial and secure, often with decorative patterns",
                    Features = "Reinforced steel construction, multiple locking points, weather-resistant",
                    Price = 89.99M,
                    Material = "Heavy-duty steel with a protective finish",
                    Ratings = "4.8"
                },
                new Doors
                {
                    Types_of_Door = "Accordion Folding Door",
                    Style_of_Door = "Flexible and space-efficient, accordion-like folding panels",
                    Features = "Concertina-style folding, suitable for large openings",
                    Price = 44.99M,
                    Material = "Vinyl or hardwood panels connected by flexible hinges",
                    Ratings = "4.2"
                },
                new Doors
                {
                    Types_of_Door = "Bifold Glass Patio Door",
                    Style_of_Door = "Contemporary and open, with multiple folding glass panels",
                    Features = "Wide opening, seamless transition between indoor and outdoor spaces.",
                    Price = 54.99M,
                    Material = "Aluminum or wooden frame, high-quality tempered glass",
                    Ratings = "4.5"
                }
            );
            context.SaveChanges();
        }
    }
}
