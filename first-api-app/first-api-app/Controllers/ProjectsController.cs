using System;
using Microsoft.AspNetCore.Mvc;
using first_api_app.Models;

namespace first_api_app.Controllers
{
	[Route("api/projects")]
	public class ProjectsController : ControllerBase
	{
		public ProjectsController()
		{
			
		}

		[HttpGet()]
		public ActionResult<IList<Project>> GetProjects()
        {

			var projects = ProjectsService.Current.Projects;

			//return new JsonResult(projects);
			return Ok(projects);
        }

		[HttpGet("{id}")]
		public ActionResult<Project> GetProjectById(int id)
		{
			var project = ProjectsService.Current.Projects.FirstOrDefault(p => p.Id == id);
			if (project == null)
            {
				return NotFound();
            }
			return Ok(project);
        }

		[HttpPost()]
		public string CreateProject()
        {
			return "A new project is created!";
        }
	}
}

