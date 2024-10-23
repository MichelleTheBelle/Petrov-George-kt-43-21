using Microsoft.EntityFrameworkCore;
using PetrovGeorgeKt_43_21.Database;
using PetrovGeorgeKt_43_21.Filters.SubjectFilters;
using PetrovGeorgeKt_43_21.Models;

namespace PetrovGeorgeKt_43_21.Interfaces.SubjectInterfaces
{
    public interface ISubjectService
    {
        public Task<Subject[]> GetSubjectsByLoadAsync(SubjectTeacherFilter filter, CancellationToken cancellationToken);
    }

    public class SubjectService : ISubjectService
    {
        private readonly TeacherDbContext _dbContext;

        public SubjectService(TeacherDbContext dbContext)
        {
            _dbContext = dbContext;
        }
}
