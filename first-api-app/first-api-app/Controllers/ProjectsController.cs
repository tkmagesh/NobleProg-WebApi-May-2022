using System;
using Microsoft.AspNetCore.Mvc;
using first_api_app.Models;

namespace first_api_app.Controllers
{
	[ApiController]
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

		[HttpGet("{id}", Name ="GetProjectById")]
		public ActionResult<Project> GetProjectById(int id)
		{
			var project = ProjectsService.Current.Projects.FirstOrDefault(p => p.Id == id);
			if (project == null)
            {
				return NotFound();
            }
			return Ok(project);
        }

		[HttpPost]
		public ActionResult<Project> CreateProject(ProjectInput newProjectData)
        {
			var maxProjectId = ProjectsService.Current.Projects.Max(p => p.Id);
			var newProject = new Project
			{
				Id = ++maxProjectId,
				Name = newProjectData.Name,
				IsActive = newProjectData.IsActive
			};
			ProjectsService.Current.Projects.Add(newProject);
			return CreatedAtAction("GetProjectById", new { id = newProject.Id }, newProject);
        }

		[HttpDelete("{id}")]
		public ActionResult<Project> RemoveProject(int id)
		{
			var project = ProjectsService.Current.Projects.FirstOrDefault(p => p.Id == id);
			if (project == null)
			{
				return NotFound();
			}
			ProjectsService.Current.Projects.Remove(project);
			return Ok();
		}
	}
}

