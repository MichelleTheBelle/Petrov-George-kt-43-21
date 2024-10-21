using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PetrovGeorgeKt_43_21.Helpers;
using PetrovGeorgeKt_43_21.Models;

namespace PetrovGeorgeKt_43_21.Configurations
{
    public class SubjectConfiguration : IEntityTypeConfiguration<Subject>
    {
        private const string TableName = "cd_subject";

        public void Configure(EntityTypeBuilder<Subject> builder)
        {
            builder
                .HasKey(t => t.SubjectId)
                .HasName($"pk_{TableName}_subject_id");

            builder.Property(t => t.SubjectId)
                .ValueGeneratedOnAdd();

            builder.Property(t => t.SubjectId)
                .HasColumnName("subject_id")
                .HasComment("Идентификатор записи дисциплины");

            builder.Property(t => t.Name)
                .IsRequired()
                .HasColumnName("c_subject_name")
                .HasColumnType(ColumnType.String).HasMaxLength(100)
                .HasComment("Название дисциплины");

            builder.Property(t => t.LabHours)
                .HasColumnName("c_subject_lanhours")
                .HasColumnType(ColumnType.Int)
                .HasComment("Лабораторные часы");

            builder.Property(t => t.LectureHours)
                .HasColumnName("c_subject_lecturehours")
                .HasColumnType(ColumnType.Int)
                .HasComment("Лекционные часы");
                
        }
    }
}
