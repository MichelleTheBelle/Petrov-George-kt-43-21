using Microsoft.AspNetCore.Mvc;
using PetrovGeorgeKt_43_21.Filters.DepartmentFilters;
using PetrovGeorgeKt_43_21.Interfaces.DepartmentInterfaces;

namespace PetrovGeorgeKt_43_21.Controllers
{
	[ApiController]
	[Route("controller2")]
	public class DepartmentsController : ControllerBase
	{
		private readonly ILogger<DepartmentsController> _logger;
		private readonly IDepartmentService _departmentService;

		public DepartmentsController(ILogger<DepartmentsController> logger, IDepartmentService departmentService)
		{
			_logger = logger;
			_departmentService = departmentService;
		}

		[HttpPost(Name = "GetDepartments")]
		public async Task<IActionResult> GetDepartmentsAsync(DepartmentFilter filter, CancellationToken cancellationToken = default)
		{
			var departments = await _departmentService.GetDepartmentsAsync(filter, cancellationToken);

			return Ok(departments);
		}
	}
}
