using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Ecommerce.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Discriminator = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Name = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NormalizedName = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ConcurrencyStamp = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Bio = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    FullName = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Avatar = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Address = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IsDeleted = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    UserName = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NormalizedUserName = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Email = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NormalizedEmail = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    EmailConfirmed = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    PasswordHash = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    SecurityStamp = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ConcurrencyStamp = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PhoneNumber = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PhoneNumberConfirmed = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetime(6)", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Name = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    RoleId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ClaimType = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ClaimValue = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
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
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ClaimType = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ClaimValue = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
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
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ProviderKey = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ProviderDisplayName = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    UserId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
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
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    RoleId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
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
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    LoginProvider = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Name = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Value = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
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
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    UserId = table.Column<string>(type: "varchar(255)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Status = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Orders_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Name = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Price = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Description = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Image = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CategoryId = table.Column<string>(type: "varchar(255)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "OrderDetails",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ProductId = table.Column<string>(type: "varchar(255)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    OrderId = table.Column<string>(type: "varchar(255)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrderDetails_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_OrderDetails_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Discriminator", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "b600478d-f98b-4a27-aa95-14563920d28f", "38e2ea85-58e1-42a6-b02f-6cd12914e0e7", "Role", "Guest", "GUEST" },
                    { "cc3b4c20-7ab3-4daa-b777-0018ee8c615c", "4321c8ff-bf08-4004-98a3-174be3a19438", "Role", "Admin", "ADMIN" },
                    { "dddd1a59-3b57-45f6-96b5-91b3e269e87c", "e995e4ab-292a-45c0-9b73-f8e04694f3b0", "Role", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "Avatar", "Bio", "ConcurrencyStamp", "Email", "EmailConfirmed", "FullName", "IsDeleted", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "2dfb43f4-24d5-44a7-af3c-78196e881f23", 0, null, null, null, "db2c5dce-4232-4e03-8527-8729c2029d2e", "admin@gmail.com", false, null, false, false, null, "ADMIN@GMAIL.COM", "ADMIN", "AQAAAAEAACcQAAAAEL9mII8beu8tjw6mh5JAHpWuTWg1l7+tgRnvYClpWpjRh436/61C4W2D087Bn8efjA==", null, false, "d42a5b15-7e80-46f8-873b-095b2b247bc7", false, "Admin" },
                    { "75fa9827-0f5f-41db-a825-64d68d242d7e", 0, null, null, null, "88a92330-8f73-4fbb-916b-aec1e1b187cc", "user@gmail.com", false, null, false, false, null, "USER@GMAIL.COM", "USER", "AQAAAAEAACcQAAAAED5zOQ+dt8K/cxCZeSG0A1dl9HZ6IAie9NS3ac+ccp9ZO7yY1C8cucoF1nTZyDQUGA==", null, false, "04a418df-9916-44d0-b5dc-2b6dade7b722", false, "User" },
                    { "df31566d-5ccb-45dc-b1be-864d72133ca4", 0, null, null, null, "1e5b817f-00a6-41ce-b82e-31744e251e18", "guest@gmail.com", false, null, false, false, null, "GUEST@GMAIL.COM", "GUEST", "AQAAAAEAACcQAAAAEMRbNZ3zxaCSA+mplWJ8NiHnz/T1r2kYSOjXQlUlQNAt2yp0R7Z4q/V6CGRs/Qiwfg==", null, false, "530bd96f-443e-46ce-883a-79f505422d11", false, "Guest" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedAt", "IsDeleted", "Name", "UpdatedAt" },
                values: new object[,]
                {
                    { "14ff024d-5bb7-4ac9-8c45-a02a9c3ab87d", new DateTime(2023, 1, 9, 14, 46, 18, 448, DateTimeKind.Local).AddTicks(3555), false, "Legacy Communications Officer", new DateTime(2023, 1, 9, 14, 46, 18, 448, DateTimeKind.Local).AddTicks(3556) },
                    { "1aed7183-3c10-4cfc-9278-9e894d92860e", new DateTime(2023, 1, 9, 14, 46, 18, 448, DateTimeKind.Local).AddTicks(3370), false, "Global Functionality Associate", new DateTime(2023, 1, 9, 14, 46, 18, 448, DateTimeKind.Local).AddTicks(3371) },
                    { "20d9d32a-a410-46fe-a999-7ba96f176d7e", new DateTime(2023, 1, 9, 14, 46, 18, 448, DateTimeKind.Local).AddTicks(3591), false, "Central Mobility Technician", new DateTime(2023, 1, 9, 14, 46, 18, 448, DateTimeKind.Local).AddTicks(3592) },
                    { "2e3a5d34-df97-4510-8753-9ee23a21fdc1", new DateTime(2023, 1, 9, 14, 46, 18, 448, DateTimeKind.Local).AddTicks(3299), false, "International Solutions Manager", new DateTime(2023, 1, 9, 14, 46, 18, 448, DateTimeKind.Local).AddTicks(3303) },
                    { "819c3b1a-9132-491e-bc76-c96a1a861a24", new DateTime(2023, 1, 9, 14, 46, 18, 448, DateTimeKind.Local).AddTicks(3486), false, "Dynamic Solutions Assistant", new DateTime(2023, 1, 9, 14, 46, 18, 448, DateTimeKind.Local).AddTicks(3487) },
                    { "82a6b2f2-bfad-4db4-bdde-1cd52e52eede", new DateTime(2023, 1, 9, 14, 46, 18, 448, DateTimeKind.Local).AddTicks(3520), false, "Forward Response Analyst", new DateTime(2023, 1, 9, 14, 46, 18, 448, DateTimeKind.Local).AddTicks(3521) },
                    { "bfe502d6-2730-4cb5-9204-950b3dbe2d13", new DateTime(2023, 1, 9, 14, 46, 18, 448, DateTimeKind.Local).AddTicks(2765), false, "District Brand Analyst", new DateTime(2023, 1, 9, 14, 46, 18, 448, DateTimeKind.Local).AddTicks(2780) },
                    { "c03da159-e6b4-46e9-a9dd-3c7dbfe62a16", new DateTime(2023, 1, 9, 14, 46, 18, 448, DateTimeKind.Local).AddTicks(3412), false, "Investor Identity Strategist", new DateTime(2023, 1, 9, 14, 46, 18, 448, DateTimeKind.Local).AddTicks(3413) },
                    { "d9865550-b080-4423-9cbf-a87753ecfdcd", new DateTime(2023, 1, 9, 14, 46, 18, 448, DateTimeKind.Local).AddTicks(3450), false, "Customer Research Supervisor", new DateTime(2023, 1, 9, 14, 46, 18, 448, DateTimeKind.Local).AddTicks(3451) },
                    { "f9f18638-8755-4c6d-aa69-49c209d83d2e", new DateTime(2023, 1, 9, 14, 46, 18, 448, DateTimeKind.Local).AddTicks(3630), false, "Legacy Intranet Director", new DateTime(2023, 1, 9, 14, 46, 18, 448, DateTimeKind.Local).AddTicks(3631) }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "CreatedAt", "Description", "Image", "IsDeleted", "Name", "Price", "UpdatedAt" },
                values: new object[,]
                {
                    { "2152e859-61ba-44a8-aba6-456b1bdc74ed", null, new DateTime(2023, 1, 9, 14, 46, 18, 450, DateTimeKind.Local).AddTicks(9892), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "https://api.lorem.space/image/watch?w=300&h=500", false, "Unbranded Granite Car", "437.95", new DateTime(2023, 1, 9, 14, 46, 18, 450, DateTimeKind.Local).AddTicks(9896) },
                    { "2a9a4cdb-7586-4860-9040-a1eff814c5b0", null, new DateTime(2023, 1, 9, 14, 46, 18, 451, DateTimeKind.Local).AddTicks(187), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "https://api.lorem.space/image/watch?w=300&h=500", false, "Incredible Frozen Pants", "946.44", new DateTime(2023, 1, 9, 14, 46, 18, 451, DateTimeKind.Local).AddTicks(189) },
                    { "2d944cfe-b59c-4c5c-b218-3c8ad6b7e63c", null, new DateTime(2023, 1, 9, 14, 46, 18, 450, DateTimeKind.Local).AddTicks(9256), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "https://api.lorem.space/image/watch?w=300&h=500", false, "Awesome Fresh Pants", "965.44", new DateTime(2023, 1, 9, 14, 46, 18, 450, DateTimeKind.Local).AddTicks(9261) },
                    { "4b7f74fc-c78d-4920-95ef-16e320c3daa6", null, new DateTime(2023, 1, 9, 14, 46, 18, 451, DateTimeKind.Local).AddTicks(299), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "https://api.lorem.space/image/watch?w=300&h=500", false, "Handmade Cotton Mouse", "558.57", new DateTime(2023, 1, 9, 14, 46, 18, 451, DateTimeKind.Local).AddTicks(301) },
                    { "6d05bd5d-188e-434e-9d55-9c1ac5cba064", null, new DateTime(2023, 1, 9, 14, 46, 18, 450, DateTimeKind.Local).AddTicks(9984), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "https://api.lorem.space/image/watch?w=300&h=500", false, "Tasty Soft Cheese", "538.97", new DateTime(2023, 1, 9, 14, 46, 18, 450, DateTimeKind.Local).AddTicks(9985) },
                    { "7112d9ef-d477-4ad9-980a-b7849f7d9c06", null, new DateTime(2023, 1, 9, 14, 46, 18, 451, DateTimeKind.Local).AddTicks(42), "The Football Is Good For Training And Recreational Purposes", "https://api.lorem.space/image/watch?w=300&h=500", false, "Practical Concrete Fish", "138.79", new DateTime(2023, 1, 9, 14, 46, 18, 451, DateTimeKind.Local).AddTicks(43) },
                    { "8c6937ce-4dd9-48d0-9b38-23ce988a413d", null, new DateTime(2023, 1, 9, 14, 46, 18, 451, DateTimeKind.Local).AddTicks(247), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "https://api.lorem.space/image/watch?w=300&h=500", false, "Rustic Granite Hat", "965.45", new DateTime(2023, 1, 9, 14, 46, 18, 451, DateTimeKind.Local).AddTicks(248) },
                    { "98bf4d40-550a-4210-a68b-497c9234ec95", null, new DateTime(2023, 1, 9, 14, 46, 18, 451, DateTimeKind.Local).AddTicks(473), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "https://api.lorem.space/image/watch?w=300&h=500", false, "Ergonomic Plastic Keyboard", "810.68", new DateTime(2023, 1, 9, 14, 46, 18, 451, DateTimeKind.Local).AddTicks(474) },
                    { "a7d3f1f5-6624-4610-b33f-b0cb6a5c6313", null, new DateTime(2023, 1, 9, 14, 46, 18, 451, DateTimeKind.Local).AddTicks(364), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "https://api.lorem.space/image/watch?w=300&h=500", false, "Sleek Frozen Bacon", "875.24", new DateTime(2023, 1, 9, 14, 46, 18, 451, DateTimeKind.Local).AddTicks(365) },
                    { "d65159df-bbee-4ede-81de-4567b785c1f7", null, new DateTime(2023, 1, 9, 14, 46, 18, 451, DateTimeKind.Local).AddTicks(420), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "https://api.lorem.space/image/watch?w=300&h=500", false, "Intelligent Plastic Bacon", "297.80", new DateTime(2023, 1, 9, 14, 46, 18, 451, DateTimeKind.Local).AddTicks(421) }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "cc3b4c20-7ab3-4daa-b777-0018ee8c615c", "2dfb43f4-24d5-44a7-af3c-78196e881f23" },
                    { "dddd1a59-3b57-45f6-96b5-91b3e269e87c", "75fa9827-0f5f-41db-a825-64d68d242d7e" },
                    { "b600478d-f98b-4a27-aa95-14563920d28f", "df31566d-5ccb-45dc-b1be-864d72133ca4" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true);

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
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_OrderId",
                table: "OrderDetails",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_ProductId",
                table: "OrderDetails",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_UserId",
                table: "Orders",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");
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
                name: "OrderDetails");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
