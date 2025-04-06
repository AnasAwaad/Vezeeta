using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Vezeeta.DAL.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clinics",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clinics", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Doctors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Specailized = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SelectedTimeSlots = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ClinicID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Doctors", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Doctors_Clinics_ClinicID",
                        column: x => x.ClinicID,
                        principalTable: "Clinics",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TimeSlots",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DoctorId = table.Column<int>(type: "int", nullable: false),
                    Avaiable = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TimeSlots", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TimeSlots_Doctors_DoctorId",
                        column: x => x.DoctorId,
                        principalTable: "Doctors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Clinics",
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

            migrationBuilder.InsertData(
                table: "Doctors",
                columns: new[] { "Id", "ClinicID", "Description", "ImageUrl", "Name", "Price", "SelectedTimeSlots", "Specailized" },
                values: new object[,]
                {
                    { 1, 1, "Expert in Cardiology.\nProvides top-notch care.", "", "Dr. James Jackson", 150.0, "1,21", "Cardiology" },
                    { 2, 2, "Expert in Dermatology.\nProvides top-notch care.", "", "Dr. Michael Brown", 120.0, "2,22", "Dermatology" },
                    { 3, 3, "Expert in Neurology.\nProvides top-notch care.", "", "Dr. Richard Harris", 180.0, "3,23", "Neurology" },
                    { 4, 4, "Expert in Pediatrics.\nProvides top-notch care.", "", "Dr. Thomas Hall", 110.0, "4,24", "Pediatrics" },
                    { 5, 5, "Expert in Orthopedics.\nProvides top-notch care.", "", "Dr. Linda Martinez", 200.0, "5,25", "Orthopedics" },
                    { 6, 6, "Expert in Gynecology.\nProvides top-notch care.", "", "Dr. Linda Martinez", 130.0, "6,26", "Gynecology" },
                    { 7, 7, "Expert in General Medicine.\nProvides top-notch care.", "", "Dr. Sarah Davis", 100.0, "7,27", "General Medicine" },
                    { 8, 8, "Expert in ENT.\nProvides top-notch care.", "", "Dr. Michael Brown", 140.0, "8,28", "ENT" },
                    { 9, 9, "Expert in Urology.\nProvides top-notch care.", "", "Dr. Robert Anderson", 160.0, "9,29", "Urology" },
                    { 10, 10, "Expert in Gastroenterology.\nProvides top-notch care.", "", "Dr. Emily Johnson", 170.0, "10,30", "Gastroenterology" },
                    { 11, 11, "Expert in Oncology.\nProvides top-notch care.", "", "Dr. Thomas Hall", 220.0, "11,31", "Oncology" },
                    { 12, 12, "Expert in Psychiatry.\nProvides top-notch care.", "", "Dr. John Smith", 130.0, "12,32", "Psychiatry" },
                    { 13, 13, "Expert in Nephrology.\nProvides top-notch care.", "", "Dr. Susan Clark", 190.0, "13,33", "Nephrology" },
                    { 14, 14, "Expert in Endocrinology.\nProvides top-notch care.", "", "Dr. Karen Allen", 140.0, "14,34", "Endocrinology" },
                    { 15, 15, "Expert in Radiology.\nProvides top-notch care.", "", "Dr. Richard Harris", 180.0, "15,35", "Radiology" },
                    { 16, 16, "Expert in Rheumatology.\nProvides top-notch care.", "", "Dr. Thomas Hall", 160.0, "16,36", "Rheumatology" },
                    { 17, 17, "Expert in Plastic Surgery.\nProvides top-notch care.", "", "Dr. James Jackson", 250.0, "17,37", "Plastic Surgery" },
                    { 18, 18, "Expert in Pulmonology.\nProvides top-notch care.", "", "Dr. Barbara White", 170.0, "18,38", "Pulmonology" },
                    { 19, 19, "Expert in Hematology.\nProvides top-notch care.", "", "Dr. Linda Martinez", 200.0, "19,39", "Hematology" },
                    { 20, 20, "Expert in Ophthalmology.\nProvides top-notch care.", "", "Dr. Paul Wright", 150.0, "20,40", "Ophthalmology" }
                });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "Id", "Avaiable", "Date", "DoctorId" },
                values: new object[,]
                {
                    { 1, true, "2025-03-01", 1 },
                    { 2, true, "2025-03-02", 2 },
                    { 3, true, "2025-03-03", 3 },
                    { 4, true, "2025-03-04", 4 },
                    { 5, true, "2025-03-05", 5 },
                    { 6, true, "2025-03-06", 6 },
                    { 7, true, "2025-03-07", 7 },
                    { 8, true, "2025-03-08", 8 },
                    { 9, true, "2025-03-09", 9 },
                    { 10, true, "2025-03-10", 10 },
                    { 11, true, "2025-03-11", 11 },
                    { 12, true, "2025-03-12", 12 },
                    { 13, true, "2025-03-13", 13 },
                    { 14, true, "2025-03-14", 14 },
                    { 15, true, "2025-03-15", 15 },
                    { 16, true, "2025-03-16", 16 },
                    { 17, true, "2025-03-17", 17 },
                    { 18, true, "2025-03-18", 18 },
                    { 19, true, "2025-03-19", 19 },
                    { 20, true, "2025-03-20", 20 },
                    { 21, true, "2025-03-21", 1 },
                    { 22, true, "2025-03-22", 2 },
                    { 23, true, "2025-03-23", 3 },
                    { 24, true, "2025-03-24", 4 },
                    { 25, true, "2025-03-25", 5 },
                    { 26, true, "2025-03-26", 6 },
                    { 27, true, "2025-03-27", 7 },
                    { 28, true, "2025-03-28", 8 },
                    { 29, true, "2025-03-29", 9 },
                    { 30, true, "2025-03-30", 10 },
                    { 31, true, "2025-03-31", 11 },
                    { 32, true, "2025-03-01", 12 },
                    { 33, true, "2025-03-02", 13 },
                    { 34, true, "2025-03-03", 14 },
                    { 35, true, "2025-03-04", 15 },
                    { 36, true, "2025-03-05", 16 },
                    { 37, true, "2025-03-06", 17 },
                    { 38, true, "2025-03-07", 18 },
                    { 39, true, "2025-03-08", 19 },
                    { 40, true, "2025-03-09", 20 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Doctors_ClinicID",
                table: "Doctors",
                column: "ClinicID");

            migrationBuilder.CreateIndex(
                name: "IX_TimeSlots_DoctorId",
                table: "TimeSlots",
                column: "DoctorId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TimeSlots");

            migrationBuilder.DropTable(
                name: "Doctors");

            migrationBuilder.DropTable(
                name: "Clinics");
        }
    }
}
