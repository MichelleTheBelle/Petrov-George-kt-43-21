using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PetrovGeorgeKt_43_21.Migrations
{
    /// <inheritdoc />
    public partial class EditInt : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "c_department_head_id",
                table: "cd_department",
                type: "int",
                nullable: true,
                comment: "Идентификатор заведущего",
                oldClrType: typeof(int),
                oldType: "int",
                oldComment: "Идентификатор заведущего");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "c_department_head_id",
                table: "cd_department",
                type: "int",
                nullable: false,
                defaultValue: 0,
                comment: "Идентификатор заведущего",
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldComment: "Идентификатор заведущего");
        }
    }
}
