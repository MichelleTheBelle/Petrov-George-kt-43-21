using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PetrovGeorgeKt_43_21.Migrations
{
    /// <inheritdoc />
    public partial class Migration3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameTable(
                name: "TeachingLoads",
                newName: "cd_load");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameTable(
                name: "cd_load",
                newName: "TeachingLoads");
        }
    }
}
