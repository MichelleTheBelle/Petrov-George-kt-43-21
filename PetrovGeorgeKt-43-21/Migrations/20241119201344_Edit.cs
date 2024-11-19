using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PetrovGeorgeKt_43_21.Migrations
{
    /// <inheritdoc />
    public partial class Edit : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "c_subject_labhours",
                table: "cd_subject",
                newName: "c_subject_hours");

            migrationBuilder.RenameColumn(
                name: "c_teachingload_labhours",
                table: "cd_load",
                newName: "c_teachingload_hours");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "c_subject_hours",
                table: "cd_subject",
                newName: "c_subject_labhours");

            migrationBuilder.RenameColumn(
                name: "c_teachingload_hours",
                table: "cd_load",
                newName: "c_teachingload_labhours");
        }
    }
}
