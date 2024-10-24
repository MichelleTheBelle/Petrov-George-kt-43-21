using Microsoft.EntityFrameworkCore;
using PetrovGeorgeKt_43_21.Database;
using PetrovGeorgeKt_43_21.Filters.SubjectFilters;
using PetrovGeorgeKt_43_21.Models;

namespace PetrovGeorgeKt_43_21.Interfaces.SubjectInterfaces
{
    public interface ISubjectService
    {
        public Task<Subject[]> GetSubjectsByTeacherAsync(SubjectTeacherFilter filter, CancellationToken cancellationToken);
    }

    public class SubjectService : ISubjectService
    {
        private readonly TeacherDbContext _dbContext;

        public SubjectService(TeacherDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public Task<Subject[]> GetSubjectsByTeacherAsync(SubjectTeacherFilter filter, CancellationToken cancellationToken = default)
        {
            var query = _dbContext.Set<TeachingLoad>()
        .Include(tl => tl.Subject) 
        .Include(tl => tl.Teacher) 
        .AsQueryable();

            if (!string.IsNullOrEmpty(filter.FirstName))
            {
                query = query.Where(tl => tl.Teacher.FirstName == filter.FirstName);
            }

            if (!string.IsNullOrEmpty(filter.LastName))
            {
                query = query.Where(tl => tl.Teacher.LastName == filter.LastName);
            }

            if (!string.IsNullOrEmpty(filter.MiddleName))
            {
                query = query.Where(tl => tl.Teacher.MiddleName == filter.MiddleName);
            }

            return query.Select(tl => tl.Subject).Distinct().ToArrayAsync(cancellationToken);
        }
    }
}
