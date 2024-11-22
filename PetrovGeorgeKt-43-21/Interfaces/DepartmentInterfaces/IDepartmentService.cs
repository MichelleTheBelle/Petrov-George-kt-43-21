using Microsoft.EntityFrameworkCore;
using PetrovGeorgeKt_43_21.Database;
using PetrovGeorgeKt_43_21.Filters.DepartmentFilters;
using PetrovGeorgeKt_43_21.Models;

namespace PetrovGeorgeKt_43_21.Interfaces.DepartmentInterfaces
{
	public interface IDepartmentService
	{
		public Task<Department[]> GetDepartmentsAsync(DepartmentFilter filter, CancellationToken cancellationToken);
	}

	public class DepartmentService : IDepartmentService
	{
		private readonly TeacherDbContext _dbContext;
		public DepartmentService(TeacherDbContext dbContext)
		{
			_dbContext = dbContext;
		}
		public Task<Department[]> GetDepartmentsAsync(DepartmentFilter filter, CancellationToken cancellationToken = default)
		{
			var query = _dbContext.Set<Department>().AsQueryable();

			if (filter.MinTeachersCount.HasValue)
			{
				query = query.Include(d => d.Head).Where(d => d.Teachers.Count == filter.MinTeachersCount.Value);
			}
			else
			{
				query = query.Include(d => d.Head);
			}

			return query.ToArrayAsync(cancellationToken);
		}
	}
}
