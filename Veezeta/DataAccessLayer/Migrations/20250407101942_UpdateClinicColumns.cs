using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Vezeeta.DAL.Migrations
{
    /// <inheritdoc />
    public partial class UpdateClinicColumns : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Doctors_Clinics_ClinicID",
                table: "Doctors");

            migrationBuilder.RenameColumn(
                name: "ClinicID",
                table: "Doctors",
                newName: "ClinicId");

            migrationBuilder.RenameIndex(
                name: "IX_Doctors_ClinicID",
                table: "Doctors",
                newName: "IX_Doctors_ClinicId");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Clinics",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Location",
                table: "Clinics",
                type: "nvarchar(400)",
                maxLength: 400,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddForeignKey(
                name: "FK_Doctors_Clinics_ClinicId",
                table: "Doctors",
                column: "ClinicId",
                principalTable: "Clinics",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Doctors_Clinics_ClinicId",
                table: "Doctors");

            migrationBuilder.RenameColumn(
                name: "ClinicId",
                table: "Doctors",
                newName: "ClinicID");

            migrationBuilder.RenameIndex(
                name: "IX_Doctors_ClinicId",
                table: "Doctors",
                newName: "IX_Doctors_ClinicID");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Clinics",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "Location",
                table: "Clinics",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(400)",
                oldMaxLength: 400);

            migrationBuilder.AddForeignKey(
                name: "FK_Doctors_Clinics_ClinicID",
                table: "Doctors",
                column: "ClinicID",
                principalTable: "Clinics",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
