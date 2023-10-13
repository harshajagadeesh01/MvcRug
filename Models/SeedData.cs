using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcRug.Data;
using System;
using System.Linq;

namespace MvcRug.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MvcRugContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MvcRugContext>>()))
            {
                // Look for any movies.
                if (context.Movie.Any())
                {
                    return;   // DB has been seeded
                }

                context.Movie.AddRange(
                    new Movie
                    {
                        Title = "Animal Print Rugs",
                        ManufactureDate = DateTime.Parse("2015-2-12"),
                        Type = "Hand Knotted",
                        Price = 12.99M
                    },

                    new Movie
                    {
                        Title = "Border Rugs",
                        ManufactureDate = DateTime.Parse("2020-3-13"),
                        Type = "Hand Woven",
                        Price = 15.99M
                    },

                    new Movie
                    {
                        Title = "Oriental Rugs",
                        ManufactureDate = DateTime.Parse("2021-2-23"),
                        Type = "Machine Made",
                        Price = 19.99M
                    },
                    new Movie
                    {
                        Title = "Coastal Rugs",
                        ManufactureDate = DateTime.Parse("2022-2-23"),
                        Type = "White Knot",
                        Price = 19.99M
                    },
                    new Movie
                    {
                        Title = "Distressed Rugs",
                        ManufactureDate = DateTime.Parse("2014-2-23"),
                        Type = "Dye Bleeding",
                        Price =20.99M
                    },
                    new Movie
                    {
                        Title = "Floral Rugs",
                        ManufactureDate = DateTime.Parse("2016-2-23"),
                        Type = "Machine Made",
                        Price = 15.99M
                    },
                    new Movie
                    {
                        Title = "Geometric Rugs",
                        ManufactureDate = DateTime.Parse("2017-2-23"),
                        Type = "Hand Woven",
                        Price = 15.99M
                    },
                    new Movie
                    {
                        Title = "High-Low Rugs",
                        ManufactureDate = DateTime.Parse("2018-2-23"),
                        Type = "Hand Woven",
                        Price = 15.99M
                    },
                    new Movie
                    {
                        Title = "Ikat Rugs",
                        ManufactureDate = DateTime.Parse("2019-2-23"),
                        Type = "Hand Knotted",
                        Price = 18.99M
                    },

                    new Movie
                    {
                        Title = "Cottage Rugs",
                        ManufactureDate = DateTime.Parse("2017-4-15"),
                        Type = "Hand Knotted",
                        Price = 19.99M
                    }
                );
                context.SaveChanges();
            }
        }
    }
}