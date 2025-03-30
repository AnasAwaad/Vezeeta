using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class FixDoctorSeeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "SelectedTimeSlots",
                table: "doctors",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "doctors",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "Name", "SelectedTimeSlots" },
                values: new object[] { "Expert in Cardiology.\nProvides top-notch care.", "Dr. Nancy Walker", "1,21" });

            migrationBuilder.UpdateData(
                table: "doctors",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "Name", "SelectedTimeSlots" },
                values: new object[] { "Expert in Dermatology.\nProvides top-notch care.", "Dr. Thomas Hall", "2,22" });

            migrationBuilder.UpdateData(
                table: "doctors",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Description", "Name", "SelectedTimeSlots" },
                values: new object[] { "Expert in Neurology.\nProvides top-notch care.", "Dr. Barbara White", "3,23" });

            migrationBuilder.UpdateData(
                table: "doctors",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Description", "Name", "SelectedTimeSlots" },
                values: new object[] { "Expert in Pediatrics.\nProvides top-notch care.", "Dr. Barbara White", "4,24" });

            migrationBuilder.UpdateData(
                table: "doctors",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Description", "SelectedTimeSlots" },
                values: new object[] { "Expert in Orthopedics.\nProvides top-notch care.", "5,25" });

            migrationBuilder.UpdateData(
                table: "doctors",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Description", "Name", "SelectedTimeSlots" },
                values: new object[] { "Expert in Gynecology.\nProvides top-notch care.", "Dr. Michael Brown", "6,26" });

            migrationBuilder.UpdateData(
                table: "doctors",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Description", "Name", "SelectedTimeSlots" },
                values: new object[] { "Expert in General Medicine.\nProvides top-notch care.", "Dr. Michael Brown", "7,27" });

            migrationBuilder.UpdateData(
                table: "doctors",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Description", "Name", "SelectedTimeSlots" },
                values: new object[] { "Expert in ENT.\nProvides top-notch care.", "Dr. Steven Young", "8,28" });

            migrationBuilder.UpdateData(
                table: "doctors",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Description", "Name", "SelectedTimeSlots" },
                values: new object[] { "Expert in Urology.\nProvides top-notch care.", "Dr. Susan Clark", "9,29" });

            migrationBuilder.UpdateData(
                table: "doctors",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Description", "Name", "SelectedTimeSlots" },
                values: new object[] { "Expert in Gastroenterology.\nProvides top-notch care.", "Dr. Daniel Lewis", "10,30" });

            migrationBuilder.UpdateData(
                table: "doctors",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Description", "Name", "SelectedTimeSlots" },
                values: new object[] { "Expert in Oncology.\nProvides top-notch care.", "Dr. Sarah Davis", "11,31" });

            migrationBuilder.UpdateData(
                table: "doctors",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Description", "Name", "SelectedTimeSlots" },
                values: new object[] { "Expert in Psychiatry.\nProvides top-notch care.", "Dr. Sarah Davis", "12,32" });

            migrationBuilder.UpdateData(
                table: "doctors",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Description", "Name", "SelectedTimeSlots" },
                values: new object[] { "Expert in Nephrology.\nProvides top-notch care.", "Dr. Emily Johnson", "13,33" });

            migrationBuilder.UpdateData(
                table: "doctors",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Description", "Name", "SelectedTimeSlots" },
                values: new object[] { "Expert in Endocrinology.\nProvides top-notch care.", "Dr. James Jackson", "14,34" });

            migrationBuilder.UpdateData(
                table: "doctors",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Description", "Name", "SelectedTimeSlots" },
                values: new object[] { "Expert in Radiology.\nProvides top-notch care.", "Dr. Sarah Davis", "15,35" });

            migrationBuilder.UpdateData(
                table: "doctors",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Description", "Name", "SelectedTimeSlots" },
                values: new object[] { "Expert in Rheumatology.\nProvides top-notch care.", "Dr. Susan Clark", "16,36" });

            migrationBuilder.UpdateData(
                table: "doctors",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Description", "Name", "SelectedTimeSlots" },
                values: new object[] { "Expert in Plastic Surgery.\nProvides top-notch care.", "Dr. Michael Brown", "17,37" });

            migrationBuilder.UpdateData(
                table: "doctors",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Description", "Name", "SelectedTimeSlots" },
                values: new object[] { "Expert in Pulmonology.\nProvides top-notch care.", "Dr. Steven Young", "18,38" });

            migrationBuilder.UpdateData(
                table: "doctors",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Description", "Name", "SelectedTimeSlots" },
                values: new object[] { "Expert in Hematology.\nProvides top-notch care.", "Dr. Steven Young", "19,39" });

            migrationBuilder.UpdateData(
                table: "doctors",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Description", "Name", "SelectedTimeSlots" },
                values: new object[] { "Expert in Ophthalmology.\nProvides top-notch care.", "Dr. Karen Allen", "20,40" });

            migrationBuilder.UpdateData(
                table: "timeSlots",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Date", "DoctorId" },
                values: new object[] { "2025-03-01", 1 });

            migrationBuilder.UpdateData(
                table: "timeSlots",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Date", "DoctorId" },
                values: new object[] { "2025-03-02", 2 });

            migrationBuilder.UpdateData(
                table: "timeSlots",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Date", "DoctorId" },
                values: new object[] { "2025-03-03", 3 });

            migrationBuilder.UpdateData(
                table: "timeSlots",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Date", "DoctorId" },
                values: new object[] { "2025-03-04", 4 });

            migrationBuilder.UpdateData(
                table: "timeSlots",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Date", "DoctorId" },
                values: new object[] { "2025-03-05", 5 });

            migrationBuilder.UpdateData(
                table: "timeSlots",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Date", "DoctorId" },
                values: new object[] { "2025-03-06", 6 });

            migrationBuilder.UpdateData(
                table: "timeSlots",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Date", "DoctorId" },
                values: new object[] { "2025-03-07", 7 });

            migrationBuilder.UpdateData(
                table: "timeSlots",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Date", "DoctorId" },
                values: new object[] { "2025-03-08", 8 });

            migrationBuilder.UpdateData(
                table: "timeSlots",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Date", "DoctorId" },
                values: new object[] { "2025-03-09", 9 });

            migrationBuilder.UpdateData(
                table: "timeSlots",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Date", "DoctorId" },
                values: new object[] { "2025-03-10", 10 });

            migrationBuilder.UpdateData(
                table: "timeSlots",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Date", "DoctorId" },
                values: new object[] { "2025-03-11", 11 });

            migrationBuilder.UpdateData(
                table: "timeSlots",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Date", "DoctorId" },
                values: new object[] { "2025-03-12", 12 });

            migrationBuilder.UpdateData(
                table: "timeSlots",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Date", "DoctorId" },
                values: new object[] { "2025-03-13", 13 });

            migrationBuilder.UpdateData(
                table: "timeSlots",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Date", "DoctorId" },
                values: new object[] { "2025-03-14", 14 });

            migrationBuilder.UpdateData(
                table: "timeSlots",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Date", "DoctorId" },
                values: new object[] { "2025-03-15", 15 });

            migrationBuilder.UpdateData(
                table: "timeSlots",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Date", "DoctorId" },
                values: new object[] { "2025-03-16", 16 });

            migrationBuilder.UpdateData(
                table: "timeSlots",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Date", "DoctorId" },
                values: new object[] { "2025-03-17", 17 });

            migrationBuilder.UpdateData(
                table: "timeSlots",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Date", "DoctorId" },
                values: new object[] { "2025-03-18", 18 });

            migrationBuilder.UpdateData(
                table: "timeSlots",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Date", "DoctorId" },
                values: new object[] { "2025-03-19", 19 });

            migrationBuilder.UpdateData(
                table: "timeSlots",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Date", "DoctorId" },
                values: new object[] { "2025-03-20", 20 });

            migrationBuilder.UpdateData(
                table: "timeSlots",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Date", "DoctorId" },
                values: new object[] { "2025-03-21", 1 });

            migrationBuilder.UpdateData(
                table: "timeSlots",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Date", "DoctorId" },
                values: new object[] { "2025-03-22", 2 });

            migrationBuilder.UpdateData(
                table: "timeSlots",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Date", "DoctorId" },
                values: new object[] { "2025-03-23", 3 });

            migrationBuilder.UpdateData(
                table: "timeSlots",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Date", "DoctorId" },
                values: new object[] { "2025-03-24", 4 });

            migrationBuilder.UpdateData(
                table: "timeSlots",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Date", "DoctorId" },
                values: new object[] { "2025-03-25", 5 });

            migrationBuilder.UpdateData(
                table: "timeSlots",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Date", "DoctorId" },
                values: new object[] { "2025-03-26", 6 });

            migrationBuilder.UpdateData(
                table: "timeSlots",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Date", "DoctorId" },
                values: new object[] { "2025-03-27", 7 });

            migrationBuilder.UpdateData(
                table: "timeSlots",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Date", "DoctorId" },
                values: new object[] { "2025-03-28", 8 });

            migrationBuilder.UpdateData(
                table: "timeSlots",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Date", "DoctorId" },
                values: new object[] { "2025-03-29", 9 });

            migrationBuilder.UpdateData(
                table: "timeSlots",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Date", "DoctorId" },
                values: new object[] { "2025-03-30", 10 });

            migrationBuilder.UpdateData(
                table: "timeSlots",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Date", "DoctorId" },
                values: new object[] { "2025-03-31", 11 });

            migrationBuilder.UpdateData(
                table: "timeSlots",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Date", "DoctorId" },
                values: new object[] { "2025-03-01", 12 });

            migrationBuilder.UpdateData(
                table: "timeSlots",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Date", "DoctorId" },
                values: new object[] { "2025-03-02", 13 });

            migrationBuilder.UpdateData(
                table: "timeSlots",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Date", "DoctorId" },
                values: new object[] { "2025-03-03", 14 });

            migrationBuilder.UpdateData(
                table: "timeSlots",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Date", "DoctorId" },
                values: new object[] { "2025-03-04", 15 });

            migrationBuilder.UpdateData(
                table: "timeSlots",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Date", "DoctorId" },
                values: new object[] { "2025-03-05", 16 });

            migrationBuilder.UpdateData(
                table: "timeSlots",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Date", "DoctorId" },
                values: new object[] { "2025-03-06", 17 });

            migrationBuilder.UpdateData(
                table: "timeSlots",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Date", "DoctorId" },
                values: new object[] { "2025-03-07", 18 });

            migrationBuilder.UpdateData(
                table: "timeSlots",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Date", "DoctorId" },
                values: new object[] { "2025-03-08", 19 });

            migrationBuilder.UpdateData(
                table: "timeSlots",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Date", "DoctorId" },
                values: new object[] { "2025-03-09", 20 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SelectedTimeSlots",
                table: "doctors");

            migrationBuilder.UpdateData(
                table: "doctors",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Expert in cardiology.\nProvides advanced treatments.", "Dr. John Smith" });

            migrationBuilder.UpdateData(
                table: "doctors",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Experienced dermatologist.\nSpecializes in skin care.", "Dr. Emily Johnson" });

            migrationBuilder.UpdateData(
                table: "doctors",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Leading neurologist.\nExpert in brain disorders.", "Dr. Michael Brown" });

            migrationBuilder.UpdateData(
                table: "doctors",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Renowned pediatrician.\nCares for children's health.", "Dr. Sarah Davis" });

            migrationBuilder.UpdateData(
                table: "doctors",
                keyColumn: "Id",
                keyValue: 5,
                column: "Description",
                value: "Expert in orthopedics.\nSpecializes in bone injuries.");

            migrationBuilder.UpdateData(
                table: "doctors",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Specialist in gynecology.\nProvides women's healthcare.", "Dr. Linda Martinez" });

            migrationBuilder.UpdateData(
                table: "doctors",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Expert in general medicine.\nProvides primary care.", "Dr. Robert Anderson" });

            migrationBuilder.UpdateData(
                table: "doctors",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Top-rated ENT specialist.\nTreats ear, nose, and throat.", "Dr. Patricia Thomas" });

            migrationBuilder.UpdateData(
                table: "doctors",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Expert in urology.\nSpecializes in urinary tract health.", "Dr. James Jackson" });

            migrationBuilder.UpdateData(
                table: "doctors",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Leading gastroenterologist.\nTreats digestive disorders.", "Dr. Barbara White" });

            migrationBuilder.UpdateData(
                table: "doctors",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Experienced oncologist.\nSpecializes in cancer treatments.", "Dr. Richard Harris" });

            migrationBuilder.UpdateData(
                table: "doctors",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Highly skilled psychiatrist.\nExpert in mental health.", "Dr. Susan Clark" });

            migrationBuilder.UpdateData(
                table: "doctors",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Expert in nephrology.\nTreats kidney-related issues.", "Dr. Daniel Lewis" });

            migrationBuilder.UpdateData(
                table: "doctors",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Renowned endocrinologist.\nManages hormone-related disorders.", "Dr. Nancy Walker" });

            migrationBuilder.UpdateData(
                table: "doctors",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Specialist in radiology.\nExpert in medical imaging.", "Dr. Thomas Hall" });

            migrationBuilder.UpdateData(
                table: "doctors",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Expert in rheumatology.\nTreats autoimmune diseases.", "Dr. Karen Allen" });

            migrationBuilder.UpdateData(
                table: "doctors",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Highly skilled plastic surgeon.\nSpecializes in cosmetic procedures.", "Dr. Steven Young" });

            migrationBuilder.UpdateData(
                table: "doctors",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Top-rated pulmonologist.\nTreats lung-related conditions.", "Dr. Donna King" });

            migrationBuilder.UpdateData(
                table: "doctors",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Leading hematologist.\nSpecializes in blood disorders.", "Dr. Paul Wright" });

            migrationBuilder.UpdateData(
                table: "doctors",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Expert in ophthalmology.\nProvides eye care treatments.", "Dr. Jennifer Scott" });

            migrationBuilder.UpdateData(
                table: "timeSlots",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Date", "DoctorId" },
                values: new object[] { "2025-03-02", 2 });

            migrationBuilder.UpdateData(
                table: "timeSlots",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Date", "DoctorId" },
                values: new object[] { "2025-03-03", 3 });

            migrationBuilder.UpdateData(
                table: "timeSlots",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Date", "DoctorId" },
                values: new object[] { "2025-03-04", 4 });

            migrationBuilder.UpdateData(
                table: "timeSlots",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Date", "DoctorId" },
                values: new object[] { "2025-03-05", 5 });

            migrationBuilder.UpdateData(
                table: "timeSlots",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Date", "DoctorId" },
                values: new object[] { "2025-03-06", 6 });

            migrationBuilder.UpdateData(
                table: "timeSlots",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Date", "DoctorId" },
                values: new object[] { "2025-03-07", 7 });

            migrationBuilder.UpdateData(
                table: "timeSlots",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Date", "DoctorId" },
                values: new object[] { "2025-03-08", 8 });

            migrationBuilder.UpdateData(
                table: "timeSlots",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Date", "DoctorId" },
                values: new object[] { "2025-03-09", 9 });

            migrationBuilder.UpdateData(
                table: "timeSlots",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Date", "DoctorId" },
                values: new object[] { "2025-03-10", 10 });

            migrationBuilder.UpdateData(
                table: "timeSlots",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Date", "DoctorId" },
                values: new object[] { "2025-03-11", 11 });

            migrationBuilder.UpdateData(
                table: "timeSlots",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Date", "DoctorId" },
                values: new object[] { "2025-03-12", 12 });

            migrationBuilder.UpdateData(
                table: "timeSlots",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Date", "DoctorId" },
                values: new object[] { "2025-03-13", 13 });

            migrationBuilder.UpdateData(
                table: "timeSlots",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Date", "DoctorId" },
                values: new object[] { "2025-03-14", 14 });

            migrationBuilder.UpdateData(
                table: "timeSlots",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Date", "DoctorId" },
                values: new object[] { "2025-03-15", 15 });

            migrationBuilder.UpdateData(
                table: "timeSlots",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Date", "DoctorId" },
                values: new object[] { "2025-03-16", 16 });

            migrationBuilder.UpdateData(
                table: "timeSlots",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Date", "DoctorId" },
                values: new object[] { "2025-03-17", 17 });

            migrationBuilder.UpdateData(
                table: "timeSlots",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Date", "DoctorId" },
                values: new object[] { "2025-03-18", 18 });

            migrationBuilder.UpdateData(
                table: "timeSlots",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Date", "DoctorId" },
                values: new object[] { "2025-03-19", 19 });

            migrationBuilder.UpdateData(
                table: "timeSlots",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Date", "DoctorId" },
                values: new object[] { "2025-03-20", 20 });

            migrationBuilder.UpdateData(
                table: "timeSlots",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Date", "DoctorId" },
                values: new object[] { "2025-03-21", 1 });

            migrationBuilder.UpdateData(
                table: "timeSlots",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Date", "DoctorId" },
                values: new object[] { "2025-03-22", 2 });

            migrationBuilder.UpdateData(
                table: "timeSlots",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Date", "DoctorId" },
                values: new object[] { "2025-03-23", 3 });

            migrationBuilder.UpdateData(
                table: "timeSlots",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Date", "DoctorId" },
                values: new object[] { "2025-03-24", 4 });

            migrationBuilder.UpdateData(
                table: "timeSlots",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Date", "DoctorId" },
                values: new object[] { "2025-03-25", 5 });

            migrationBuilder.UpdateData(
                table: "timeSlots",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Date", "DoctorId" },
                values: new object[] { "2025-03-26", 6 });

            migrationBuilder.UpdateData(
                table: "timeSlots",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Date", "DoctorId" },
                values: new object[] { "2025-03-27", 7 });

            migrationBuilder.UpdateData(
                table: "timeSlots",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Date", "DoctorId" },
                values: new object[] { "2025-03-28", 8 });

            migrationBuilder.UpdateData(
                table: "timeSlots",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Date", "DoctorId" },
                values: new object[] { "2025-03-29", 9 });

            migrationBuilder.UpdateData(
                table: "timeSlots",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Date", "DoctorId" },
                values: new object[] { "2025-03-30", 10 });

            migrationBuilder.UpdateData(
                table: "timeSlots",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Date", "DoctorId" },
                values: new object[] { "2025-03-31", 11 });

            migrationBuilder.UpdateData(
                table: "timeSlots",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Date", "DoctorId" },
                values: new object[] { "2025-03-01", 12 });

            migrationBuilder.UpdateData(
                table: "timeSlots",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Date", "DoctorId" },
                values: new object[] { "2025-03-02", 13 });

            migrationBuilder.UpdateData(
                table: "timeSlots",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Date", "DoctorId" },
                values: new object[] { "2025-03-03", 14 });

            migrationBuilder.UpdateData(
                table: "timeSlots",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Date", "DoctorId" },
                values: new object[] { "2025-03-04", 15 });

            migrationBuilder.UpdateData(
                table: "timeSlots",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Date", "DoctorId" },
                values: new object[] { "2025-03-05", 16 });

            migrationBuilder.UpdateData(
                table: "timeSlots",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Date", "DoctorId" },
                values: new object[] { "2025-03-06", 17 });

            migrationBuilder.UpdateData(
                table: "timeSlots",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Date", "DoctorId" },
                values: new object[] { "2025-03-07", 18 });

            migrationBuilder.UpdateData(
                table: "timeSlots",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Date", "DoctorId" },
                values: new object[] { "2025-03-08", 19 });

            migrationBuilder.UpdateData(
                table: "timeSlots",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Date", "DoctorId" },
                values: new object[] { "2025-03-09", 20 });

            migrationBuilder.UpdateData(
                table: "timeSlots",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Date", "DoctorId" },
                values: new object[] { "2025-03-10", 1 });
        }
    }
}
