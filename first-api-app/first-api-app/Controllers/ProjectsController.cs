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
		public ActionResult GetProjectById(int id)
		{
			var project = new {
				id = id,
				name = "Project - " + id
			};
			return new JsonResult(project);
        }

		[HttpPost()]
		public string CreateProject()
        {
			return "A new project is created!";
        }
	}
}

