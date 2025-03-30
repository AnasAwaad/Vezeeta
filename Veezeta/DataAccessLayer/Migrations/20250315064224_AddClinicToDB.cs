using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class AddClinicToDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "clinics",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_clinics", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "clinics",
                columns: new[] { "Id", "Location", "Name" },
                values: new object[,]
                {
                    { 1, "New York, NY", "Sunrise Health Clinic" },
                    { 2, "Los Angeles, CA", "Greenwood Family Clinic" },
                    { 3, "Chicago, IL", "Wellness Care Center" },
                    { 4, "Houston, TX", "Downtown Medical" },
                    { 5, "Phoenix, AZ", "CarePlus Clinic" },
                    { 6, "Philadelphia, PA", "Healthy Life Clinic" },
                    { 7, "San Antonio, TX", "Pine Tree Health" },
                    { 8, "San Diego, CA", "Evergreen Medical" },
                    { 9, "Dallas, TX", "Community Care Center" },
                    { 10, "San Jose, CA", "Healing Hands Clinic" },
                    { 11, "Austin, TX", "Maple Leaf Clinic" },
                    { 12, "Jacksonville, FL", "Sunflower Family Practice" },
                    { 13, "San Francisco, CA", "Oakwood Health Services" },
                    { 14, "Columbus, OH", "Blue Ridge Medical" },
                    { 15, "Fort Worth, TX", "Riverfront Healthcare" },
                    { 16, "Charlotte, NC", "Hopewell Medical Center" },
                    { 17, "Indianapolis, IN", "Summit Medical Group" },
                    { 18, "Seattle, WA", "Horizon Health" },
                    { 19, "Denver, CO", "Willow Creek Clinic" },
                    { 20, "Boston, MA", "Silver Lake Health" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "clinics");
        }
    }
}
