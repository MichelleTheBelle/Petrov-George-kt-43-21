using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PetrovGeorgeKt_43_21.Migrations
{
    /// <inheritdoc />
    public partial class CreateDatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "cd_subject",
                columns: table => new
                {
                    subject_id = table.Column<int>(type: "int", nullable: false, comment: "Идентификатор записи дисциплины")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    c_subject_name = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false, comment: "Название дисциплины"),
                    c_subject_labhours = table.Column<int>(type: "int", nullable: false, comment: "Лабораторные часы"),
                    c_subject_lecturehours = table.Column<int>(type: "int", nullable: false, comment: "Лекционные часы")
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_cd_subject_subject_id", x => x.subject_id);
                });

            migrationBuilder.CreateTable(
                name: "cd_teacher",
                columns: table => new
                {
                    teacher_id = table.Column<int>(type: "int", nullable: false, comment: "Идентификатор записи учителя")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    c_teacher_rate = table.Column<decimal>(type: "money", nullable: false, comment: "Ставка преподавателя"),
                    c_teacher_degree = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true, comment: "Степень преподавателя"),
                    c_teacher_title = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true, comment: "Звание преподавателя"),
                    c_teacher_position = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true, comment: "Должность преподавателя")
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_cd_teacher_teacher_id", x => x.teacher_id);
                });

            migrationBuilder.CreateTable(
                name: "cd_load",
                columns: table => new
                {
                    teachingload_id = table.Column<int>(type: "int", nullable: false, comment: "Идентификатор нагрузки преподавателя")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    c_teachingload_labhours = table.Column<int>(type: "int", nullable: false, comment: "Лабораторные часы"),
                    c_teachingload_lecturehours = table.Column<int>(type: "int", nullable: false, comment: "Лекционные часы"),
                    c_teachingload_teacher_id = table.Column<int>(type: "int", nullable: false, comment: "Идентификатор учителя"),
                    c_teachingload_subject_id = table.Column<int>(type: "int", nullable: false, comment: "Идентификатор дисциплины")
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_cd_load_load_id", x => x.teachingload_id);
                    table.ForeignKey(
                        name: "fk_f_subject_id",
                        column: x => x.c_teachingload_subject_id,
                        principalTable: "cd_subject",
                        principalColumn: "subject_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_f_teacher_id",
                        column: x => x.c_teachingload_teacher_id,
                        principalTable: "cd_teacher",
                        principalColumn: "teacher_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "idx_cd_load_fk_f_subject_id",
                table: "cd_load",
                column: "c_teachingload_subject_id");

            migrationBuilder.CreateIndex(
                name: "idx_cd_load_fk_f_teacher_id",
                table: "cd_load",
                column: "c_teachingload_teacher_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "cd_load");

            migrationBuilder.DropTable(
                name: "cd_subject");

            migrationBuilder.DropTable(
                name: "cd_teacher");
        }
    }
}
