using System;
using Microsoft.AspNetCore.Mvc;
using first_api_app.Models;

namespace first_api_app.Controllers
{
	[ApiController()]
	[Route("api/projects/{projectId}/bugs")]
	public class BugsController : ControllerBase
	{
		public BugsController()
		{
		}

		[HttpGet]
		public ActionResult<IList<Bug>> GetBugs(int projectId)
        {
			var project = ProjectsService.Current.Projects.FirstOrDefault(project => project.Id == projectId);
			if (project == null) {
				return NotFound();
            }
			return Ok(project.Bugs);
        }

		[HttpGet("{bugId}")]
		public ActionResult<Bug> GetBugsById(int projectId, int bugId)
		{
			var project = ProjectsService.Current.Projects.FirstOrDefault(project => project.Id == projectId);
			if (project == null)
			{
				return NotFound();
			}
			var bug = project.Bugs.FirstOrDefault(b => b.Id == bugId);
			if (bug == null)
            {
				return NotFound();
            }
			return Ok(bug);
		}
	}

	
}

