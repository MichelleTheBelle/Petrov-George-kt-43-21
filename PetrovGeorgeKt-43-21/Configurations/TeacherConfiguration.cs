using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PetrovGeorgeKt_43_21.Helpers;
using PetrovGeorgeKt_43_21.Models;

namespace PetrovGeorgeKt_43_21.Configurations
{
    public class TeacherConfiguration : IEntityTypeConfiguration<Teacher>
    {
        private const string TableName = "cd_teacher";

        public void Configure(EntityTypeBuilder<Teacher> builder)
        {
            builder
                .HasKey(p => p.TeacherId)
                .HasName($"pk_{TableName}_teacher_id");

            builder.Property(p => p.TeacherId)
                .ValueGeneratedOnAdd();

            builder.Property(p => p.TeacherId)
                .HasColumnName("teacher_id")
                .HasComment("Идентификатор записи учителя");

            builder.Property(p => p.Rate)
                .IsRequired()
                .HasColumnName("c_teacher_rate")
                .HasColumnType(ColumnType.Decimal)
                .HasComment("Ставка преподавателя");

            builder.Property(p => p.Degree)
                .HasColumnName("c_teacher_degree")
                .HasColumnType(ColumnType.String).HasMaxLength(50)
                .HasComment("Степень преподавателя");

            builder.Property(p => p.Title)
                .HasColumnName("c_teacher_title")
                .HasColumnType(ColumnType.String).HasMaxLength(50)
                .HasComment("Звание преподавателя");

            builder.Property(p => p.Position)
                .HasColumnName("c_teacher_position")
                .HasColumnType(ColumnType.String).HasMaxLength(50)
                .HasComment("Должность преподавателя");

            builder.ToTable(TableName);
        }
    }
}
