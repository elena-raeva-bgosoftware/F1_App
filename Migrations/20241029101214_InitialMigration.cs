using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace F1_App.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Drivers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DriverNumber = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Nationality = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Team = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhotoUrl = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Drivers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "F1Histories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Year = table.Column<int>(type: "int", nullable: false),
                    ChampionDriver = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ChampionTeam = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NumberOfRaces = table.Column<int>(type: "int", nullable: false),
                    AdditionalInfo = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_F1Histories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tracks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LengthKm = table.Column<double>(type: "float", nullable: false),
                    PhotoUrl = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tracks", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RaceResults",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RaceId = table.Column<int>(type: "int", nullable: false),
                    DriverId = table.Column<int>(type: "int", nullable: false),
                    Position = table.Column<int>(type: "int", nullable: false),
                    RaceName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RaceDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RaceResults", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RaceResults_Drivers_DriverId",
                        column: x => x.DriverId,
                        principalTable: "Drivers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UpcomingRaces",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RaceName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TrackId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UpcomingRaces", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UpcomingRaces_Tracks_TrackId",
                        column: x => x.TrackId,
                        principalTable: "Tracks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Drivers",
                columns: new[] { "Id", "BirthDate", "DriverNumber", "Name", "Nationality", "PhotoUrl", "Team" },
                values: new object[,]
                {
                    { 1, new DateTime(1997, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Max Verstappen", "Netherlands", "https://cdn-3.motorsport.com/images/mgl/6D1XbeV0/s800/max-verstappen-red-bull-racing.jpg", "Red Bull Racing" },
                    { 2, new DateTime(1990, 1, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 11, "Sergio Perez", "Mexico", "https://cdn-3.motorsport.com/images/mgl/2y3qRdo6/s8/sergio-perez-red-bull-racing.jpg", "Red Bull Racing" },
                    { 3, new DateTime(1997, 10, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 16, "Charles Leclerc", "Monaco", "https://media.formula1.com/image/upload/v1712849104/content/dam/fom-website/drivers/2024Drivers/leclerc.png", "Scuderia Ferrari" },
                    { 4, new DateTime(1994, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 55, "Carlos Sainz", "Spain", "https://media.formula1.com/image/upload/f_auto,c_limit,q_75,w_1320/content/dam/fom-website/drivers/2024Drivers/sainz", "Scuderia Ferrari" },
                    { 5, new DateTime(1985, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 44, "Lewis Hamilton", "United Kingdom", "https://media.formula1.com/image/upload/f_auto,c_limit,q_75,w_1320/content/dam/fom-website/drivers/2024Drivers/hamilton", "Mercedes-AMG Petronas F1 Team" },
                    { 6, new DateTime(1998, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 63, "George Russell", "United Kingdom", "https://media.formula1.com/image/upload/f_auto,c_limit,q_75,w_1320/content/dam/fom-website/drivers/2024Drivers/russell", "Mercedes-AMG Petronas F1 Team" },
                    { 7, new DateTime(1999, 11, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "Lando Norris", "United Kingdom", "https://media.formula1.com/image/upload/f_auto,c_limit,q_75,w_1320/content/dam/fom-website/drivers/2024Drivers/norris", "McLaren" },
                    { 8, new DateTime(2001, 4, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 81, "Oscar Piastri", "Australia", "https://media.formula1.com/image/upload/f_auto,c_limit,q_75,w_1320/content/dam/fom-website/drivers/2024Drivers/piastri", "McLaren" },
                    { 9, new DateTime(1996, 9, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 31, "Esteban Ocon", "France", "https://media.formula1.com/image/upload/v1712849107/content/dam/fom-website/drivers/2024Drivers/ocon.png", "Alpine" },
                    { 10, new DateTime(1996, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 10, "Pierre Gasly", "France", "https://media.formula1.com/image/upload/f_auto,c_limit,q_75,w_1320/content/dam/fom-website/drivers/2024Drivers/gasly", "Alpine" },
                    { 11, new DateTime(1981, 7, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 14, "Fernando Alonso", "Spain", "https://media.formula1.com/image/upload/f_auto,c_limit,q_75,w_1320/content/dam/fom-website/drivers/2024Drivers/alonso", "Aston Martin" },
                    { 12, new DateTime(1998, 10, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 18, "Lance Stroll", "Canada", "https://media.formula1.com/image/upload/f_auto,c_limit,q_auto,w_1320/content/dam/fom-website/drivers/2024Drivers/stroll", "Aston Martin" },
                    { 13, new DateTime(1989, 8, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 77, "Valtteri Bottas", "Finland", "https://media.formula1.com/image/upload/v1712849101/content/dam/fom-website/drivers/2024Drivers/bottas.png", "Kick Sauber-Ferrari" },
                    { 14, new DateTime(1999, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 24, "Zhou Guanyu", "China", "https://media.formula1.com/image/upload/f_auto,c_limit,q_75,w_1320/content/dam/fom-website/drivers/2024Drivers/zhou", "Kick Sauber-Ferrari" },
                    { 15, new DateTime(1992, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 20, "Kevin Magnussen", "Denmark", "https://media.formula1.com/image/upload/f_auto,c_limit,q_75,w_1320/content/dam/fom-website/drivers/2024Drivers/magnussen", "Haas" },
                    { 16, new DateTime(1987, 8, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 27, "Nico Hulkenberg", "Germany", "https://media.formula1.com/image/upload/f_auto,c_limit,q_75,w_1320/content/dam/fom-website/drivers/2024Drivers/hulkenberg", "Haas" },
                    { 17, new DateTime(2000, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 22, "Yuki Tsunoda", "Japan", "https://media.formula1.com/image/upload/f_auto,c_limit,q_75,w_1320/content/dam/fom-website/drivers/2024Drivers/tsunoda", "Visa Cash App RB F1 Team" },
                    { 18, new DateTime(2002, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 30, "Liam Lawson", "New Zealand", "https://media.formula1.com/image/upload/f_auto/q_auto/v1727704191/content/dam/fom-website/drivers/2024Drivers/lawson.png", "Visa Cash App RB F1 Team" },
                    { 19, new DateTime(1996, 3, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 23, "Alexander Albon", "Thailand", "https://media.formula1.com/image/upload/f_auto,c_limit,q_75,w_1320/content/dam/fom-website/drivers/2024Drivers/albon", "Williams" },
                    { 20, new DateTime(2003, 5, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 43, "Franco Colapinto", "Argentine", "https://media.formula1.com/image/upload/f_auto/q_auto/v1724927004/content/dam/fom-website/drivers/2024Drivers/colapinto.png", "Williams" }
                });

            migrationBuilder.InsertData(
                table: "Tracks",
                columns: new[] { "Id", "LengthKm", "Location", "Name", "PhotoUrl" },
                values: new object[,]
                {
                    { 1, 5.4119999999999999, "Sakhir, Bahrain", "Bahrain International Circuit", "https://media.formula1.com/image/upload/f_auto,c_limit,w_1440,q_auto/f_auto/q_auto/content/dam/fom-website/2018-redesign-assets/Circuit%20maps%2016x9/Bahrain_Circuit" },
                    { 2, 6.1740000000000004, "Jeddah, Saudi Arabia", "Jeddah Corniche Circuit", "https://media.formula1.com/image/upload/f_auto,c_limit,q_auto,w_1320/content/dam/fom-website/2018-redesign-assets/Circuit%20maps%2016x9/Saudi_Arabia_Circuit" },
                    { 3, 5.2779999999999996, "Melbourne, Australia", "Albert Park Circuit", "https://www.formula1.com/content/dam/fom-website/2018-redesign-assets/Circuit%20maps%2016x9/Australia_Circuit.png" },
                    { 4, 6.0030000000000001, "Baku, Azerbaijan", "Baku City Circuit", "https://media.formula1.com/image/upload/f_auto,c_limit,w_1440,q_auto/f_auto/q_auto/content/dam/fom-website/2018-redesign-assets/Circuit%20maps%2016x9/Baku_Circuit" },
                    { 5, 5.4119999999999999, "Miami, United States", "Miami International Autodrome", "https://media.formula1.com/image/upload/f_auto,c_limit,q_auto,w_1320/content/dam/fom-website/2018-redesign-assets/Circuit%20maps%2016x9/Miami_Circuit" },
                    { 6, 4.9089999999999998, "Imola, Italy", "Imola Circuit", "https://media.formula1.com/image/upload/f_auto,c_limit,q_auto,w_1320/content/dam/fom-website/2018-redesign-assets/Circuit%20maps%2016x9/Emilia_Romagna_Circuit" },
                    { 7, 3.3370000000000002, "Monte Carlo, Monaco", "Circuit de Monaco", "https://www.formula1.com/content/dam/fom-website/2018-redesign-assets/Circuit%20maps%2016x9/Monoco_Circuit.png" },
                    { 8, 4.6749999999999998, "Barcelona, Spain", "Circuit de Barcelona-Catalunya", "https://www.formula1.com/content/dam/fom-website/2018-redesign-assets/Circuit%20maps%2016x9/Spain_Circuit.png" },
                    { 9, 4.3609999999999998, "Montreal, Canada", "Circuit Gilles Villeneuve", "https://www.formula1.com/content/dam/fom-website/2018-redesign-assets/Circuit%20maps%2016x9/Canada_Circuit.png" },
                    { 10, 4.3179999999999996, "Spielberg, Austria", "Red Bull Ring", "https://www.formula1.com/content/dam/fom-website/2018-redesign-assets/Circuit%20maps%2016x9/Austria_Circuit.png" },
                    { 11, 5.891, "Silverstone, United Kingdom", "Silverstone Circuit", "https://www.formula1.com/content/dam/fom-website/2018-redesign-assets/Circuit%20maps%2016x9/Great_Britain_Circuit.png" },
                    { 12, 4.3810000000000002, "Budapest, Hungary", "Hungaroring", "https://www.formula1.com/content/dam/fom-website/2018-redesign-assets/Circuit%20maps%2016x9/Hungary_Circuit.png" },
                    { 13, 7.0039999999999996, "Spa, Belgium", "Circuit de Spa-Francorchamps", "https://www.formula1.com/content/dam/fom-website/2018-redesign-assets/Circuit%20maps%2016x9/Belgium_Circuit.png" },
                    { 14, 4.2590000000000003, "Zandvoort, Netherlands", "Circuit Zandvoort", "https://www.formula1.com/content/dam/fom-website/2018-redesign-assets/Circuit%20maps%2016x9/Netherlands_Circuit.png" },
                    { 15, 5.7930000000000001, "Monza, Italy", "Monza Circuit", "https://www.formula1.com/content/dam/fom-website/2018-redesign-assets/Circuit%20maps%2016x9/Italy_Circuit.png" },
                    { 16, 5.0629999999999997, "Singapore", "Marina Bay Street Circuit", "https://www.formula1.com/content/dam/fom-website/2018-redesign-assets/Circuit%20maps%2016x9/Singapore_Circuit.png" },
                    { 17, 5.8070000000000004, "Suzuka, Japan", "Suzuka International Racing Course", "https://www.formula1.com/content/dam/fom-website/2018-redesign-assets/Circuit%20maps%2016x9/Japan_Circuit.png" },
                    { 18, 5.3799999999999999, "Doha, Qatar", "Losail International Circuit", "https://media.formula1.com/image/upload/f_auto,c_limit,q_auto,w_1320/content/dam/fom-website/2018-redesign-assets/Circuit%20maps%2016x9/Qatar_Circuit" },
                    { 19, 5.5129999999999999, "Austin, United States", "Circuit of the Americas", "https://www.formula1.com/content/dam/fom-website/2018-redesign-assets/Circuit%20maps%2016x9/USA_Circuit.png" },
                    { 20, 4.3040000000000003, "Mexico City, Mexico", "Autódromo Hermanos Rodríguez", "https://www.formula1.com/content/dam/fom-website/2018-redesign-assets/Circuit%20maps%2016x9/Mexico_Circuit.png" },
                    { 21, 4.3090000000000002, "São Paulo, Brazil", "Interlagos Circuit", "https://www.formula1.com/content/dam/fom-website/2018-redesign-assets/Circuit%20maps%2016x9/Brazil_Circuit.png" },
                    { 22, 6.1200000000000001, "Las Vegas, United States", "Las Vegas Street Circuit", "https://media.formula1.com/image/upload/f_auto,c_limit,q_auto,w_1320/content/dam/fom-website/2018-redesign-assets/Circuit%20maps%2016x9/Las_Vegas_Circuit" },
                    { 23, 5.2809999999999997, "Abu Dhabi, United Arab Emirates", "Yas Marina Circuit", "https://www.formula1.com/content/dam/fom-website/2018-redesign-assets/Circuit%20maps%2016x9/Abu_Dhabi_Circuit.png" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_RaceResults_DriverId",
                table: "RaceResults",
                column: "DriverId");

            migrationBuilder.CreateIndex(
                name: "IX_UpcomingRaces_TrackId",
                table: "UpcomingRaces",
                column: "TrackId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "F1Histories");

            migrationBuilder.DropTable(
                name: "RaceResults");

            migrationBuilder.DropTable(
                name: "UpcomingRaces");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Drivers");

            migrationBuilder.DropTable(
                name: "Tracks");
        }
    }
}
