using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Ecommerce.Migrations
{
    /// <inheritdoc />
    public partial class init2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "14ff024d-5bb7-4ac9-8c45-a02a9c3ab87d");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "1aed7183-3c10-4cfc-9278-9e894d92860e");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "20d9d32a-a410-46fe-a999-7ba96f176d7e");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "2e3a5d34-df97-4510-8753-9ee23a21fdc1");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "819c3b1a-9132-491e-bc76-c96a1a861a24");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "82a6b2f2-bfad-4db4-bdde-1cd52e52eede");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "bfe502d6-2730-4cb5-9204-950b3dbe2d13");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "c03da159-e6b4-46e9-a9dd-3c7dbfe62a16");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "d9865550-b080-4423-9cbf-a87753ecfdcd");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "f9f18638-8755-4c6d-aa69-49c209d83d2e");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "2152e859-61ba-44a8-aba6-456b1bdc74ed");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "2a9a4cdb-7586-4860-9040-a1eff814c5b0");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "2d944cfe-b59c-4c5c-b218-3c8ad6b7e63c");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "4b7f74fc-c78d-4920-95ef-16e320c3daa6");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "6d05bd5d-188e-434e-9d55-9c1ac5cba064");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "7112d9ef-d477-4ad9-980a-b7849f7d9c06");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "8c6937ce-4dd9-48d0-9b38-23ce988a413d");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "98bf4d40-550a-4210-a68b-497c9234ec95");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "a7d3f1f5-6624-4610-b33f-b0cb6a5c6313");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "d65159df-bbee-4ede-81de-4567b785c1f7");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b600478d-f98b-4a27-aa95-14563920d28f",
                column: "ConcurrencyStamp",
                value: "73e1d362-a412-456e-ae52-a5b3ac327ea6");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cc3b4c20-7ab3-4daa-b777-0018ee8c615c",
                column: "ConcurrencyStamp",
                value: "c5f98f25-5d07-4355-8396-f8c9f48f6376");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "dddd1a59-3b57-45f6-96b5-91b3e269e87c",
                column: "ConcurrencyStamp",
                value: "aa1e6e56-2beb-4fc7-917b-a11506d0053c");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2dfb43f4-24d5-44a7-af3c-78196e881f23",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "7a567766-a259-4e53-a45c-4a0cf8d03b2c", "f56a0d18-614f-447c-b626-5ba77e1e1328" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "75fa9827-0f5f-41db-a825-64d68d242d7e",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "ac861b15-1fad-469f-9a4d-e6c3a8c5a6bd", "c5deda69-b5d5-443d-b0d1-6e652b68e3c4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "df31566d-5ccb-45dc-b1be-864d72133ca4",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "7d77690c-9136-43c8-b61d-3675db5a5c46", "8c7ee562-d1ad-47c0-b8e3-d798b8a437a7" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedAt", "IsDeleted", "Name", "UpdatedAt" },
                values: new object[,]
                {
                    { "0b9243d5-91fd-44d8-ad2d-e9e0a78c0f58", new DateTime(2023, 1, 9, 15, 28, 54, 307, DateTimeKind.Local).AddTicks(8451), false, "Forward Creative Strategist", new DateTime(2023, 1, 9, 15, 28, 54, 307, DateTimeKind.Local).AddTicks(8453) },
                    { "3bc5b522-df9d-4bf3-87f8-7dad26218727", new DateTime(2023, 1, 9, 15, 28, 54, 307, DateTimeKind.Local).AddTicks(8526), false, "Central Paradigm Liaison", new DateTime(2023, 1, 9, 15, 28, 54, 307, DateTimeKind.Local).AddTicks(8528) },
                    { "3fd3ea05-4a78-408d-8003-9231b685c199", new DateTime(2023, 1, 9, 15, 28, 54, 307, DateTimeKind.Local).AddTicks(8492), false, "National Security Associate", new DateTime(2023, 1, 9, 15, 28, 54, 307, DateTimeKind.Local).AddTicks(8494) },
                    { "48d79c0a-6359-4f35-b9fd-9b73b476d731", new DateTime(2023, 1, 9, 15, 28, 54, 307, DateTimeKind.Local).AddTicks(8310), false, "Global Functionality Coordinator", new DateTime(2023, 1, 9, 15, 28, 54, 307, DateTimeKind.Local).AddTicks(8313) },
                    { "66451abf-94ed-46db-8ae5-1d3d9c2b1399", new DateTime(2023, 1, 9, 15, 28, 54, 307, DateTimeKind.Local).AddTicks(8674), false, "Forward Integration Architect", new DateTime(2023, 1, 9, 15, 28, 54, 307, DateTimeKind.Local).AddTicks(8676) },
                    { "9407dddb-fde7-4ef8-8438-4273d75e1e2a", new DateTime(2023, 1, 9, 15, 28, 54, 307, DateTimeKind.Local).AddTicks(8416), false, "Lead Solutions Administrator", new DateTime(2023, 1, 9, 15, 28, 54, 307, DateTimeKind.Local).AddTicks(8417) },
                    { "9c20562a-b8a6-4a8b-888f-29ca9348c6c6", new DateTime(2023, 1, 9, 15, 28, 54, 307, DateTimeKind.Local).AddTicks(8378), false, "Customer Assurance Manager", new DateTime(2023, 1, 9, 15, 28, 54, 307, DateTimeKind.Local).AddTicks(8380) },
                    { "c8b27ece-6fdc-4c40-9e92-33143ddeccd1", new DateTime(2023, 1, 9, 15, 28, 54, 307, DateTimeKind.Local).AddTicks(8726), false, "Global Usability Coordinator", new DateTime(2023, 1, 9, 15, 28, 54, 307, DateTimeKind.Local).AddTicks(8727) },
                    { "d8848735-5dc6-4487-bbc0-0b2c05e4ec15", new DateTime(2023, 1, 9, 15, 28, 54, 307, DateTimeKind.Local).AddTicks(8559), false, "Human Data Designer", new DateTime(2023, 1, 9, 15, 28, 54, 307, DateTimeKind.Local).AddTicks(8560) },
                    { "d9a18e19-75ea-4814-8f75-538e08d578f8", new DateTime(2023, 1, 9, 15, 28, 54, 307, DateTimeKind.Local).AddTicks(7773), false, "Chief Usability Supervisor", new DateTime(2023, 1, 9, 15, 28, 54, 307, DateTimeKind.Local).AddTicks(7789) }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "CreatedAt", "Description", "Image", "IsDeleted", "Name", "Price", "UpdatedAt" },
                values: new object[,]
                {
                    { "0c293b76-7ca2-48d4-a93c-cc03e0173f25", "3fd3ea05-4a78-408d-8003-9231b685c199", new DateTime(2023, 1, 9, 15, 28, 54, 310, DateTimeKind.Local).AddTicks(6480), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "https://api.lorem.space/image/watch?w=300&h=500", false, "Unbranded Concrete Computer", "341.78", new DateTime(2023, 1, 9, 15, 28, 54, 310, DateTimeKind.Local).AddTicks(6481) },
                    { "19b6b6d9-6311-468f-ba2f-86701d79279c", "d8848735-5dc6-4487-bbc0-0b2c05e4ec15", new DateTime(2023, 1, 9, 15, 28, 54, 310, DateTimeKind.Local).AddTicks(6711), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "https://api.lorem.space/image/watch?w=300&h=500", false, "Rustic Steel Bike", "995.63", new DateTime(2023, 1, 9, 15, 28, 54, 310, DateTimeKind.Local).AddTicks(6713) },
                    { "1d34c40e-6081-4350-bc4a-b39edc7450a3", "66451abf-94ed-46db-8ae5-1d3d9c2b1399", new DateTime(2023, 1, 9, 15, 28, 54, 310, DateTimeKind.Local).AddTicks(7334), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "https://api.lorem.space/image/watch?w=300&h=500", false, "Generic Plastic Table", "806.47", new DateTime(2023, 1, 9, 15, 28, 54, 310, DateTimeKind.Local).AddTicks(7336) },
                    { "220338ad-4ba7-467e-a639-093d4990de65", "c8b27ece-6fdc-4c40-9e92-33143ddeccd1", new DateTime(2023, 1, 9, 15, 28, 54, 310, DateTimeKind.Local).AddTicks(7915), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "https://api.lorem.space/image/watch?w=300&h=500", false, "Practical Fresh Computer", "51.51", new DateTime(2023, 1, 9, 15, 28, 54, 310, DateTimeKind.Local).AddTicks(7917) },
                    { "23429186-8a04-4780-be4c-a5144ae480d8", "d8848735-5dc6-4487-bbc0-0b2c05e4ec15", new DateTime(2023, 1, 9, 15, 28, 54, 310, DateTimeKind.Local).AddTicks(7404), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "https://api.lorem.space/image/watch?w=300&h=500", false, "Sleek Granite Keyboard", "505.18", new DateTime(2023, 1, 9, 15, 28, 54, 310, DateTimeKind.Local).AddTicks(7406) },
                    { "331aacca-0227-443b-abfa-f8a971fb73e2", "3bc5b522-df9d-4bf3-87f8-7dad26218727", new DateTime(2023, 1, 9, 15, 28, 54, 310, DateTimeKind.Local).AddTicks(7098), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "https://api.lorem.space/image/watch?w=300&h=500", false, "Ergonomic Soft Bacon", "133.29", new DateTime(2023, 1, 9, 15, 28, 54, 310, DateTimeKind.Local).AddTicks(7100) },
                    { "34e67687-dae7-4ef0-b20d-8999d7b6004e", "9c20562a-b8a6-4a8b-888f-29ca9348c6c6", new DateTime(2023, 1, 9, 15, 28, 54, 310, DateTimeKind.Local).AddTicks(6350), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "https://api.lorem.space/image/watch?w=300&h=500", false, "Tasty Plastic Shoes", "962.04", new DateTime(2023, 1, 9, 15, 28, 54, 310, DateTimeKind.Local).AddTicks(6352) },
                    { "3b11571f-0172-42a8-84d3-ce08c5627b48", "48d79c0a-6359-4f35-b9fd-9b73b476d731", new DateTime(2023, 1, 9, 15, 28, 54, 310, DateTimeKind.Local).AddTicks(8075), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "https://api.lorem.space/image/watch?w=300&h=500", false, "Small Granite Keyboard", "360.36", new DateTime(2023, 1, 9, 15, 28, 54, 310, DateTimeKind.Local).AddTicks(8077) },
                    { "4a3ce1a0-5ddd-4f95-a23a-3c18fc3dfc5b", "d9a18e19-75ea-4814-8f75-538e08d578f8", new DateTime(2023, 1, 9, 15, 28, 54, 310, DateTimeKind.Local).AddTicks(7205), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "https://api.lorem.space/image/watch?w=300&h=500", false, "Intelligent Metal Computer", "641.64", new DateTime(2023, 1, 9, 15, 28, 54, 310, DateTimeKind.Local).AddTicks(7207) },
                    { "51b13a08-2e8c-4bc8-a740-ded54a03bd0b", "0b9243d5-91fd-44d8-ad2d-e9e0a78c0f58", new DateTime(2023, 1, 9, 15, 28, 54, 310, DateTimeKind.Local).AddTicks(7676), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "https://api.lorem.space/image/watch?w=300&h=500", false, "Handcrafted Metal Bike", "150.92", new DateTime(2023, 1, 9, 15, 28, 54, 310, DateTimeKind.Local).AddTicks(7677) },
                    { "54a27b8a-a177-4a4d-a596-dd0af70a6ea5", "3fd3ea05-4a78-408d-8003-9231b685c199", new DateTime(2023, 1, 9, 15, 28, 54, 310, DateTimeKind.Local).AddTicks(7567), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "https://api.lorem.space/image/watch?w=300&h=500", false, "Handmade Plastic Mouse", "738.08", new DateTime(2023, 1, 9, 15, 28, 54, 310, DateTimeKind.Local).AddTicks(7569) },
                    { "5cfbae9e-0bb6-43c4-b363-d6d9ff20abfa", "3bc5b522-df9d-4bf3-87f8-7dad26218727", new DateTime(2023, 1, 9, 15, 28, 54, 310, DateTimeKind.Local).AddTicks(6987), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "https://api.lorem.space/image/watch?w=300&h=500", false, "Unbranded Steel Computer", "786.54", new DateTime(2023, 1, 9, 15, 28, 54, 310, DateTimeKind.Local).AddTicks(6988) },
                    { "633fbf44-cdf1-4845-9616-9e2477e5acf7", "9c20562a-b8a6-4a8b-888f-29ca9348c6c6", new DateTime(2023, 1, 9, 15, 28, 54, 310, DateTimeKind.Local).AddTicks(6420), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "https://api.lorem.space/image/watch?w=300&h=500", false, "Ergonomic Concrete Table", "157.86", new DateTime(2023, 1, 9, 15, 28, 54, 310, DateTimeKind.Local).AddTicks(6422) },
                    { "6e85b197-1d38-4fc8-874b-fdfa96fe7590", "c8b27ece-6fdc-4c40-9e92-33143ddeccd1", new DateTime(2023, 1, 9, 15, 28, 54, 310, DateTimeKind.Local).AddTicks(7515), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "https://api.lorem.space/image/watch?w=300&h=500", false, "Refined Metal Computer", "183.78", new DateTime(2023, 1, 9, 15, 28, 54, 310, DateTimeKind.Local).AddTicks(7517) },
                    { "729df707-b921-49dc-a49c-b884d2438182", "3bc5b522-df9d-4bf3-87f8-7dad26218727", new DateTime(2023, 1, 9, 15, 28, 54, 310, DateTimeKind.Local).AddTicks(8022), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "https://api.lorem.space/image/watch?w=300&h=500", false, "Handcrafted Fresh Sausages", "688.22", new DateTime(2023, 1, 9, 15, 28, 54, 310, DateTimeKind.Local).AddTicks(8024) },
                    { "7405a603-ba19-4122-8189-98bc3d3a9401", "d9a18e19-75ea-4814-8f75-538e08d578f8", new DateTime(2023, 1, 9, 15, 28, 54, 310, DateTimeKind.Local).AddTicks(6931), "The Football Is Good For Training And Recreational Purposes", "https://api.lorem.space/image/watch?w=300&h=500", false, "Practical Rubber Computer", "391.05", new DateTime(2023, 1, 9, 15, 28, 54, 310, DateTimeKind.Local).AddTicks(6932) },
                    { "7423fa7c-425c-4b9b-bd04-11fddfe7c3ef", "9c20562a-b8a6-4a8b-888f-29ca9348c6c6", new DateTime(2023, 1, 9, 15, 28, 54, 310, DateTimeKind.Local).AddTicks(6540), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "https://api.lorem.space/image/watch?w=300&h=500", false, "Gorgeous Soft Gloves", "587.41", new DateTime(2023, 1, 9, 15, 28, 54, 310, DateTimeKind.Local).AddTicks(6542) },
                    { "784b7d0c-127c-4f2b-aaba-533d7f4832f1", "9407dddb-fde7-4ef8-8438-4273d75e1e2a", new DateTime(2023, 1, 9, 15, 28, 54, 310, DateTimeKind.Local).AddTicks(8129), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "https://api.lorem.space/image/watch?w=300&h=500", false, "Tasty Cotton Fish", "229.11", new DateTime(2023, 1, 9, 15, 28, 54, 310, DateTimeKind.Local).AddTicks(8130) },
                    { "9f0d96a3-b63c-46be-8df9-4d00d6f04b4a", "c8b27ece-6fdc-4c40-9e92-33143ddeccd1", new DateTime(2023, 1, 9, 15, 28, 54, 310, DateTimeKind.Local).AddTicks(7461), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "https://api.lorem.space/image/watch?w=300&h=500", false, "Incredible Frozen Keyboard", "563.61", new DateTime(2023, 1, 9, 15, 28, 54, 310, DateTimeKind.Local).AddTicks(7463) },
                    { "a1f721c0-111b-45fe-b94d-21c9398599db", "9c20562a-b8a6-4a8b-888f-29ca9348c6c6", new DateTime(2023, 1, 9, 15, 28, 54, 310, DateTimeKind.Local).AddTicks(7729), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "https://api.lorem.space/image/watch?w=300&h=500", false, "Generic Metal Hat", "205.87", new DateTime(2023, 1, 9, 15, 28, 54, 310, DateTimeKind.Local).AddTicks(7731) },
                    { "afdc29a1-a637-4651-b5b7-12b4e013b0ec", "3fd3ea05-4a78-408d-8003-9231b685c199", new DateTime(2023, 1, 9, 15, 28, 54, 310, DateTimeKind.Local).AddTicks(6871), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "https://api.lorem.space/image/watch?w=300&h=500", false, "Gorgeous Metal Keyboard", "325.59", new DateTime(2023, 1, 9, 15, 28, 54, 310, DateTimeKind.Local).AddTicks(6873) },
                    { "b00dfd57-3880-4bbd-8ef2-80ae57e8a2c0", "c8b27ece-6fdc-4c40-9e92-33143ddeccd1", new DateTime(2023, 1, 9, 15, 28, 54, 310, DateTimeKind.Local).AddTicks(8181), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "https://api.lorem.space/image/watch?w=300&h=500", false, "Refined Plastic Mouse", "511.62", new DateTime(2023, 1, 9, 15, 28, 54, 310, DateTimeKind.Local).AddTicks(8183) },
                    { "b20f4dc4-7c33-4f41-b455-5402a547755b", "d9a18e19-75ea-4814-8f75-538e08d578f8", new DateTime(2023, 1, 9, 15, 28, 54, 310, DateTimeKind.Local).AddTicks(6243), "The Football Is Good For Training And Recreational Purposes", "https://api.lorem.space/image/watch?w=300&h=500", false, "Ergonomic Wooden Pizza", "747.02", new DateTime(2023, 1, 9, 15, 28, 54, 310, DateTimeKind.Local).AddTicks(6247) },
                    { "b39696db-2a62-4122-9982-c3685a6e0552", "0b9243d5-91fd-44d8-ad2d-e9e0a78c0f58", new DateTime(2023, 1, 9, 15, 28, 54, 310, DateTimeKind.Local).AddTicks(7787), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "https://api.lorem.space/image/watch?w=300&h=500", false, "Generic Frozen Mouse", "813.07", new DateTime(2023, 1, 9, 15, 28, 54, 310, DateTimeKind.Local).AddTicks(7789) },
                    { "b9886181-40fc-48f5-90b5-f55dab6ab401", "d9a18e19-75ea-4814-8f75-538e08d578f8", new DateTime(2023, 1, 9, 15, 28, 54, 310, DateTimeKind.Local).AddTicks(7622), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "https://api.lorem.space/image/watch?w=300&h=500", false, "Sleek Rubber Salad", "440.05", new DateTime(2023, 1, 9, 15, 28, 54, 310, DateTimeKind.Local).AddTicks(7623) },
                    { "c9264787-a1e3-483e-b390-8c52d01d5aac", "66451abf-94ed-46db-8ae5-1d3d9c2b1399", new DateTime(2023, 1, 9, 15, 28, 54, 310, DateTimeKind.Local).AddTicks(7970), "The Football Is Good For Training And Recreational Purposes", "https://api.lorem.space/image/watch?w=300&h=500", false, "Unbranded Granite Sausages", "27.53", new DateTime(2023, 1, 9, 15, 28, 54, 310, DateTimeKind.Local).AddTicks(7972) },
                    { "e87c2a15-821d-4a6d-8e0b-a3d15fe7486d", "c8b27ece-6fdc-4c40-9e92-33143ddeccd1", new DateTime(2023, 1, 9, 15, 28, 54, 310, DateTimeKind.Local).AddTicks(6807), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "https://api.lorem.space/image/watch?w=300&h=500", false, "Generic Wooden Ball", "879.56", new DateTime(2023, 1, 9, 15, 28, 54, 310, DateTimeKind.Local).AddTicks(6809) },
                    { "f69f9548-4119-4cba-84a0-29800bd9b89c", "9407dddb-fde7-4ef8-8438-4273d75e1e2a", new DateTime(2023, 1, 9, 15, 28, 54, 310, DateTimeKind.Local).AddTicks(7042), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "https://api.lorem.space/image/watch?w=300&h=500", false, "Refined Steel Sausages", "349.24", new DateTime(2023, 1, 9, 15, 28, 54, 310, DateTimeKind.Local).AddTicks(7043) },
                    { "f94fc42e-df05-4612-b851-3dd067ebbea7", "d8848735-5dc6-4487-bbc0-0b2c05e4ec15", new DateTime(2023, 1, 9, 15, 28, 54, 310, DateTimeKind.Local).AddTicks(5262), "The Football Is Good For Training And Recreational Purposes", "https://api.lorem.space/image/watch?w=300&h=500", false, "Intelligent Fresh Bacon", "841.88", new DateTime(2023, 1, 9, 15, 28, 54, 310, DateTimeKind.Local).AddTicks(5268) },
                    { "fb57778d-0b60-4b2c-937a-397c4268817a", "3bc5b522-df9d-4bf3-87f8-7dad26218727", new DateTime(2023, 1, 9, 15, 28, 54, 310, DateTimeKind.Local).AddTicks(7151), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "https://api.lorem.space/image/watch?w=300&h=500", false, "Ergonomic Granite Chair", "303.76", new DateTime(2023, 1, 9, 15, 28, 54, 310, DateTimeKind.Local).AddTicks(7153) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "0c293b76-7ca2-48d4-a93c-cc03e0173f25");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "19b6b6d9-6311-468f-ba2f-86701d79279c");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "1d34c40e-6081-4350-bc4a-b39edc7450a3");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "220338ad-4ba7-467e-a639-093d4990de65");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "23429186-8a04-4780-be4c-a5144ae480d8");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "331aacca-0227-443b-abfa-f8a971fb73e2");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "34e67687-dae7-4ef0-b20d-8999d7b6004e");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "3b11571f-0172-42a8-84d3-ce08c5627b48");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "4a3ce1a0-5ddd-4f95-a23a-3c18fc3dfc5b");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "51b13a08-2e8c-4bc8-a740-ded54a03bd0b");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "54a27b8a-a177-4a4d-a596-dd0af70a6ea5");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "5cfbae9e-0bb6-43c4-b363-d6d9ff20abfa");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "633fbf44-cdf1-4845-9616-9e2477e5acf7");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "6e85b197-1d38-4fc8-874b-fdfa96fe7590");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "729df707-b921-49dc-a49c-b884d2438182");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "7405a603-ba19-4122-8189-98bc3d3a9401");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "7423fa7c-425c-4b9b-bd04-11fddfe7c3ef");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "784b7d0c-127c-4f2b-aaba-533d7f4832f1");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "9f0d96a3-b63c-46be-8df9-4d00d6f04b4a");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "a1f721c0-111b-45fe-b94d-21c9398599db");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "afdc29a1-a637-4651-b5b7-12b4e013b0ec");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "b00dfd57-3880-4bbd-8ef2-80ae57e8a2c0");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "b20f4dc4-7c33-4f41-b455-5402a547755b");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "b39696db-2a62-4122-9982-c3685a6e0552");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "b9886181-40fc-48f5-90b5-f55dab6ab401");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "c9264787-a1e3-483e-b390-8c52d01d5aac");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "e87c2a15-821d-4a6d-8e0b-a3d15fe7486d");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "f69f9548-4119-4cba-84a0-29800bd9b89c");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "f94fc42e-df05-4612-b851-3dd067ebbea7");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "fb57778d-0b60-4b2c-937a-397c4268817a");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "0b9243d5-91fd-44d8-ad2d-e9e0a78c0f58");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "3bc5b522-df9d-4bf3-87f8-7dad26218727");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "3fd3ea05-4a78-408d-8003-9231b685c199");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "48d79c0a-6359-4f35-b9fd-9b73b476d731");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "66451abf-94ed-46db-8ae5-1d3d9c2b1399");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "9407dddb-fde7-4ef8-8438-4273d75e1e2a");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "9c20562a-b8a6-4a8b-888f-29ca9348c6c6");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "c8b27ece-6fdc-4c40-9e92-33143ddeccd1");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "d8848735-5dc6-4487-bbc0-0b2c05e4ec15");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "d9a18e19-75ea-4814-8f75-538e08d578f8");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b600478d-f98b-4a27-aa95-14563920d28f",
                column: "ConcurrencyStamp",
                value: "38e2ea85-58e1-42a6-b02f-6cd12914e0e7");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cc3b4c20-7ab3-4daa-b777-0018ee8c615c",
                column: "ConcurrencyStamp",
                value: "4321c8ff-bf08-4004-98a3-174be3a19438");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "dddd1a59-3b57-45f6-96b5-91b3e269e87c",
                column: "ConcurrencyStamp",
                value: "e995e4ab-292a-45c0-9b73-f8e04694f3b0");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2dfb43f4-24d5-44a7-af3c-78196e881f23",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "db2c5dce-4232-4e03-8527-8729c2029d2e", "d42a5b15-7e80-46f8-873b-095b2b247bc7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "75fa9827-0f5f-41db-a825-64d68d242d7e",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "88a92330-8f73-4fbb-916b-aec1e1b187cc", "04a418df-9916-44d0-b5dc-2b6dade7b722" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "df31566d-5ccb-45dc-b1be-864d72133ca4",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "1e5b817f-00a6-41ce-b82e-31744e251e18", "530bd96f-443e-46ce-883a-79f505422d11" });

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
        }
    }
}
