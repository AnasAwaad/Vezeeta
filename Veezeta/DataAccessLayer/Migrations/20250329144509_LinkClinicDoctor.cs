using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class LinkClinicDoctor : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ClinicID",
                table: "doctors",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "doctors",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ClinicID", "Name" },
                values: new object[] { 1, "Dr. Steven Young" });

            migrationBuilder.UpdateData(
                table: "doctors",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ClinicID", "Name" },
                values: new object[] { 2, "Dr. James Jackson" });

            migrationBuilder.UpdateData(
                table: "doctors",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ClinicID", "Name" },
                values: new object[] { 3, "Dr. Paul Wright" });

            migrationBuilder.UpdateData(
                table: "doctors",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ClinicID", "Name" },
                values: new object[] { 4, "Dr. Emily Johnson" });

            migrationBuilder.UpdateData(
                table: "doctors",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ClinicID", "Name" },
                values: new object[] { 5, "Dr. Patricia Thomas" });

            migrationBuilder.UpdateData(
                table: "doctors",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ClinicID", "Name" },
                values: new object[] { 6, "Dr. Emily Johnson" });

            migrationBuilder.UpdateData(
                table: "doctors",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ClinicID", "Name" },
                values: new object[] { 7, "Dr. John Smith" });

            migrationBuilder.UpdateData(
                table: "doctors",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ClinicID", "Name" },
                values: new object[] { 8, "Dr. Patricia Thomas" });

            migrationBuilder.UpdateData(
                table: "doctors",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "ClinicID", "Name" },
                values: new object[] { 9, "Dr. Steven Young" });

            migrationBuilder.UpdateData(
                table: "doctors",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ClinicID", "Name" },
                values: new object[] { 10, "Dr. Barbara White" });

            migrationBuilder.UpdateData(
                table: "doctors",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "ClinicID", "Name" },
                values: new object[] { 11, "Dr. Paul Wright" });

            migrationBuilder.UpdateData(
                table: "doctors",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "ClinicID", "Name" },
                values: new object[] { 12, "Dr. Paul Wright" });

            migrationBuilder.UpdateData(
                table: "doctors",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "ClinicID", "Name" },
                values: new object[] { 13, "Dr. Jennifer Scott" });

            migrationBuilder.UpdateData(
                table: "doctors",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "ClinicID", "Name" },
                values: new object[] { 14, "Dr. Barbara White" });

            migrationBuilder.UpdateData(
                table: "doctors",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "ClinicID", "Name" },
                values: new object[] { 15, "Dr. John Smith" });

            migrationBuilder.UpdateData(
                table: "doctors",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "ClinicID", "Name" },
                values: new object[] { 16, "Dr. Michael Brown" });

            migrationBuilder.UpdateData(
                table: "doctors",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "ClinicID", "Name" },
                values: new object[] { 17, "Dr. Susan Clark" });

            migrationBuilder.UpdateData(
                table: "doctors",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "ClinicID", "Name" },
                values: new object[] { 18, "Dr. Susan Clark" });

            migrationBuilder.UpdateData(
                table: "doctors",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "ClinicID", "Name" },
                values: new object[] { 19, "Dr. Robert Anderson" });

            migrationBuilder.UpdateData(
                table: "doctors",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "ClinicID", "Name" },
                values: new object[] { 20, "Dr. David Wilson" });

            migrationBuilder.CreateIndex(
                name: "IX_doctors_ClinicID",
                table: "doctors",
                column: "ClinicID");

            migrationBuilder.AddForeignKey(
                name: "FK_doctors_clinics_ClinicID",
                table: "doctors",
                column: "ClinicID",
                principalTable: "clinics",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_doctors_clinics_ClinicID",
                table: "doctors");

            migrationBuilder.DropIndex(
                name: "IX_doctors_ClinicID",
                table: "doctors");

            migrationBuilder.DropColumn(
                name: "ClinicID",
                table: "doctors");

            migrationBuilder.UpdateData(
                table: "doctors",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "Dr. Nancy Walker");

            migrationBuilder.UpdateData(
                table: "doctors",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "Dr. Thomas Hall");

            migrationBuilder.UpdateData(
                table: "doctors",
                keyColumn: "Id",
                keyValue: 3,
                column: "Name",
                value: "Dr. Barbara White");

            migrationBuilder.UpdateData(
                table: "doctors",
                keyColumn: "Id",
                keyValue: 4,
                column: "Name",
                value: "Dr. Barbara White");

            migrationBuilder.UpdateData(
                table: "doctors",
                keyColumn: "Id",
                keyValue: 5,
                column: "Name",
                value: "Dr. David Wilson");

            migrationBuilder.UpdateData(
                table: "doctors",
                keyColumn: "Id",
                keyValue: 6,
                column: "Name",
                value: "Dr. Michael Brown");

            migrationBuilder.UpdateData(
                table: "doctors",
                keyColumn: "Id",
                keyValue: 7,
                column: "Name",
                value: "Dr. Michael Brown");

            migrationBuilder.UpdateData(
                table: "doctors",
                keyColumn: "Id",
                keyValue: 8,
                column: "Name",
                value: "Dr. Steven Young");

            migrationBuilder.UpdateData(
                table: "doctors",
                keyColumn: "Id",
                keyValue: 9,
                column: "Name",
                value: "Dr. Susan Clark");

            migrationBuilder.UpdateData(
                table: "doctors",
                keyColumn: "Id",
                keyValue: 10,
                column: "Name",
                value: "Dr. Daniel Lewis");

            migrationBuilder.UpdateData(
                table: "doctors",
                keyColumn: "Id",
                keyValue: 11,
                column: "Name",
                value: "Dr. Sarah Davis");

            migrationBuilder.UpdateData(
                table: "doctors",
                keyColumn: "Id",
                keyValue: 12,
                column: "Name",
                value: "Dr. Sarah Davis");

            migrationBuilder.UpdateData(
                table: "doctors",
                keyColumn: "Id",
                keyValue: 13,
                column: "Name",
                value: "Dr. Emily Johnson");

            migrationBuilder.UpdateData(
                table: "doctors",
                keyColumn: "Id",
                keyValue: 14,
                column: "Name",
                value: "Dr. James Jackson");

            migrationBuilder.UpdateData(
                table: "doctors",
                keyColumn: "Id",
                keyValue: 15,
                column: "Name",
                value: "Dr. Sarah Davis");

            migrationBuilder.UpdateData(
                table: "doctors",
                keyColumn: "Id",
                keyValue: 16,
                column: "Name",
                value: "Dr. Susan Clark");

            migrationBuilder.UpdateData(
                table: "doctors",
                keyColumn: "Id",
                keyValue: 17,
                column: "Name",
                value: "Dr. Michael Brown");

            migrationBuilder.UpdateData(
                table: "doctors",
                keyColumn: "Id",
                keyValue: 18,
                column: "Name",
                value: "Dr. Steven Young");

            migrationBuilder.UpdateData(
                table: "doctors",
                keyColumn: "Id",
                keyValue: 19,
                column: "Name",
                value: "Dr. Steven Young");

            migrationBuilder.UpdateData(
                table: "doctors",
                keyColumn: "Id",
                keyValue: 20,
                column: "Name",
                value: "Dr. Karen Allen");
        }
    }
}
