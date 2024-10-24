using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using PetrovGeorgeKt_43_21.Filters.SubjectFilters;
using PetrovGeorgeKt_43_21.Interfaces.SubjectInterfaces;

namespace PetrovGeorgeKt_43_21.Controllers
{
    [ApiController]
    [Route("controller")]
    public class SubjectController : ControllerBase
    {
        private readonly ILogger<SubjectController> _logger;
        private readonly ISubjectService _subjectService;

        public SubjectController(ILogger<SubjectController> logger, ISubjectService subjectService)
        {
            _logger = logger;
            _subjectService = subjectService;
        }

        [HttpPost(Name = "GetSubjectsByTeacher")]
        public async Task<IActionResult> GetSubjectsByTeacherAsync(SubjectTeacherFilter filter, CancellationToken cancellationToken = default)
        {
            var subjects = await _subjectService.GetSubjectsByTeacherAsync(filter, cancellationToken);

            return Ok(subjects);
        }
    }
}
