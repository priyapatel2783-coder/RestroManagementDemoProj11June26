using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RestroManagement.Migrations
{
    /// <inheritdoc />
    public partial class rs : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AppUser",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppUser", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Countries",
                columns: table => new
                {
                    UniqueId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Countries", x => x.UniqueId);
                });

            migrationBuilder.CreateTable(
                name: "Fooditems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DietaryPreference = table.Column<int>(type: "int", nullable: false),
                    IsAvailable = table.Column<bool>(type: "bit", nullable: false),
                    PriceCalculationMethod = table.Column<int>(type: "int", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastUpdated = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fooditems", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MenuCategories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DisplayOrder = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MenuCategories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Merchants",
                columns: table => new
                {
                    UniqueId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BusinessLicense = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsVerified = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Merchants", x => x.UniqueId);
                });

            migrationBuilder.CreateTable(
                name: "MerchantStaffs",
                columns: table => new
                {
                    UniqueId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MerchantId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    Role = table.Column<int>(type: "int", nullable: false),
                    Designation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MerchantStaffs", x => x.UniqueId);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MobileNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OrderDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PackagingCharges = table.Column<float>(type: "real", nullable: false),
                    Discount = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Stores",
                columns: table => new
                {
                    UniqueId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MerchantId = table.Column<int>(type: "int", nullable: false),
                    StoreName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StoreAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StoreDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stores", x => x.UniqueId);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AppUser_UserId",
                        column: x => x.UserId,
                        principalTable: "AppUser",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AppUser_UserId",
                        column: x => x.UserId,
                        principalTable: "AppUser",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AppUser_UserId",
                        column: x => x.UserId,
                        principalTable: "AppUser",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<int>(type: "int", nullable: false),
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
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false),
                    RoleId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AppUser_UserId",
                        column: x => x.UserId,
                        principalTable: "AppUser",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "States",
                columns: table => new
                {
                    UniqueId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CountryId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_States", x => x.UniqueId);
                    table.ForeignKey(
                        name: "FK_States_Countries_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Countries",
                        principalColumn: "UniqueId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FoodItemImages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FoodItemId = table.Column<int>(type: "int", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsPrimary = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FoodItemImages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FoodItemImages_Fooditems_FoodItemId",
                        column: x => x.FoodItemId,
                        principalTable: "Fooditems",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FoodItemPortions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FoodItemId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<float>(type: "real", nullable: false),
                    Cost = table.Column<float>(type: "real", nullable: false),
                    BaseQuantity = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FoodItemPortions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FoodItemPortions_Fooditems_FoodItemId",
                        column: x => x.FoodItemId,
                        principalTable: "Fooditems",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FoodItemCategories",
                columns: table => new
                {
                    FoodItemId = table.Column<int>(type: "int", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FoodItemCategories", x => new { x.FoodItemId, x.CategoryId });
                    table.ForeignKey(
                        name: "FK_FoodItemCategories_Fooditems_FoodItemId",
                        column: x => x.FoodItemId,
                        principalTable: "Fooditems",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FoodItemCategories_MenuCategories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "MenuCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Cities",
                columns: table => new
                {
                    UniqueId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StateId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cities", x => x.UniqueId);
                    table.ForeignKey(
                        name: "FK_Cities_States_StateId",
                        column: x => x.StateId,
                        principalTable: "States",
                        principalColumn: "UniqueId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FoodItemId = table.Column<int>(type: "int", nullable: false),
                    FoodItemPortionId = table.Column<int>(type: "int", nullable: true),
                    Quantity = table.Column<float>(type: "real", nullable: false),
                    Price = table.Column<float>(type: "real", nullable: false),
                    OrderId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrderItems_FoodItemPortions_FoodItemPortionId",
                        column: x => x.FoodItemPortionId,
                        principalTable: "FoodItemPortions",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_OrderItems_Fooditems_FoodItemId",
                        column: x => x.FoodItemId,
                        principalTable: "Fooditems",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderItems_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { 1, "afa7a44a-e339-453a-8890-c48355bae2ae", "SuperAdmin", "SUPERADMIN" },
                    { 2, "b2c3d4e5-f6g7-8901-hijk-lmno12345678", "Restaurant ", "RESTAURANT" },
                    { 3, "d1c9e5b8-7a0c-4f1e-9b2e-8c6a5f2b3c4d", "Waiter", "WAITER" },
                    { 4, "a1b2c3d4-e5f6-7890-abcd-ef1234567890", "Guest", "GUEST" }
                });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "UniqueId", "Name" },
                values: new object[] { 1, "India" });

            migrationBuilder.InsertData(
                table: "States",
                columns: new[] { "UniqueId", "CountryId", "Name" },
                values: new object[,]
                {
                    { 1, 1, "Andaman and Nicobar Islands" },
                    { 2, 1, "Andhra Pradesh" },
                    { 3, 1, "Arunachal Pradesh" },
                    { 4, 1, "Assam" },
                    { 5, 1, "Bihar" },
                    { 6, 1, "Chandigarh" },
                    { 7, 1, "Chhattisgarh" },
                    { 8, 1, "Dadra and Nagar Haveli" },
                    { 9, 1, "Delhi" },
                    { 10, 1, "Goa" },
                    { 11, 1, "Gujarat" },
                    { 12, 1, "Haryana" },
                    { 13, 1, "Himachal Pradesh" },
                    { 14, 1, "Jammu and Kashmir" },
                    { 15, 1, "Jharkhand" },
                    { 16, 1, "Karnataka" },
                    { 17, 1, "Karnatka" },
                    { 18, 1, "Kerala" },
                    { 19, 1, "Madhya Pradesh" },
                    { 20, 1, "Maharashtra" },
                    { 21, 1, "Manipur" },
                    { 22, 1, "Meghalaya" },
                    { 23, 1, "Mizoram" },
                    { 24, 1, "Nagaland" },
                    { 25, 1, "Odisha" },
                    { 26, 1, "Puducherry" },
                    { 27, 1, "Punjab" },
                    { 28, 1, "Rajasthan" },
                    { 29, 1, "Tamil Nadu" },
                    { 30, 1, "Telangana" },
                    { 31, 1, "Tripura" },
                    { 32, 1, " Uttar Pradesh" },
                    { 33, 1, "Uttarakhand" },
                    { 34, 1, "West Bengal" }
                });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "UniqueId", "Name", "StateId" },
                values: new object[,]
                {
                    { 1, "Port Blai", 1 },
                    { 2, "Yemmiganu", 2 },
                    { 3, "Kadir", 2 },
                    { 4, "Rajampe", 2 },
                    { 5, "Tadpatr", 2 },
                    { 6, "Tadepalligude", 2 },
                    { 7, "Chilakaluripe", 2 },
                    { 8, "Chiral", 2 },
                    { 9, "Anakapall", 2 },
                    { 10, "Kaval", 2 },
                    { 11, "Palacol", 2 },
                    { 12, "Sullurpet", 2 },
                    { 13, "Tanuk", 2 },
                    { 14, "Rayachot", 2 },
                    { 15, "Srikalahast", 2 },
                    { 16, "Bapatl", 2 },
                    { 17, "Naidupe", 2 },
                    { 18, "Nagar", 2 },
                    { 19, "Gudu", 2 },
                    { 20, "Vinukond", 2 },
                    { 21, "Narasapura", 2 },
                    { 22, "Nuzvi", 2 },
                    { 23, "Markapu", 2 },
                    { 24, "Ponnu", 2 },
                    { 25, "Kanduku", 2 },
                    { 26, "Bobbil", 2 },
                    { 27, "Rayadur", 2 },
                    { 28, "Visakhapatna", 2 },
                    { 29, "Vijayawad", 2 },
                    { 30, "Guntu", 2 },
                    { 31, "Nellor", 2 },
                    { 32, "Kurnoo", 2 },
                    { 33, "Rajahmundr", 2 },
                    { 34, "Kakinad", 2 },
                    { 35, "Tirupat", 2 },
                    { 36, "Anantapu", 2 },
                    { 37, "Kadap", 2 },
                    { 38, "Vizianagara", 2 },
                    { 39, "Elur", 2 },
                    { 40, "Ongol", 2 },
                    { 41, "Nandya", 2 },
                    { 42, "Machilipatna", 2 },
                    { 43, "Adon", 2 },
                    { 44, "Tenal", 2 },
                    { 45, "Chittoo", 2 },
                    { 46, "Hindupu", 2 },
                    { 47, "Proddatu", 2 },
                    { 48, "Bhimavara", 2 },
                    { 49, "Madanapall", 2 },
                    { 50, "Guntaka", 2 },
                    { 51, "Dharmavara", 2 },
                    { 52, "Gudivad", 2 },
                    { 53, "Srikakula", 2 },
                    { 54, "Narasaraope", 2 },
                    { 55, "Samalko", 2 },
                    { 56, "Jaggaiahpe", 2 },
                    { 57, "Tun", 2 },
                    { 58, "Amalapura", 2 },
                    { 59, "Bheemunipatna", 2 },
                    { 60, "Sattenapall", 2 },
                    { 61, "Venkatagir", 2 },
                    { 62, "Pithapura", 2 },
                    { 63, "Palasa Kasibugg", 2 },
                    { 64, "Parvathipura", 2 },
                    { 65, "Goot", 2 },
                    { 66, "Salu", 2 },
                    { 67, "Macherl", 2 },
                    { 68, "Mandapet", 2 },
                    { 69, "Jammalamadug", 2 },
                    { 70, "Peddapura", 2 },
                    { 71, "Punganu", 2 },
                    { 72, "Nidadavol", 2 },
                    { 73, "Repall", 2 },
                    { 74, "Ramachandrapura", 2 },
                    { 75, "Kovvu", 2 },
                    { 76, "Tiruvur", 2 },
                    { 77, "Uravakond", 2 },
                    { 78, "Narsipatna", 2 },
                    { 79, "Yerraguntl", 2 },
                    { 80, "Pedan", 2 },
                    { 81, "Puttu", 2 },
                    { 82, "Renigunt", 2 },
                    { 83, "Raja", 2 },
                    { 84, "Srisailam Project (Right Flank Colony) Townshi", 2 },
                    { 85, "Pasigha", 3 },
                    { 86, "Naharlagu", 3 },
                    { 87, "Lank", 4 },
                    { 88, "Barpet", 4 },
                    { 89, "Goalpar", 4 },
                    { 90, "Silapatha", 4 },
                    { 91, "Margherit", 4 },
                    { 92, "Mangaldo", 4 },
                    { 93, "Rangi", 4 },
                    { 94, "Mankacha", 4 },
                    { 95, "Lumdin", 4 },
                    { 96, "Nalbar", 4 },
                    { 97, "Nagao", 4 },
                    { 98, "Dibrugar", 4 },
                    { 99, "Silcha", 4 },
                    { 100, "Guwahat", 4 },
                    { 101, "Sibsaga", 4 },
                    { 102, "Karimgan", 4 },
                    { 103, "Tezpu", 4 },
                    { 104, "North Lakhimpu", 4 },
                    { 105, "Diph", 4 },
                    { 106, "Dhubr", 4 },
                    { 107, "Jorha", 4 },
                    { 108, "Bongaigaon Cit", 4 },
                    { 109, "Tinsuki", 4 },
                    { 110, "Marian", 4 },
                    { 111, "Marigao", 4 },
                    { 112, "Maharajgan", 5 },
                    { 113, "Sila", 5 },
                    { 114, "Asargan", 5 },
                    { 115, "Bar", 5 },
                    { 116, "Lakhisara", 5 },
                    { 117, "Nawad", 5 },
                    { 118, "Aurangaba", 5 },
                    { 119, "Buxa", 5 },
                    { 120, "Jehanaba", 5 },
                    { 121, "Jamalpu", 5 },
                    { 122, "Kishangan", 5 },
                    { 123, "Siwa", 5 },
                    { 124, "Arari", 5 },
                    { 125, "Jamu", 5 },
                    { 126, "Sitamarh", 5 },
                    { 127, "Gopalgan", 5 },
                    { 128, "Masaurh", 5 },
                    { 129, "Madhuban", 5 },
                    { 130, "Samastipu", 5 },
                    { 131, "Mokame", 5 },
                    { 132, "Dumrao", 5 },
                    { 133, "Supau", 5 },
                    { 134, "Patn", 5 },
                    { 135, "Chhapr", 5 },
                    { 136, "Begusara", 5 },
                    { 137, "Arra", 5 },
                    { 138, "Darbhang", 5 },
                    { 139, "Bhagalpu", 5 },
                    { 140, "Muzaffarpu", 5 },
                    { 141, "Gay", 5 },
                    { 142, "Purni", 5 },
                    { 143, "Munge", 5 },
                    { 144, "Katiha", 5 },
                    { 145, "Sahars", 5 },
                    { 146, "Dehri-on-Son", 5 },
                    { 147, "Bettia", 5 },
                    { 148, "Sasara", 5 },
                    { 149, "Hajipu", 5 },
                    { 150, "Bagah", 5 },
                    { 151, "Motihar", 5 },
                    { 152, "Roser", 5 },
                    { 153, "Nokh", 5 },
                    { 154, "Sugaul", 5 },
                    { 155, "Makhdumpu", 5 },
                    { 156, "Mane", 5 },
                    { 157, "Rafigan", 5 },
                    { 158, "Marhaur", 5 },
                    { 159, "Pir", 5 },
                    { 160, "Mirgan", 5 },
                    { 161, "Lalgan", 5 },
                    { 162, "Murligan", 5 },
                    { 163, "Motipu", 5 },
                    { 164, "Manihar", 5 },
                    { 165, "Sheoha", 5 },
                    { 166, "Arwa", 5 },
                    { 167, "Forbesgan", 5 },
                    { 168, "BhabUrban Agglomeratio", 5 },
                    { 169, "Narkatiagan", 5 },
                    { 170, "Naugachhi", 5 },
                    { 171, "Sheikhpur", 5 },
                    { 172, "Sultangan", 5 },
                    { 173, "Raxaul Baza", 5 },
                    { 174, "Madhepur", 5 },
                    { 175, "Mahnar Baza", 5 },
                    { 176, "Ramnaga", 5 },
                    { 177, "Rajgi", 5 },
                    { 178, "Sonepu", 5 },
                    { 179, "Sherghat", 5 },
                    { 180, "Warisaligan", 5 },
                    { 181, "Revelgan", 5 },
                    { 182, "Chandigar", 6 },
                    { 183, "Bhilai Naga", 7 },
                    { 184, "Raipu", 7 },
                    { 185, "Bilaspu", 7 },
                    { 186, "Korb", 7 },
                    { 187, "Dur", 7 },
                    { 188, "Jagdalpu", 7 },
                    { 189, "Ambikapu", 7 },
                    { 190, "Raigar", 7 },
                    { 191, "Rajnandgao", 7 },
                    { 192, "Bhatapar", 7 },
                    { 193, "Chirmir", 7 },
                    { 194, "Mahasamun", 7 },
                    { 195, "Dhamtar", 7 },
                    { 196, "Naila Janjgi", 7 },
                    { 197, "Dalli-Rajhar", 7 },
                    { 198, "Manendragar", 7 },
                    { 199, "Mungel", 7 },
                    { 200, "Tilda Newr", 7 },
                    { 201, "Sakt", 7 },
                    { 202, "Silvass", 8 },
                    { 203, "New Delh", 9 },
                    { 204, "Delh", 9 },
                    { 205, "Marmaga", 10 },
                    { 206, "Panaj", 10 },
                    { 207, "Marga", 10 },
                    { 208, "Mapus", 10 },
                    { 209, "Padr", 11 },
                    { 210, "Vyar", 11 },
                    { 211, "Lunawad", 11 },
                    { 212, "Vap", 11 },
                    { 213, "Umret", 11 },
                    { 214, "Rajpipl", 11 },
                    { 215, "Sanan", 11 },
                    { 216, "Rajul", 11 },
                    { 217, "Siho", 11 },
                    { 218, "Mandv", 11 },
                    { 219, "Thangad", 11 },
                    { 220, "Wankane", 11 },
                    { 221, "Limbd", 11 },
                    { 222, "Kapadvan", 11 },
                    { 223, "Petla", 11 },
                    { 224, "Palitan", 11 },
                    { 225, "Lath", 11 },
                    { 226, "Rapa", 11 },
                    { 227, "Songad", 11 },
                    { 228, "Vijapu", 11 },
                    { 229, "Pard", 11 },
                    { 230, "Radhanpu", 11 },
                    { 231, "Mahemdaba", 11 },
                    { 232, "Ranava", 11 },
                    { 233, "Salay", 11 },
                    { 234, "Manavada", 11 },
                    { 235, "Talaj", 11 },
                    { 236, "Vadnaga", 11 },
                    { 237, "Thara", 11 },
                    { 238, "Mans", 11 },
                    { 239, "Umbergao", 11 },
                    { 240, "Amrel", 11 },
                    { 241, "Dees", 11 },
                    { 242, "Dhoraj", 11 },
                    { 243, "Khambha", 11 },
                    { 244, "Mahuv", 11 },
                    { 245, "Anja", 11 },
                    { 246, "Wadhwa", 11 },
                    { 247, "Kesho", 11 },
                    { 248, "Ankleshwa", 11 },
                    { 249, "Savarkundl", 11 },
                    { 250, "Kad", 11 },
                    { 251, "Visnaga", 11 },
                    { 252, "Uplet", 11 },
                    { 253, "Un", 11 },
                    { 254, "Sidhpu", 11 },
                    { 255, "Modas", 11 },
                    { 256, "Viramga", 11 },
                    { 257, "Unjh", 11 },
                    { 258, "Mangro", 11 },
                    { 259, "Ahmedaba", 11 },
                    { 260, "Vadodar", 11 },
                    { 261, "Sura", 11 },
                    { 262, "Rajko", 11 },
                    { 263, "Bhavnaga", 11 },
                    { 264, "Jamnaga", 11 },
                    { 265, "Godhr", 11 },
                    { 266, "Palanpu", 11 },
                    { 267, "Bhu", 11 },
                    { 268, "Valsa", 11 },
                    { 269, "Pata", 11 },
                    { 270, "Verava", 11 },
                    { 271, "Vap", 11 },
                    { 272, "Navsar", 11 },
                    { 273, "Bharuc", 11 },
                    { 274, "Mahesan", 11 },
                    { 275, "Nadia", 11 },
                    { 276, "Anan", 11 },
                    { 277, "Porbanda", 11 },
                    { 278, "Morv", 11 },
                    { 279, "Chhapr", 11 },
                    { 280, "Adala", 11 },
                    { 281, "Sarso", 12 },
                    { 282, "Rani", 12 },
                    { 1098, "Mema", 34 },
                    { 1100, "Achhnera", 32 },
                    { 1101, "Agra", 32 },
                    { 1102, "Aligarh", 32 },
                    { 1103, "Allahabad", 32 },
                    { 1104, "Amroha", 32 },
                    { 1105, "Azamgarh", 32 },
                    { 1106, "Bahraich", 32 },
                    { 1107, "Chandausi", 32 },
                    { 1108, "Etawah", 32 },
                    { 1109, "Fatehpur Sikri", 32 },
                    { 1110, "Firozabad", 32 },
                    { 1111, "Hapur", 32 },
                    { 1112, "Hardoi ", 32 },
                    { 1113, "Jhansi", 32 },
                    { 1114, "Kalpi", 32 },
                    { 1115, "Kanpur", 32 },
                    { 1116, "Khair", 32 },
                    { 1117, "Laharpur", 32 },
                    { 1118, "Lakhimpur", 32 },
                    { 1119, "Lal Gopalganj Nindaura", 32 },
                    { 1120, "Lalganj", 32 },
                    { 1121, "Lalitpur", 32 },
                    { 1122, "Lar", 32 },
                    { 1123, "Loni", 32 },
                    { 1124, "Lucknow", 32 },
                    { 1125, "Mathura", 32 },
                    { 1126, "Meerut", 32 },
                    { 1127, "Modinagar", 32 },
                    { 1128, "Moradabad", 32 },
                    { 1129, "Nagina", 32 },
                    { 1130, "Najibabad", 32 },
                    { 1131, "Nakur", 32 },
                    { 1132, "Nanpara", 32 },
                    { 1133, "Naraura", 32 },
                    { 1134, "Naugawan Sadat", 32 },
                    { 1135, "Nautanwa", 32 },
                    { 1136, "Nawabganj", 32 },
                    { 1137, "Nehtaur", 32 },
                    { 1138, "Niwai", 32 },
                    { 1139, "Noida", 32 },
                    { 1140, "Noorpur", 32 },
                    { 1141, "Obra", 32 },
                    { 1142, "Orai", 32 },
                    { 1143, "Padrauna", 32 },
                    { 1144, "Palia Kalan", 32 },
                    { 1145, "Parasi", 32 },
                    { 1146, "Phulpur", 32 },
                    { 1147, "Pihani", 32 },
                    { 1148, "Pilibhit", 32 },
                    { 1149, "Pilkhuwa", 32 },
                    { 1150, "Powayan", 32 },
                    { 1151, "Pukhrayan", 32 },
                    { 1152, "Puranpur", 32 },
                    { 1153, "PurqUrban Agglomerationzi", 32 },
                    { 1154, "Purwa", 32 },
                    { 1155, "Rae Bareli", 32 },
                    { 1156, "Rampur", 32 },
                    { 1157, "Rampur Maniharan", 32 },
                    { 1158, "Rasra", 32 },
                    { 1159, "Rath", 32 },
                    { 1160, "Renukoot", 32 },
                    { 1161, "Reoti", 32 },
                    { 1162, "Robertsganj", 32 },
                    { 1163, "Rudauli", 32 },
                    { 1164, "Rudrapur", 32 },
                    { 1165, "Sadabad", 32 },
                    { 1166, "Safipur", 32 },
                    { 1167, "Saharanpur", 32 },
                    { 1168, "Sahaspur", 32 },
                    { 1169, "Sahaswan", 32 },
                    { 1170, "Sahawar", 32 },
                    { 1171, "Sahjanwa", 32 },
                    { 1172, "Saidpur", 32 },
                    { 1173, "Sambhal", 32 },
                    { 1174, "Samdhan", 32 },
                    { 1175, "Samthar", 32 },
                    { 1176, "Sandi", 32 },
                    { 1177, "Sandila", 32 },
                    { 1178, "Sardhana", 32 },
                    { 1179, "Seohara", 32 },
                    { 1180, "Shahabad, Hardoi", 32 },
                    { 1181, "Shahabad, Rampur", 32 },
                    { 1182, "Shahganj", 32 },
                    { 1183, "Shahjahanpur", 32 },
                    { 1184, "Shamli", 32 },
                    { 1185, "Shamsabad, Agra", 32 },
                    { 1186, "Shamsabad, Farrukhabad", 32 },
                    { 1187, "Sherkot", 32 },
                    { 1188, "Shikarpur, Bulandshahr", 32 },
                    { 1189, "Shikohabad", 32 },
                    { 1190, "Shishgarh", 32 },
                    { 1191, "Siana", 32 },
                    { 1192, "Sikanderpur", 32 },
                    { 1193, "Sikandra Rao", 32 },
                    { 1194, "Sikandrabad", 32 },
                    { 1195, "Sirsaganj", 32 },
                    { 1196, "Sirsi", 32 },
                    { 1197, "Sitapur", 32 },
                    { 1198, "Soron", 32 },
                    { 1199, "Sultanpur", 32 },
                    { 1200, "Sumerpur", 32 },
                    { 1201, "SUrban Agglomerationr", 32 },
                    { 1202, "Tanda", 32 },
                    { 1203, "Thakurdwara", 32 },
                    { 1204, "Thana Bhawan", 32 },
                    { 1205, "Tilhar", 32 },
                    { 1206, "Tirwaganj", 32 },
                    { 1207, "Tulsipur", 32 },
                    { 1208, "Tundla", 32 },
                    { 1209, "Ujhani", 32 },
                    { 1210, "Unnao", 32 },
                    { 1211, "Utraula", 32 },
                    { 1212, "Varanasi", 32 },
                    { 1213, "Vrindavan", 32 },
                    { 1214, "Warhapur", 32 },
                    { 1215, "Zaidpur", 32 },
                    { 1216, "Zamania", 32 }
                });

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AppUser",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AppUser",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

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
                name: "IX_Cities_StateId",
                table: "Cities",
                column: "StateId");

            migrationBuilder.CreateIndex(
                name: "IX_FoodItemCategories_CategoryId",
                table: "FoodItemCategories",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_FoodItemImages_FoodItemId",
                table: "FoodItemImages",
                column: "FoodItemId");

            migrationBuilder.CreateIndex(
                name: "IX_FoodItemPortions_FoodItemId",
                table: "FoodItemPortions",
                column: "FoodItemId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_FoodItemId",
                table: "OrderItems",
                column: "FoodItemId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_FoodItemPortionId",
                table: "OrderItems",
                column: "FoodItemPortionId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_OrderId",
                table: "OrderItems",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_States_CountryId",
                table: "States",
                column: "CountryId");
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
                name: "Cities");

            migrationBuilder.DropTable(
                name: "FoodItemCategories");

            migrationBuilder.DropTable(
                name: "FoodItemImages");

            migrationBuilder.DropTable(
                name: "Merchants");

            migrationBuilder.DropTable(
                name: "MerchantStaffs");

            migrationBuilder.DropTable(
                name: "OrderItems");

            migrationBuilder.DropTable(
                name: "Stores");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AppUser");

            migrationBuilder.DropTable(
                name: "States");

            migrationBuilder.DropTable(
                name: "MenuCategories");

            migrationBuilder.DropTable(
                name: "FoodItemPortions");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Countries");

            migrationBuilder.DropTable(
                name: "Fooditems");
        }
    }
}
