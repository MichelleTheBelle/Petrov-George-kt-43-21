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

            builder.Property(p => p.Hours)
                .HasColumnName("c_teachingload_hours")
                .HasColumnType(ColumnType.Int)
                .HasComment("Часы");

            builder.Property(p => p.SubjectId)
                .HasColumnName("c_teachingload_subject_id")
                .HasComment("Идентификатор дисциплины");

            builder.ToTable(TableName)
                .HasOne(p => p.Subject)
                .WithOne()
                .HasForeignKey<TeachingLoad>(p => p.SubjectId)
                .HasConstraintName("fk_f_subject_id")
                .OnDelete(DeleteBehavior.Cascade);

            builder.ToTable(TableName)
                .HasIndex(p => p.SubjectId, $"idx_{TableName}_fk_f_subject_id");

            builder.Navigation(p => p.Subject)
                .AutoInclude();
        }
    }
}
