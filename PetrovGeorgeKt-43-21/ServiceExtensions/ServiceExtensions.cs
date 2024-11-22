using PetrovGeorgeKt_43_21.Interfaces.DepartmentInterfaces;
using PetrovGeorgeKt_43_21.Interfaces.SubjectInterfaces;
using PetrovGeorgeKt_43_21.Interfaces.TeacherInterfaces;

namespace PetrovGeorgeKt_43_21.ServiceExtensions
{
	public static class ServiceExtensions
	{
		public static IServiceCollection AddServices(this IServiceCollection services)
		{
			services.AddScoped<ITeacherService, TeacherService>();
			services.AddScoped<IDepartmentService, DepartmentService>();
			services.AddScoped<ISubjectService, SubjectService>();
			return services;
		}
	}
}
