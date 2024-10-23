﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PetrovGeorgeKt_43_21.Database;

#nullable disable

namespace PetrovGeorgeKt_43_21.Migrations
{
    [DbContext(typeof(TeacherDbContext))]
    [Migration("20241023081002_Create-Database")]
    partial class CreateDatabase
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("PetrovGeorgeKt_43_21.Models.Subject", b =>
                {
                    b.Property<int>("SubjectId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("subject_id")
                        .HasComment("Идентификатор записи дисциплины");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SubjectId"));

                    b.Property<int>("LabHours")
                        .HasColumnType("int")
                        .HasColumnName("c_subject_labhours")
                        .HasComment("Лабораторные часы");

                    b.Property<int>("LectureHours")
                        .HasColumnType("int")
                        .HasColumnName("c_subject_lecturehours")
                        .HasComment("Лекционные часы");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar")
                        .HasColumnName("c_subject_name")
                        .HasComment("Название дисциплины");

                    b.HasKey("SubjectId")
                        .HasName("pk_cd_subject_subject_id");

                    b.ToTable("cd_subject", (string)null);
                });

            modelBuilder.Entity("PetrovGeorgeKt_43_21.Models.Teacher", b =>
                {
                    b.Property<int>("TeacherId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("teacher_id")
                        .HasComment("Идентификатор записи учителя");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TeacherId"));

                    b.Property<string>("Degree")
                        .HasMaxLength(50)
                        .HasColumnType("varchar")
                        .HasColumnName("c_teacher_degree")
                        .HasComment("Степень преподавателя");

                    b.Property<string>("Position")
                        .HasMaxLength(50)
                        .HasColumnType("varchar")
                        .HasColumnName("c_teacher_position")
                        .HasComment("Должность преподавателя");

                    b.Property<decimal>("Rate")
                        .HasColumnType("money")
                        .HasColumnName("c_teacher_rate")
                        .HasComment("Ставка преподавателя");

                    b.Property<string>("Title")
                        .HasMaxLength(50)
                        .HasColumnType("varchar")
                        .HasColumnName("c_teacher_title")
                        .HasComment("Звание преподавателя");

                    b.HasKey("TeacherId")
                        .HasName("pk_cd_teacher_teacher_id");

                    b.ToTable("cd_teacher", (string)null);
                });

            modelBuilder.Entity("PetrovGeorgeKt_43_21.Models.TeachingLoad", b =>
                {
                    b.Property<int>("TeachingLoadId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("teachingload_id")
                        .HasComment("Идентификатор нагрузки преподавателя");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TeachingLoadId"));

                    b.Property<int>("LabHours")
                        .HasColumnType("int")
                        .HasColumnName("c_teachingload_labhours")
                        .HasComment("Лабораторные часы");

                    b.Property<int>("LectureHours")
                        .HasColumnType("int")
                        .HasColumnName("c_teachingload_lecturehours")
                        .HasComment("Лекционные часы");

                    b.Property<int>("SubjectId")
                        .HasColumnType("int")
                        .HasColumnName("c_teachingload_subject_id")
                        .HasComment("Идентификатор дисциплины");

                    b.Property<int>("TeacherId")
                        .HasColumnType("int")
                        .HasColumnName("c_teachingload_teacher_id")
                        .HasComment("Идентификатор учителя");

                    b.HasKey("TeachingLoadId")
                        .HasName("pk_cd_load_load_id");

                    b.HasIndex(new[] { "SubjectId" }, "idx_cd_load_fk_f_subject_id");

                    b.HasIndex(new[] { "TeacherId" }, "idx_cd_load_fk_f_teacher_id");

                    b.ToTable("cd_load", (string)null);
                });

            modelBuilder.Entity("PetrovGeorgeKt_43_21.Models.TeachingLoad", b =>
                {
                    b.HasOne("PetrovGeorgeKt_43_21.Models.Subject", "Subject")
                        .WithMany()
                        .HasForeignKey("SubjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_f_subject_id");

                    b.HasOne("PetrovGeorgeKt_43_21.Models.Teacher", "Teacher")
                        .WithMany()
                        .HasForeignKey("TeacherId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_f_teacher_id");

                    b.Navigation("Subject");

                    b.Navigation("Teacher");
                });
#pragma warning restore 612, 618
        }
    }
}