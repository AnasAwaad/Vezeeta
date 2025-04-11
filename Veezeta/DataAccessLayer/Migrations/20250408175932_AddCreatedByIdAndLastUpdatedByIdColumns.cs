using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Vezeeta.DAL.Migrations
{
    /// <inheritdoc />
    public partial class AddCreatedByIdAndLastUpdatedByIdColumns : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CeatedById",
                table: "TimeSlots",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "CreatedById",
                table: "TimeSlots",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastUpdatedById",
                table: "TimeSlots",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UpdatedById",
                table: "TimeSlots",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CeatedById",
                table: "Doctors",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "CreatedById",
                table: "Doctors",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastUpdatedById",
                table: "Doctors",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UpdatedById",
                table: "Doctors",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CeatedById",
                table: "Clinics",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "CreatedById",
                table: "Clinics",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastUpdatedById",
                table: "Clinics",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UpdatedById",
                table: "Clinics",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_TimeSlots_CreatedById",
                table: "TimeSlots",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_TimeSlots_UpdatedById",
                table: "TimeSlots",
                column: "UpdatedById");

            migrationBuilder.CreateIndex(
                name: "IX_Doctors_CreatedById",
                table: "Doctors",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_Doctors_UpdatedById",
                table: "Doctors",
                column: "UpdatedById");

            migrationBuilder.CreateIndex(
                name: "IX_Clinics_CreatedById",
                table: "Clinics",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_Clinics_UpdatedById",
                table: "Clinics",
                column: "UpdatedById");

            migrationBuilder.AddForeignKey(
                name: "FK_Clinics_AspNetUsers_CreatedById",
                table: "Clinics",
                column: "CreatedById",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Clinics_AspNetUsers_UpdatedById",
                table: "Clinics",
                column: "UpdatedById",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Doctors_AspNetUsers_CreatedById",
                table: "Doctors",
                column: "CreatedById",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Doctors_AspNetUsers_UpdatedById",
                table: "Doctors",
                column: "UpdatedById",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TimeSlots_AspNetUsers_CreatedById",
                table: "TimeSlots",
                column: "CreatedById",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TimeSlots_AspNetUsers_UpdatedById",
                table: "TimeSlots",
                column: "UpdatedById",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Clinics_AspNetUsers_CreatedById",
                table: "Clinics");

            migrationBuilder.DropForeignKey(
                name: "FK_Clinics_AspNetUsers_UpdatedById",
                table: "Clinics");

            migrationBuilder.DropForeignKey(
                name: "FK_Doctors_AspNetUsers_CreatedById",
                table: "Doctors");

            migrationBuilder.DropForeignKey(
                name: "FK_Doctors_AspNetUsers_UpdatedById",
                table: "Doctors");

            migrationBuilder.DropForeignKey(
                name: "FK_TimeSlots_AspNetUsers_CreatedById",
                table: "TimeSlots");

            migrationBuilder.DropForeignKey(
                name: "FK_TimeSlots_AspNetUsers_UpdatedById",
                table: "TimeSlots");

            migrationBuilder.DropIndex(
                name: "IX_TimeSlots_CreatedById",
                table: "TimeSlots");

            migrationBuilder.DropIndex(
                name: "IX_TimeSlots_UpdatedById",
                table: "TimeSlots");

            migrationBuilder.DropIndex(
                name: "IX_Doctors_CreatedById",
                table: "Doctors");

            migrationBuilder.DropIndex(
                name: "IX_Doctors_UpdatedById",
                table: "Doctors");

            migrationBuilder.DropIndex(
                name: "IX_Clinics_CreatedById",
                table: "Clinics");

            migrationBuilder.DropIndex(
                name: "IX_Clinics_UpdatedById",
                table: "Clinics");

            migrationBuilder.DropColumn(
                name: "CeatedById",
                table: "TimeSlots");

            migrationBuilder.DropColumn(
                name: "CreatedById",
                table: "TimeSlots");

            migrationBuilder.DropColumn(
                name: "LastUpdatedById",
                table: "TimeSlots");

            migrationBuilder.DropColumn(
                name: "UpdatedById",
                table: "TimeSlots");

            migrationBuilder.DropColumn(
                name: "CeatedById",
                table: "Doctors");

            migrationBuilder.DropColumn(
                name: "CreatedById",
                table: "Doctors");

            migrationBuilder.DropColumn(
                name: "LastUpdatedById",
                table: "Doctors");

            migrationBuilder.DropColumn(
                name: "UpdatedById",
                table: "Doctors");

            migrationBuilder.DropColumn(
                name: "CeatedById",
                table: "Clinics");

            migrationBuilder.DropColumn(
                name: "CreatedById",
                table: "Clinics");

            migrationBuilder.DropColumn(
                name: "LastUpdatedById",
                table: "Clinics");

            migrationBuilder.DropColumn(
                name: "UpdatedById",
                table: "Clinics");
        }
    }
}
