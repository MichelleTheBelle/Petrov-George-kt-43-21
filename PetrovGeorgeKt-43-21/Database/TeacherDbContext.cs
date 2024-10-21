using Microsoft.EntityFrameworkCore;

namespace PetrovGeorgeKt_43_21.Database
{
    public class TeacherDbContext : DbContext
    {
        public TeacherDbContext(DbContextOptions<TeacherDbContext> options) : base(options) 
        {

        }

    }
}
