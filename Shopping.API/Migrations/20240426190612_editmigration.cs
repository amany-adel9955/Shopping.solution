using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Shopping.API.Migrations
{
    /// <inheritdoc />
    public partial class editmigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageURL",
                value: "/Images/Beauty/image1.jpg");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImageURL",
                value: "/Images/Beauty/image2.jpg");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 3,
                column: "ImageURL",
                value: "/Images/Beauty/image3.jpg");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 4,
                column: "ImageURL",
                value: "/Images/Beauty/image4.jpg");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 5,
                column: "ImageURL",
                value: "/Images/Beauty/image5.jpg");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CategoryId", "Description", "ImageURL", "Name", "Price", "Qty" },
                values: new object[] { 1, "Eye meskara, containing skin care and hair care products", "/Images/Beauty/image6.jpg", "Meskara", 30m, 75 });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CategoryId", "Description", "ImageURL", "Name", "Price", "Qty" },
                values: new object[] { 1, "Skin Care Kit, containing skin care and hair care products", "/Images/Beauty/image7.jpg", "Skin Care Kit", 30m, 85 });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CategoryId", "Description", "ImageURL", "Name", "Price", "Qty" },
                values: new object[] { 1, "Skin Care Kit, containing skin care and hair care products", "/Images/Beauty/image8.jpg", "lip gloss", 30m, 85 });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Description", "ImageURL", "Name", "Price", "Qty" },
                values: new object[] { "Air Pods - in-ear wireless headphones", "/Images/Electronics/image1.jpg", "Air Pods", 100m, 120 });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Description", "ImageURL", "Name", "Price", "Qty" },
                values: new object[] { "On-ear Golden Headphones - these headphones are not wireless", "/Images/Electronics/image2.jpg", "On-ear Golden Headphones", 40m, 200 });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Description", "ImageURL", "Name", "Price", "Qty" },
                values: new object[] { "On-ear Black Headphones - these headphones are not wireless", "/Images/Electronics/image3.jpg", "On-ear Black Headphones", 40m, 300 });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CategoryId", "Description", "ImageURL", "Name", "Price", "Qty" },
                values: new object[] { 3, "Sennheiser Digital Camera - High quality digital camera provided by Sennheiser - includes tripod", "/Images/Electronics/image4.jpg", "Sennheiser Digital Camera with Tripod", 600m, 20 });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CategoryId", "Description", "ImageURL", "Name", "Price", "Qty" },
                values: new object[] { 3, "Canon Digital Camera - High quality digital camera provided by Canon", "/Images/Electronics/image5.jpg", "Canon Digital Camera", 500m, 15 });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CategoryId", "Description", "ImageURL", "Name", "Price", "Qty" },
                values: new object[] { 3, "Gameboy - Provided by Nintendo", "/Images/Electronics/image6.jpg", "Nintendo Gameboy", 100m, 60 });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CategoryId", "Description", "ImageURL", "Name", "Price", "Qty" },
                values: new object[] { 3, "Gameboy - Provided by Nintendo", "/Images/Electronics/image7.jpg", "Nintendo Gameboy", 160m, 60 });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CategoryId", "Description", "ImageURL", "Name", "Price", "Qty" },
                values: new object[] { 3, "Gameboy - Provided by Nintendo", "/Images/Electronics/image8.jpg", "Nintendo Gameboy", 500m, 60 });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Description", "ImageURL", "Name", "Price", "Qty" },
                values: new object[] { "Very comfortable black leather office chair", "/Images/Furniture/image1.jpg", "Black Leather Office Chair", 50m, 212 });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CategoryId", "Description", "ImageURL", "Name", "Price", "Qty" },
                values: new object[] { 2, "Very comfortable pink leather office chair", "/Images/Furniture/image2.jpg", "Pink Leather Office Chair", 50m, 112 });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CategoryId", "Description", "ImageURL", "Name", "Price", "Qty" },
                values: new object[] { 2, "Very comfortable lounge chair", "/Images/Furniture/image3.jpg", "Lounge Chair", 70m, 90 });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CategoryId", "Description", "ImageURL", "Name", "Price", "Qty" },
                values: new object[] { 2, "Very comfortable Silver lounge chair", "/Images/Furniture/image4.jpg", "Silver Lounge Chair", 120m, 95 });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CategoryId", "Description", "ImageURL", "Name", "Price", "Qty" },
                values: new object[] { 2, "White and blue Porcelain Table Lamp", "/Images/Furniture/image5.jpg", "Porcelain Table Lamp", 15m, 100 });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CategoryId", "Description", "ImageURL", "Name", "Price", "Qty" },
                values: new object[] { 2, "Office Table Lamp", "/Images/Furniture/image6.jpg", "Office Table Lamp", 20m, 73 });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CategoryId", "Description", "ImageURL", "Name", "Price", "Qty" },
                values: new object[] { 2, "Office Table Lamp", "/Images/Furniture/image7.jpg", "Labtop", 120m, 73 });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "CategoryId", "Description", "ImageURL", "Name", "Price", "Qty" },
                values: new object[,]
                {
                    { 24, 2, "Office Table Lamp", "/Images/Furniture/image8.jpg", "Airpods", 2000m, 13 },
                    { 25, 4, "Comfortable Puma Sneakers in most sizes", "/Images/Shoes/image1.jpg", "Puma Sneakers", 100m, 50 },
                    { 26, 4, "Colorful trainsers - available in most sizes", "/Images/Shoes/image2.jpg", "Colorful Trainers", 150m, 60 },
                    { 27, 4, "Blue Nike Trainers - available in most sizes", "/Images/Shoes/image3.jpg", "Blue Nike Trainers", 200m, 70 },
                    { 28, 4, "Colorful Hummel Trainers - available in most sizes", "/Images/Shoes/image4.jpg", "Colorful Hummel Trainers", 120m, 120 },
                    { 29, 4, "Red Nike Trainers - available in most sizes", "/Images/Shoes/image5.jpg", "Red Nike Trainers", 200m, 100 },
                    { 30, 4, "Birkenstock Sandles - available in most sizes", "/Images/Shoes/image6.jpg", "Birkenstock Sandles", 50m, 150 },
                    { 31, 4, "Birkenstock Sandles - available in most sizes", "/Images/Shoes/image7.jpg", "Sneakers", 150m, 50 },
                    { 32, 4, "Birkenstock Sandles - available in most sizes", "/Images/Shoes/image8.jpg", "Sandles", 500m, 50 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageURL",
                value: "/Images/Beauty/Beauty1.png");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImageURL",
                value: "/Images/Beauty/Beauty2.png");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 3,
                column: "ImageURL",
                value: "/Images/Beauty/Beauty3.png");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 4,
                column: "ImageURL",
                value: "/Images/Beauty/Beauty4.png");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 5,
                column: "ImageURL",
                value: "/Images/Beauty/Beauty5.png");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CategoryId", "Description", "ImageURL", "Name", "Price", "Qty" },
                values: new object[] { 3, "Air Pods - in-ear wireless headphones", "/Images/Electronic/Electronics1.png", "Air Pods", 100m, 120 });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CategoryId", "Description", "ImageURL", "Name", "Price", "Qty" },
                values: new object[] { 3, "On-ear Golden Headphones - these headphones are not wireless", "/Images/Electronic/Electronics2.png", "On-ear Golden Headphones", 40m, 200 });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CategoryId", "Description", "ImageURL", "Name", "Price", "Qty" },
                values: new object[] { 3, "On-ear Black Headphones - these headphones are not wireless", "/Images/Electronic/Electronics3.png", "On-ear Black Headphones", 40m, 300 });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Description", "ImageURL", "Name", "Price", "Qty" },
                values: new object[] { "Sennheiser Digital Camera - High quality digital camera provided by Sennheiser - includes tripod", "/Images/Electronic/Electronic4.png", "Sennheiser Digital Camera with Tripod", 600m, 20 });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Description", "ImageURL", "Name", "Price", "Qty" },
                values: new object[] { "Canon Digital Camera - High quality digital camera provided by Canon", "/Images/Electronic/Electronic5.png", "Canon Digital Camera", 500m, 15 });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Description", "ImageURL", "Name", "Price", "Qty" },
                values: new object[] { "Gameboy - Provided by Nintendo", "/Images/Electronic/technology6.png", "Nintendo Gameboy", 100m, 60 });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CategoryId", "Description", "ImageURL", "Name", "Price", "Qty" },
                values: new object[] { 2, "Very comfortable black leather office chair", "/Images/Furniture/Furniture1.png", "Black Leather Office Chair", 50m, 212 });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CategoryId", "Description", "ImageURL", "Name", "Price", "Qty" },
                values: new object[] { 2, "Very comfortable pink leather office chair", "/Images/Furniture/Furniture2.png", "Pink Leather Office Chair", 50m, 112 });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CategoryId", "Description", "ImageURL", "Name", "Price", "Qty" },
                values: new object[] { 2, "Very comfortable lounge chair", "/Images/Furniture/Furniture3.png", "Lounge Chair", 70m, 90 });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CategoryId", "Description", "ImageURL", "Name", "Price", "Qty" },
                values: new object[] { 2, "Very comfortable Silver lounge chair", "/Images/Furniture/Furniture4.png", "Silver Lounge Chair", 120m, 95 });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CategoryId", "Description", "ImageURL", "Name", "Price", "Qty" },
                values: new object[] { 2, "White and blue Porcelain Table Lamp", "/Images/Furniture/Furniture6.png", "Porcelain Table Lamp", 15m, 100 });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Description", "ImageURL", "Name", "Price", "Qty" },
                values: new object[] { "Office Table Lamp", "/Images/Furniture/Furniture7.png", "Office Table Lamp", 20m, 73 });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CategoryId", "Description", "ImageURL", "Name", "Price", "Qty" },
                values: new object[] { 4, "Comfortable Puma Sneakers in most sizes", "/Images/Shoes/Shoes1.png", "Puma Sneakers", 100m, 50 });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CategoryId", "Description", "ImageURL", "Name", "Price", "Qty" },
                values: new object[] { 4, "Colorful trainsers - available in most sizes", "/Images/Shoes/Shoes2.png", "Colorful Trainers", 150m, 60 });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CategoryId", "Description", "ImageURL", "Name", "Price", "Qty" },
                values: new object[] { 4, "Blue Nike Trainers - available in most sizes", "/Images/Shoes/Shoes3.png", "Blue Nike Trainers", 200m, 70 });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CategoryId", "Description", "ImageURL", "Name", "Price", "Qty" },
                values: new object[] { 4, "Colorful Hummel Trainers - available in most sizes", "/Images/Shoes/Shoes4.png", "Colorful Hummel Trainers", 120m, 120 });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CategoryId", "Description", "ImageURL", "Name", "Price", "Qty" },
                values: new object[] { 4, "Red Nike Trainers - available in most sizes", "/Images/Shoes/Shoes5.png", "Red Nike Trainers", 200m, 100 });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CategoryId", "Description", "ImageURL", "Name", "Price", "Qty" },
                values: new object[] { 4, "Birkenstock Sandles - available in most sizes", "/Images/Shoes/Shoes6.png", "Birkenstock Sandles", 50m, 150 });
        }
    }
}
