using Microsoft.EntityFrameworkCore;
using PetrovGeorgeKt_43_21.Configurations;
using PetrovGeorgeKt_43_21.Models;

namespace PetrovGeorgeKt_43_21.Database
{
    public class TeacherDbContext : DbContext
    {
        DbSet<Teacher> Teachers { get; set; }
        DbSet<Subject> Subjects { get; set; }
        DbSet<TeachingLoad> TeachingLoads { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new TeacherConfiguration());
            modelBuilder.ApplyConfiguration(new SubjectConfiguration());
            modelBuilder.ApplyConfiguration(new TeachingLoadConfiguration());
        }
        public TeacherDbContext(DbContextOptions<TeacherDbContext> options) : base(options) 
        {

        }

    }
}
