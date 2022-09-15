using ustaTickets.Data.Enum;
using ustaTickets.Models;

namespace ustaTickets.Data
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<ApplicationDbContext>();
                context.Database.EnsureCreated();

                //Cinema
                if (!context.Cinema.Any())
                {
                    context.Cinema.AddRange(new List<Cinema>()
                    {
                    new Cinema()
                    {
                        Name = "Paramount Picture",
                        Logo = "http://localhost/img/Cinemas/Paramount.jpg",
                        Description ="Paramount Pictures Corporation es una compañía productora y distribuidora de cine, con sede en Hollywood. Es propiedad de Paramount Global y anteriormente de Gulf+Western. Fue fundada el 8 de mayo de 1912."
                    },
                    new Cinema()
                    {
                        Name = "HBO",
                        Logo = "http://localhost/img/Cinemas/HBO.jpg",
                        Description ="HBO es una cadena de televisión por suscripción estadounidense, propiedad de Warner Bros. Discovery a través de su división WarnerMedia Studios & Networks."
                    },
                    new Cinema()
                    {
                    Name = "20 Century Fox",
                    Logo = "http://localhost/img/Cinemas/20fox.webp",
                    Description = "20th Century Studios, Inc. es un estudio de cine estadounidense filial de Walt Disney Studios, una división de The Walt Disney Company.​ El estudio está ubicado en los Fox Studios en el área de Century City en Los Ángeles."
                    },
                    new Cinema()
                    {
                    Name = "Universal",
                    Logo = "http://localhost/img/cinemas/UniversalPictures.webp",
                    Description = "Universal Pictures, a efectos legales Universal City Studios LLC​, es un estudio cinematográfico estadounidense, propiedad de Comcast Corporation a través de su propia dependencia NBCUniversa"
                    }
                    });
                    context.SaveChanges();
                }

                //Actor
                if (!context.Actor.Any())
                {
                    context.Actor.AddRange(new List<Actor>()
                        {
                        new Actor()
                        {
                        Fullname = "La Roca",
                        Bio = "dqw",
                        ProfilePictuaeURL="http://localhost/img/actors/LaRoca2.jpg"
                        },
                        new Actor()
                        {
                        Fullname = "Ryan Reynolds",
                        Bio = "dwqdq",
                        ProfilePictuaeURL="http://localhost/img/actors/Ryan_Reynolds.webp"
                        },
                        new Actor()
                        {
                        Fullname = "Chris Pratt",
                        Bio = "ssssssssa",
                        ProfilePictuaeURL="http://localhost/img/actors/chrisPratt.jpg"
                        },
                        new Actor()
                        {
                        Fullname = "Tom Cruise",
                        Bio = "dwqdqs",
                        ProfilePictuaeURL="http://localhost/img/actors/tomCruise.jpg"
                        },
                        new Actor()
                        {
                        Fullname = "Vin Disel",
                        Bio = "dqwdassd",
                        ProfilePictuaeURL="http://localhost/img/actors/vinDiese.webp"
                        },
                        new Actor()
                        {
                        Fullname = "Morena Baccarin",
                        Bio = "",
                        ProfilePictuaeURL="http://localhost/img/actors/Morenabaccarin.jpg"
                        },
                        new Actor()
                        {
                        Fullname = "Stan Lee",
                        Bio = "dqdsasd",
                        ProfilePictuaeURL="http://localhost/img/actors/StanLee.jpg"
                        },
                        new Actor()
                        {
                        Fullname = "Michelle Rodriguez",
                        Bio = "wqdsad",
                        ProfilePictuaeURL="http://localhost/img/actors/MichelleRodriguez.jpg"
                        },
                        new Actor()
                        {
                        Fullname = "Jordana Brewster",
                        Bio = "dasdqwc",
                        ProfilePictuaeURL="http://localhost/img/actors/JordanaBrewster.webp"
                        },
                        new Actor()
                        {
                        Fullname = "Jason Statham",
                        Bio = "dasdqasdawc",
                        ProfilePictuaeURL="http://localhost/img/actors/JasonStatham.jpg"
                        },
                        new Actor()
                        {
                        Fullname = "Idris Elba",
                        Bio = "dasdqswqddawc",
                        ProfilePictuaeURL="http://localhost/img/actors/IdrisElba.webp"
                        },
                        new Actor()
                        {
                        Fullname = "Emily Blunt",
                        Bio = "dasdqswqddawc",
                        ProfilePictuaeURL="http://localhost/img/actors/EmilyBlunt.jpg"
                        },
                        }
                        );
                    context.SaveChanges();
                }

                //Director
                if (!context.Director.Any())
                {
                    context.Director.AddRange(new List<Director>()
                    {
                        new Director()
                        {
                        Fullname = "David Leitchyhe",
                        Bio = "cqasc  ",
                        ProfilePictuaeURL="http://localhost/img/directors/DavidLeitchyheR.jpg"
                        },
                        new Director()
                        {
                        Fullname = "Justin Lin",
                        Bio = "wecev",
                        ProfilePictuaeURL="http://localhost/img/directors/Justin_Lin.webp"
                        },
                        new Director()
                        {
                        Fullname = "Tim Miller",
                        Bio = "hrtgerf",
                        ProfilePictuaeURL="http://localhost/img/directors/Tim_MillerD.webp"
                        },
                        new Director()
                        {
                        Fullname = "Colin Trevorro",
                        Bio = "dqwdqcds",
                        ProfilePictuaeURL="http://localhost/img/directors/colinTrevorroJ.jpg"
                        },
                        new Director()
                        {
                        Fullname = "Joseph",
                        Bio = "dqwdq",
                        ProfilePictuaeURL="http://localhost/img/directors/josephK.webp"
                        },
                        new Director()
                        {
                        Fullname = "Doug Liman",
                        Bio = "dqwdq",
                        ProfilePictuaeURL="http://localhost/img/actors/Doug%20Liman.jpg"
                        },
                    });
                    context.SaveChanges();
                }

                //Movie
                if (!context.Movie.Any())
                {
                    context.Movie.AddRange(new List<Movie>()
                    {
                    new Movie()
                    {
                    Name = "Deadpool",
                    Description = "Un exmercenario quien, tras haber sido sometido a un cruel experimento, adquiere el superpoder de sanar rápidamente y pretende vengarse del hombre que destrozó su vida.",
                    Price = 10000.0,
                    ImageURL = "http://localhost/img/movies/Deadpool.jpg",
                    StartTime = DateTime.Now.AddDays(-10),
                    EndTime = DateTime.Now.AddDays(-2),
                    CinemaId = 3,
                    DirectorId = 3,
                    MovieCategory = MovieCategory.Action
                    },
                    new Movie()
                    {
                    Name = "Rapidos y Furiosos 9",
                    Description = "Dom Toretto vive una vida tranquila junto a Letty y su hijo, pero el peligro siempre regresa a su vida. En esta ocasió",
                    Price = 10000.0,
                    ImageURL = "http://localhost/img/movies/F9-Poster.webp",
                    StartTime = DateTime.Now.AddDays(-10),
                    EndTime = DateTime.Now.AddDays(-2),
                    CinemaId = 2,
                    DirectorId = 2,
                    MovieCategory = MovieCategory.Action
                    },
                    new Movie()
                    {
                    Name = "Hobbs & Shaw",
                    Description = "El policía Luke Hobbs se une al mercenario Deckard Shaw para luchar contra un terrorista que posee una fuerza sobrenatural, una mente brillante y un patógeno letal que podría aniquilar a la mitad de la población mundial.",
                    Price = 100000.0,
                    ImageURL = "http://localhost/img/movies/Hobbs&shaw.jpg",
                    StartTime = DateTime.Now.AddDays(-10),
                    EndTime = DateTime.Now.AddDays(-2),
                    CinemaId = 4,
                    DirectorId = 1,
                    MovieCategory = MovieCategory.Action
                    },
                    new Movie()
                    {
                    Name = "Al Filo del Mañana",
                    Description = "William Cage, un soldado muerto en acción mientras combatía contra unos alienígenas que invadieron la Tierra, entra en un bucle temporal en el cual revive constantemente y vuelve a intentar salvar el planeta, mejorando sus habilidades, conociendo mejor al enemigo, y acercándose cada vez más a la victoria. Sin embargo, el tiempo corre en su contra.",
                    Price = 100000.0,
                    ImageURL = "http://localhost/img/movies/alfinlodelma%c3%b1ana.jpg",
                    StartTime = DateTime.Now.AddDays(-10),
                    EndTime = DateTime.Now.AddDays(-2),
                    CinemaId = 3,
                    DirectorId = 6,
                    MovieCategory = MovieCategory.Action
                    },
                    new Movie()
                    {
                    Name = "Jurassic Word",
                    Description = "Una nueva especie de dinosaurio, creada por los científicos de forma artificial, es más inteligente y peligrosa que los animales conocidos y termina por atacar a los turistas que visitan el parque temático Jurassic World, situado en una isla frente a Costa Rica.",
                    Price = 20000.0,
                    ImageURL = "http://localhost/img/movies/jurassicW.jpg",
                    StartTime = DateTime.Now.AddDays(-10),
                    EndTime = DateTime.Now.AddDays(-2),
                    CinemaId = 2,
                    DirectorId = 4,
                    MovieCategory = MovieCategory.Action
                    },
                    new Movie()
                    {
                    Name = "La ley tiene limites",
                    Description = "scndslñncccan{lknadvlnavlknadjvankvjasndvlnalsdkvn",
                    Price = 123130.0,
                    ImageURL = "http://localhost/img/movies/laleytienelimites.jpg",
                    StartTime = DateTime.Now.AddDays(-10),
                    EndTime = DateTime.Now.AddDays(-2),
                    CinemaId = 2,
                    DirectorId = 1,
                    MovieCategory = MovieCategory.Action
                    },
                    new Movie()
                    {
                    Name = "La momia",
                    Description = "Ahmanet, una antigua y maldita princesa egipcia, despierta furiosa y siembra el terror entre los humanos; solo un intrépido mercenario podrá detenerla y evitar que su ira destruya Londres.",
                    Price = 133243540.0,
                    ImageURL = "http://localhost/img/movies/lamomia.jpg",
                    StartTime = DateTime.Now.AddDays(-10),
                    EndTime = DateTime.Now.AddDays(-2),
                    CinemaId = 1,
                    DirectorId = 1,
                    MovieCategory = MovieCategory.Action
                    },
                    new Movie()
                    {
                    Name = "Mision imposible",
                    Description = "Misión: Imposible es una serie de películas de acción estadounidense basada en la serie televisiva del mismo nombre. La serie es coproducida y protagonizada por Tom Cruise como Ethan Hunt, ",
                    Price = 1342530.0,
                    ImageURL = "http://localhost/img/movies/misionimposible.webp",
                    StartTime = DateTime.Now.AddDays(-10),
                    EndTime = DateTime.Now.AddDays(-2),
                    CinemaId = 4,
                    DirectorId = 4,
                    MovieCategory = MovieCategory.Action
                    },
                    new Movie()
                    {
                    Name = "Oblivion: el timpo del olvido",
                    Description = "Jack Harper y Victoria Olsen son los únicos habitantes de la Tierra, destruida hace sesenta años. Harper, un mecánico de aviación, rescata a una mujer antes de abandonar la Tierra para siempre e inicia una batalla para salvar a la humanidad.",
                    Price = 564540.0,
                    ImageURL = "http://localhost/img/movies/oblivion.webp",
                    StartTime = DateTime.Now.AddDays(-10),
                    EndTime = DateTime.Now.AddDays(-2),
                    CinemaId = 4,
                    DirectorId = 2,
                    MovieCategory = MovieCategory.Action
                    },
                    new Movie()
                    {
                    Name = "Top Gun",
                    Description = "Maverick, quien lleva 30 años de servicio, es ahora instructor de pilotos militares. Una última misión, un sacrificio final, obliga a este maestro de los cielos a enfrentar las heridas abiertas del pasado y sus temores más profundos.",
                    Price = 124324340.0,
                    ImageURL = "http://localhost/img/movies/topGun.jpg",
                    StartTime = DateTime.Now.AddDays(-10),
                    EndTime = DateTime.Now.AddDays(-2),
                    CinemaId = 2,
                    DirectorId = 3,
                    MovieCategory = MovieCategory.Action
                    },
                    }
                    );
                    context.SaveChanges();
                }


                //Actor_Movie
                if (context.Actor_Movie.Any())
                {
                    context.Actor_Movie.AddRange(new List<Actor_Movie>
                    {
                    new Actor_Movie()
                    {
                        ActorId=1,
                        MovieId= 1
                    }
                    });
                    context.SaveChanges();
                }


            }
        }
    }
}
