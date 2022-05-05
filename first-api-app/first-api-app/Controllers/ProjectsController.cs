using System;
using Microsoft.AspNetCore.Mvc;

namespace first_api_app.Controllers
{
	[Route("api/projects")]
	public class ProjectsController : ControllerBase
	{
		public ProjectsController()
		{
			
		}

		[HttpGet()]
		public ActionResult GetProjects()
        {
			
			var projects = new List<Object>
			{
				new {id = 1, name = "Expense Manager"},
				new {id = 2, name = "Bug Tracker"}
			};

			return new JsonResult(projects);
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

