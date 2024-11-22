using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PetrovGeorgeKt_43_21.Migrations
{
    /// <inheritdoc />
    public partial class Edition : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_f_subject_id",
                table: "cd_load");

            migrationBuilder.DropIndex(
                name: "idx_cd_load_fk_f_subject_id",
                table: "cd_load");

            migrationBuilder.DropIndex(
                name: "IX_cd_load_c_teachingload_subject_id",
                table: "cd_load");

            migrationBuilder.DropColumn(
                name: "c_subject_hours",
                table: "cd_subject");

            migrationBuilder.DropColumn(
                name: "c_teachingload_subject_id",
                table: "cd_load");

            migrationBuilder.RenameTable(
                name: "cd_load",
                newName: "TeachingLoads");

            migrationBuilder.AddColumn<int>(
                name: "c_subject_teachingload_id",
                table: "cd_subject",
                type: "int",
                nullable: false,
                defaultValue: 0,
                comment: "Идентификатор нагрузки");

            migrationBuilder.CreateIndex(
                name: "idx_cd_subject_fk_f_teachingload_id",
                table: "cd_subject",
                column: "c_subject_teachingload_id");

            migrationBuilder.CreateIndex(
                name: "IX_cd_subject_c_subject_teachingload_id",
                table: "cd_subject",
                column: "c_subject_teachingload_id",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "fk_f_teachingload_id",
                table: "cd_subject",
                column: "c_subject_teachingload_id",
                principalTable: "TeachingLoads",
                principalColumn: "teachingload_id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_f_teachingload_id",
                table: "cd_subject");

            migrationBuilder.DropIndex(
                name: "idx_cd_subject_fk_f_teachingload_id",
                table: "cd_subject");

            migrationBuilder.DropIndex(
                name: "IX_cd_subject_c_subject_teachingload_id",
                table: "cd_subject");

            migrationBuilder.DropColumn(
                name: "c_subject_teachingload_id",
                table: "cd_subject");

            migrationBuilder.RenameTable(
                name: "TeachingLoads",
                newName: "cd_load");

            migrationBuilder.AddColumn<int>(
                name: "c_subject_hours",
                table: "cd_subject",
                type: "int",
                nullable: false,
                defaultValue: 0,
                comment: "Часы");

            migrationBuilder.AddColumn<int>(
                name: "c_teachingload_subject_id",
                table: "cd_load",
                type: "int",
                nullable: false,
                defaultValue: 0,
                comment: "Идентификатор дисциплины");

            migrationBuilder.CreateIndex(
                name: "idx_cd_load_fk_f_subject_id",
                table: "cd_load",
                column: "c_teachingload_subject_id");

            migrationBuilder.CreateIndex(
                name: "IX_cd_load_c_teachingload_subject_id",
                table: "cd_load",
                column: "c_teachingload_subject_id",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "fk_f_subject_id",
                table: "cd_load",
                column: "c_teachingload_subject_id",
                principalTable: "cd_subject",
                principalColumn: "subject_id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
