using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PetrovGeorgeKt_43_21.Helpers;
using PetrovGeorgeKt_43_21.Models;

namespace PetrovGeorgeKt_43_21.Configurations
{
    public class TeachingLoadConfiguration : IEntityTypeConfiguration<TeachingLoad>
    {
        private const string TableName = "cd_load";

        public void Configure(EntityTypeBuilder<TeachingLoad> builder)
        {
            builder
                .HasKey(p => p.TeachingLoadId)
                .HasName($"pk_{TableName}_load_id");

            builder.Property(p => p.TeachingLoadId)
                .ValueGeneratedOnAdd();

            builder.Property(p => p.TeachingLoadId)
                .HasColumnName("teachingload_id")
                .HasComment("Идентификатор нагрузки преподавателя");

            builder.Property(p => p.LabHours)
                .HasColumnName("c_teachingload_labhours")
                .HasColumnType(ColumnType.Int)
                .HasComment("Лабораторные часы");

            builder.Property(p => p.LabHours)
               .HasColumnName("c_teachingload_lecturehours")
               .HasColumnType(ColumnType.Int)
               .HasComment("Лекционные часы");

            builder.Property(p => p.TeacherId)
                .HasColumnName("c_teachingload_teacher_id")
                .HasComment("Идентификатор учителя");

            builder.Property(p => p.SubjectId)
                .HasColumnName("c_teachingload_subject_id")
                .HasComment("Идентификатор дисциплины");

            builder.ToTable(TableName)
                .HasOne(p => p.Teacher)
                .WithMany()
                .HasForeignKey(p => p.TeacherId)
                .HasConstraintName("fk_f_teacher_id")
                .OnDelete(DeleteBehavior.Cascade);

            builder.ToTable(TableName)
                .HasOne(p => p.Subject)
                .WithMany()
                .HasForeignKey(p => p.SubjectId)
                .HasConstraintName("fk_f_subject_id")
                .OnDelete(DeleteBehavior.Cascade);

            builder.Navigation(p => p.Subject)
                .AutoInclude();

            builder.Navigation(p => p.Teacher)
                .AutoInclude();
        }
    }
}
