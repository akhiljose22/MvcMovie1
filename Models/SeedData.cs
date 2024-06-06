using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcMovie1.Data;
using MvcMovie1.Data;
using System;
using System.Linq;

namespace MvcMovie.Models;

public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new MvcMovie1Context(
            serviceProvider.GetRequiredService<
                DbContextOptions<MvcMovie1Context>>()))
        {
            // Look for any movies.
            if (context.Movie.Any())
            {
                return;   // DB has been seeded
            }
            context.Movie.AddRange(
                new Movie
                {
                    Title = "Inception",
                    ReleaseDate = DateTime.Parse("2010-6-16"),
                    Genre = "Science Fiction",
                    Rating = "R",
                    Price = 7.99M
                },
                new Movie
                {
                    Title = "Tedd",
                    ReleaseDate = DateTime.Parse("2012-6-29"),
                    Genre = "Comedy",
                    Rating = "R",
                    Price = 8.99M
                },
                new Movie
                {
                    Title = "Vampire Dairies",
                    ReleaseDate = DateTime.Parse("2009-8-10"),
                    Genre = "Drama",
                    Rating = "R",
                    Price = 9.99M
                },
                new Movie
                {
                    Title = "Safe Heaven",
                    ReleaseDate = DateTime.Parse("2013-2-14"),
                    Genre = "Romantic",
                    Rating = "R",
                    Price = 3.99M
                },
                new Movie
                {
                    Title = "Sherlock Holmes",
                    ReleaseDate = DateTime.Parse("2009-12-25"),
                    Genre = "Thriller",
                    Rating = "R",
                    Price = 3.99M
                }


            );
            context.SaveChanges();
        }
    }
}