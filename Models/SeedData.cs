using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace HolaMundo.Models {
    public class SeedData {
        public static void Initialize (IServiceProvider serviceProvider) {
            using (var context = new HolaMundoContext (
                serviceProvider.GetRequiredService<DbContextOptions<HolaMundoContext>> ())) {
                //verificar si hay datos en la db
                if (context.Movie.Any ()) {
                    return; //db ha sido llenada
                }

                context.Movie.AddRange (
                    new Movie {
                        Title = "When Harry Met Sally",
                            ReleaseDate = DateTime.Parse ("1989-1-11"),
                            Genre = "Romantic Comedy",
                            Rating = "R",
                            Price = 7.99M
                    },
                    new Movie {
                        Title = "Ghostbusters",
                            ReleaseDate = DateTime.Parse ("1984-3-13"),
                            Genre = "Comedy",
                            Rating = "PG",
                            Price = 8.99M
                    },
                    new Movie {
                        Title = "Ghostbusters 2",
                            ReleaseDate = DateTime.Parse ("1986-2-23"),
                            Genre = "Comedy",
                            Rating = "PG",
                            Price = 9.99M
                    },
                    new Movie {
                        Title = "Rio Bravo",
                            ReleaseDate = DateTime.Parse ("1959-4-15"),
                            Genre = "Western",
                            Rating = "E",
                            Price = 3.99M
                    }
                );
                context.SaveChanges ();
            }
        }
    }
}