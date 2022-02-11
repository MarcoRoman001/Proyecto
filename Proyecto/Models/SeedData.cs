using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Proyecto.Data;
using System;
using System.Linq;

namespace Proyecto.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new ProyectoContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<ProyectoContext>>()))
            {
                // Look for any movies.
                if (context.Pelicula.Any())
                {
                    return;   // DB has been seeded
                }

                context.Pelicula.AddRange(
                    new Pelicula
                    {
                        Title = "Toy Strory",
                        ReleaseDate = DateTime.Parse("1995-11-22"),
                        Genre = "Animation",
                        Link1 = "https://cuevana.3.io/11518/toy-story",
                        Link2 = "https://www.clarovideo.com/mexico/vcard/home/toy-story/531750",
                        Link3 = "https://www.disneyplus.com/es-419/movies/toy-story/1Ye1nzUgtF7d",
                        trailer = "https://www.youtube.com/watch?v=VhCDgv4x_pU"
                    },

                    new Pelicula
                    {
                        Title = "Get Out",
                        ReleaseDate = DateTime.Parse("2017-2-24"),
                        Genre = "Terror",
                        Link1 = "https://cuevana3.io/1651/get-out",
                        Link2 = "https://www.filmaffinity.com/mx/film642856.html",
                        Link3 = "https://gnula.red/ver-get-out-online-espanol-latino/",
                        trailer = "https://www.youtube.com/watch?v=HOtVOxS7SjA"

                    },

                    new Pelicula
                    {
                        Title = "Slenderman",
                        ReleaseDate = DateTime.Parse("2018-8-10"),
                        Genre = "Terror",
                        Link1 = "https://cuevana3.io/1490/beware-the-slenderman",
                        Link2 = "https://www.netflix.com/mx-en/title/80221741",
                        Link3 = "https://www.justwatch.com/mx/pelicula/slender-man"
                    },

                    new Pelicula
                    {
                        Title = "Godzilla v Kong",
                        ReleaseDate = DateTime.Parse("2021-3-24"),
                        Genre = "Fiction",
                        Link1 = "https://cuevana3.io/40300/godzilla-vs-kong",
                        Link2 = "http://dl.mahanmovie.com/2021/film/04/godzilla%20vs%20kong/Godzilla.vs.Kong.2021.1080p.WEB-DL.RARBG.mahanmovie.mp4",
                        Link3 = "https://www.repelisplus.id/ver/godzilla-vs-kong/",
                        trailer = "https://youtu.be/EPdgdn5eOcw"
                    },
                    new Pelicula
                    {
                        Title = "Justice League Zack Snyder Cut",
                        ReleaseDate = DateTime.Parse("2021-3-18"),
                        Genre = "Fiction",
                        Link1 = "https://www.hbomax.com/mx/es/feature/urn:hbo:feature:GYDAnZgCFQ8IJpQEAAAAN?countryRedirect=1",
                        Link2 = "https://www.primevideo.com/detail/Zack-Snyders-Justice-League/0TVQFZG0Q8654KYCAU9936TNOI",
                        Link3 = "https://pelisplushd.net/titulo/justice-league-snyders-cut",
                        trailer = "https://youtu.be/oTXrl8H6luI"
                    }
                    );
                context.SaveChanges();
            }
        }
    }
}
