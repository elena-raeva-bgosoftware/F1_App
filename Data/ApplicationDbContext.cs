using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using F1_App.Data.Models;

namespace F1_App.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Driver> Drivers { get; set; }
        public DbSet<Track> Tracks { get; set; }
        public DbSet<RaceResult> RaceResults { get; set; }
        public DbSet<UpcomingRace> UpcomingRaces { get; set; }
        public DbSet<F1History> F1Histories { get; set; }
        //Test commit
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Сийдване на начални данни за пилотите за сезон 2024
            modelBuilder.Entity<Driver>().HasData(
                new Driver
                {
                    Id = 1,
                    DriverNumber = 1,
                    Name = "Max Verstappen",
                    Nationality = "Netherlands",
                    BirthDate = new DateTime(1997, 9, 30),
                    Team = "Red Bull Racing",
                    PhotoUrl = "https://cdn-3.motorsport.com/images/mgl/6D1XbeV0/s800/max-verstappen-red-bull-racing.jpg"
                },
                new Driver
                {
                    Id = 2,
                    DriverNumber = 11,
                    Name = "Sergio Perez",
                    Nationality = "Mexico",
                    BirthDate = new DateTime(1990, 1, 26),
                    Team = "Red Bull Racing",
                    PhotoUrl = "https://cdn-3.motorsport.com/images/mgl/2y3qRdo6/s8/sergio-perez-red-bull-racing.jpg"
                },
                new Driver
                {
                    Id = 3,
                    DriverNumber = 16,
                    Name = "Charles Leclerc",
                    Nationality = "Monaco",
                    BirthDate = new DateTime(1997, 10, 16),
                    Team = "Scuderia Ferrari",
                    PhotoUrl = "https://media.formula1.com/image/upload/v1712849104/content/dam/fom-website/drivers/2024Drivers/leclerc.png"
                },
                new Driver
                {
                    Id = 4,
                    DriverNumber = 55,
                    Name = "Carlos Sainz",
                    Nationality = "Spain",
                    BirthDate = new DateTime(1994, 9, 1),
                    Team = "Scuderia Ferrari",
                    PhotoUrl = "https://media.formula1.com/image/upload/f_auto,c_limit,q_75,w_1320/content/dam/fom-website/drivers/2024Drivers/sainz"
                },
                new Driver
                {
                    Id = 5,
                    DriverNumber = 44,
                    Name = "Lewis Hamilton",
                    Nationality = "United Kingdom",
                    BirthDate = new DateTime(1985, 1, 7),
                    Team = "Mercedes-AMG Petronas F1 Team",
                    PhotoUrl = "https://media.formula1.com/image/upload/f_auto,c_limit,q_75,w_1320/content/dam/fom-website/drivers/2024Drivers/hamilton"
                },
                new Driver
                {
                    Id = 6,
                    DriverNumber = 63,
                    Name = "George Russell",
                    Nationality = "United Kingdom",
                    BirthDate = new DateTime(1998, 2, 15),
                    Team = "Mercedes-AMG Petronas F1 Team",
                    PhotoUrl = "https://media.formula1.com/image/upload/f_auto,c_limit,q_75,w_1320/content/dam/fom-website/drivers/2024Drivers/russell"
                },
                new Driver
                {
                    Id = 7,
                    DriverNumber = 4,
                    Name = "Lando Norris",
                    Nationality = "United Kingdom",
                    BirthDate = new DateTime(1999, 11, 13),
                    Team = "McLaren",
                    PhotoUrl = "https://media.formula1.com/image/upload/f_auto,c_limit,q_75,w_1320/content/dam/fom-website/drivers/2024Drivers/norris"
                },
                new Driver
                {
                    Id = 8,
                    DriverNumber = 81,
                    Name = "Oscar Piastri",
                    Nationality = "Australia",
                    BirthDate = new DateTime(2001, 4, 6),
                    Team = "McLaren",
                    PhotoUrl = "https://media.formula1.com/image/upload/f_auto,c_limit,q_75,w_1320/content/dam/fom-website/drivers/2024Drivers/piastri"
                },
                new Driver
                {
                    Id = 9,
                    DriverNumber = 31,
                    Name = "Esteban Ocon",
                    Nationality = "France",
                    BirthDate = new DateTime(1996, 9, 17),
                    Team = "Alpine",
                    PhotoUrl = "https://media.formula1.com/image/upload/v1712849107/content/dam/fom-website/drivers/2024Drivers/ocon.png"
                },
                new Driver
                {
                    Id = 10,
                    DriverNumber = 10,
                    Name = "Pierre Gasly",
                    Nationality = "France",
                    BirthDate = new DateTime(1996, 2, 7),
                    Team = "Alpine",
                    PhotoUrl = "https://media.formula1.com/image/upload/f_auto,c_limit,q_75,w_1320/content/dam/fom-website/drivers/2024Drivers/gasly"
                },
                new Driver
                {
                    Id = 11,
                    DriverNumber = 14,
                    Name = "Fernando Alonso",
                    Nationality = "Spain",
                    BirthDate = new DateTime(1981, 7, 29),
                    Team = "Aston Martin",
                    PhotoUrl = "https://media.formula1.com/image/upload/f_auto,c_limit,q_75,w_1320/content/dam/fom-website/drivers/2024Drivers/alonso"
                },
                new Driver
                {
                    Id = 12,
                    DriverNumber = 18,
                    Name = "Lance Stroll",
                    Nationality = "Canada",
                    BirthDate = new DateTime(1998, 10, 29),
                    Team = "Aston Martin",
                    PhotoUrl = "https://media.formula1.com/image/upload/f_auto,c_limit,q_auto,w_1320/content/dam/fom-website/drivers/2024Drivers/stroll"
                },
                new Driver
                {
                    Id = 13,
                    DriverNumber = 77,
                    Name = "Valtteri Bottas",
                    Nationality = "Finland",
                    BirthDate = new DateTime(1989, 8, 28),
                    Team = "Kick Sauber-Ferrari",
                    PhotoUrl = "https://media.formula1.com/image/upload/v1712849101/content/dam/fom-website/drivers/2024Drivers/bottas.png"
                },
                new Driver
                {
                    Id = 14,
                    DriverNumber = 24,
                    Name = "Zhou Guanyu",
                    Nationality = "China",
                    BirthDate = new DateTime(1999, 5, 30),
                    Team = "Kick Sauber-Ferrari",
                    PhotoUrl = "https://media.formula1.com/image/upload/f_auto,c_limit,q_75,w_1320/content/dam/fom-website/drivers/2024Drivers/zhou"
                },
                new Driver
                {
                    Id = 15,
                    DriverNumber = 20,
                    Name = "Kevin Magnussen",
                    Nationality = "Denmark",
                    BirthDate = new DateTime(1992, 10, 5),
                    Team = "Haas",
                    PhotoUrl = "https://media.formula1.com/image/upload/f_auto,c_limit,q_75,w_1320/content/dam/fom-website/drivers/2024Drivers/magnussen"
                },
                new Driver
                {
                    Id = 16,
                    DriverNumber = 27,
                    Name = "Nico Hulkenberg",
                    Nationality = "Germany",
                    BirthDate = new DateTime(1987, 8, 19),
                    Team = "Haas",
                    PhotoUrl = "https://media.formula1.com/image/upload/f_auto,c_limit,q_75,w_1320/content/dam/fom-website/drivers/2024Drivers/hulkenberg"
                },
                new Driver
                {
                    Id = 17,
                    DriverNumber = 22,
                    Name = "Yuki Tsunoda",
                    Nationality = "Japan",
                    BirthDate = new DateTime(2000, 5, 11),
                    Team = "Visa Cash App RB F1 Team",
                    PhotoUrl = "https://media.formula1.com/image/upload/f_auto,c_limit,q_75,w_1320/content/dam/fom-website/drivers/2024Drivers/tsunoda"
                },
                new Driver
                {
                    Id = 18,
                    DriverNumber = 30,
                    Name = "Liam Lawson",
                    Nationality = "New Zealand",
                    BirthDate = new DateTime(2002, 2, 11),
                    Team = "Visa Cash App RB F1 Team",
                    PhotoUrl = "https://media.formula1.com/image/upload/f_auto/q_auto/v1727704191/content/dam/fom-website/drivers/2024Drivers/lawson.png"
                },
                new Driver
                {
                    Id = 19,
                    DriverNumber = 23,
                    Name = "Alexander Albon",
                    Nationality = "Thailand",
                    BirthDate = new DateTime(1996, 3, 23),
                    Team = "Williams",
                    PhotoUrl = "https://media.formula1.com/image/upload/f_auto,c_limit,q_75,w_1320/content/dam/fom-website/drivers/2024Drivers/albon"
                },
                new Driver
                {
                    Id = 20,
                    DriverNumber = 43,
                    Name = "Franco Colapinto",
                    Nationality = "Argentine",
                    BirthDate = new DateTime(2003, 5, 27),
                    Team = "Williams",
                    PhotoUrl = "https://media.formula1.com/image/upload/f_auto/q_auto/v1724927004/content/dam/fom-website/drivers/2024Drivers/colapinto.png"
                }
            );


            // Сийдване на начални данни за пистите за сезон 2024
            modelBuilder.Entity<Track>().HasData(
                new Track
                {
                    Id = 1,
                    Name = "Bahrain International Circuit",
                    Location = "Sakhir, Bahrain",
                    LengthKm = 5.412,
                    PhotoUrl = "https://media.formula1.com/image/upload/f_auto,c_limit,w_1440,q_auto/f_auto/q_auto/content/dam/fom-website/2018-redesign-assets/Circuit%20maps%2016x9/Bahrain_Circuit"
                },
                new Track
                {
                    Id = 2,
                    Name = "Jeddah Corniche Circuit",
                    Location = "Jeddah, Saudi Arabia",
                    LengthKm = 6.174,
                    PhotoUrl = "https://media.formula1.com/image/upload/f_auto,c_limit,q_auto,w_1320/content/dam/fom-website/2018-redesign-assets/Circuit%20maps%2016x9/Saudi_Arabia_Circuit"
                },
                new Track
                {
                    Id = 3,
                    Name = "Albert Park Circuit",
                    Location = "Melbourne, Australia",
                    LengthKm = 5.278,
                    PhotoUrl = "https://www.formula1.com/content/dam/fom-website/2018-redesign-assets/Circuit%20maps%2016x9/Australia_Circuit.png"
                },
                new Track
                {
                    Id = 4,
                    Name = "Baku City Circuit",
                    Location = "Baku, Azerbaijan",
                    LengthKm = 6.003,
                    PhotoUrl = "https://media.formula1.com/image/upload/f_auto,c_limit,w_1440,q_auto/f_auto/q_auto/content/dam/fom-website/2018-redesign-assets/Circuit%20maps%2016x9/Baku_Circuit"
                },
                new Track
                {
                    Id = 5,
                    Name = "Miami International Autodrome",
                    Location = "Miami, United States",
                    LengthKm = 5.412,
                    PhotoUrl = "https://media.formula1.com/image/upload/f_auto,c_limit,q_auto,w_1320/content/dam/fom-website/2018-redesign-assets/Circuit%20maps%2016x9/Miami_Circuit"
                },
                new Track
                {
                    Id = 6,
                    Name = "Imola Circuit",
                    Location = "Imola, Italy",
                    LengthKm = 4.909,
                    PhotoUrl = "https://media.formula1.com/image/upload/f_auto,c_limit,q_auto,w_1320/content/dam/fom-website/2018-redesign-assets/Circuit%20maps%2016x9/Emilia_Romagna_Circuit"
                },
                new Track
                {
                    Id = 7,
                    Name = "Circuit de Monaco",
                    Location = "Monte Carlo, Monaco",
                    LengthKm = 3.337,
                    PhotoUrl = "https://www.formula1.com/content/dam/fom-website/2018-redesign-assets/Circuit%20maps%2016x9/Monoco_Circuit.png"
                },
                new Track
                {
                    Id = 8,
                    Name = "Circuit de Barcelona-Catalunya",
                    Location = "Barcelona, Spain",
                    LengthKm = 4.675,
                    PhotoUrl = "https://www.formula1.com/content/dam/fom-website/2018-redesign-assets/Circuit%20maps%2016x9/Spain_Circuit.png"
                },
                new Track
                {
                    Id = 9,
                    Name = "Circuit Gilles Villeneuve",
                    Location = "Montreal, Canada",
                    LengthKm = 4.361,
                    PhotoUrl = "https://www.formula1.com/content/dam/fom-website/2018-redesign-assets/Circuit%20maps%2016x9/Canada_Circuit.png"
                },
                new Track
                {
                    Id = 10,
                    Name = "Red Bull Ring",
                    Location = "Spielberg, Austria",
                    LengthKm = 4.318,
                    PhotoUrl = "https://www.formula1.com/content/dam/fom-website/2018-redesign-assets/Circuit%20maps%2016x9/Austria_Circuit.png"
                },
                new Track
                {
                    Id = 11,
                    Name = "Silverstone Circuit",
                    Location = "Silverstone, United Kingdom",
                    LengthKm = 5.891,
                    PhotoUrl = "https://www.formula1.com/content/dam/fom-website/2018-redesign-assets/Circuit%20maps%2016x9/Great_Britain_Circuit.png"
                },
                new Track
                {
                    Id = 12,
                    Name = "Hungaroring",
                    Location = "Budapest, Hungary",
                    LengthKm = 4.381,
                    PhotoUrl = "https://www.formula1.com/content/dam/fom-website/2018-redesign-assets/Circuit%20maps%2016x9/Hungary_Circuit.png"
                },
                new Track
                {
                    Id = 13,
                    Name = "Circuit de Spa-Francorchamps",
                    Location = "Spa, Belgium",
                    LengthKm = 7.004,
                    PhotoUrl = "https://www.formula1.com/content/dam/fom-website/2018-redesign-assets/Circuit%20maps%2016x9/Belgium_Circuit.png"
                },
                new Track
                {
                    Id = 14,
                    Name = "Circuit Zandvoort",
                    Location = "Zandvoort, Netherlands",
                    LengthKm = 4.259,
                    PhotoUrl = "https://www.formula1.com/content/dam/fom-website/2018-redesign-assets/Circuit%20maps%2016x9/Netherlands_Circuit.png"
                },
                new Track
                {
                    Id = 15,
                    Name = "Monza Circuit",
                    Location = "Monza, Italy",
                    LengthKm = 5.793,
                    PhotoUrl = "https://www.formula1.com/content/dam/fom-website/2018-redesign-assets/Circuit%20maps%2016x9/Italy_Circuit.png"
                },
                new Track
                {
                    Id = 16,
                    Name = "Marina Bay Street Circuit",
                    Location = "Singapore",
                    LengthKm = 5.063,
                    PhotoUrl = "https://www.formula1.com/content/dam/fom-website/2018-redesign-assets/Circuit%20maps%2016x9/Singapore_Circuit.png"
                },
                new Track
                {
                    Id = 17,
                    Name = "Suzuka International Racing Course",
                    Location = "Suzuka, Japan",
                    LengthKm = 5.807,
                    PhotoUrl = "https://www.formula1.com/content/dam/fom-website/2018-redesign-assets/Circuit%20maps%2016x9/Japan_Circuit.png"
                },
                new Track
                {
                    Id = 18,
                    Name = "Losail International Circuit",
                    Location = "Doha, Qatar",
                    LengthKm = 5.380,
                    PhotoUrl = "https://media.formula1.com/image/upload/f_auto,c_limit,q_auto,w_1320/content/dam/fom-website/2018-redesign-assets/Circuit%20maps%2016x9/Qatar_Circuit"
                },
                new Track
                {
                    Id = 19,
                    Name = "Circuit of the Americas",
                    Location = "Austin, United States",
                    LengthKm = 5.513,
                    PhotoUrl = "https://www.formula1.com/content/dam/fom-website/2018-redesign-assets/Circuit%20maps%2016x9/USA_Circuit.png"
                },
                new Track
                {
                    Id = 20,
                    Name = "Autódromo Hermanos Rodríguez",
                    Location = "Mexico City, Mexico",
                    LengthKm = 4.304,
                    PhotoUrl = "https://www.formula1.com/content/dam/fom-website/2018-redesign-assets/Circuit%20maps%2016x9/Mexico_Circuit.png"
                },
                new Track
                {
                    Id = 21,
                    Name = "Interlagos Circuit",
                    Location = "São Paulo, Brazil",
                    LengthKm = 4.309,
                    PhotoUrl = "https://www.formula1.com/content/dam/fom-website/2018-redesign-assets/Circuit%20maps%2016x9/Brazil_Circuit.png"
                },
                new Track
                {
                    Id = 22,
                    Name = "Las Vegas Street Circuit",
                    Location = "Las Vegas, United States",
                    LengthKm = 6.120,
                    PhotoUrl = "https://media.formula1.com/image/upload/f_auto,c_limit,q_auto,w_1320/content/dam/fom-website/2018-redesign-assets/Circuit%20maps%2016x9/Las_Vegas_Circuit"
                },
                new Track
                {
                    Id = 23,
                    Name = "Yas Marina Circuit",
                    Location = "Abu Dhabi, United Arab Emirates",
                    LengthKm = 5.281,
                    PhotoUrl = "https://www.formula1.com/content/dam/fom-website/2018-redesign-assets/Circuit%20maps%2016x9/Abu_Dhabi_Circuit.png"
                }
            );

        }
    }
}
