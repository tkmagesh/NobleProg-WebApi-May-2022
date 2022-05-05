using System;
using first_api_app.Models;

namespace first_api_app
{
	public class ProjectsService
	{
		public IList<Project> Projects = new List<Project>();
      
		public ProjectsService()
		{
			this.Projects.Add(new Project {
				Id = 1,
				Name = "Expense Manager",
				IsActive = true,
				Bugs = new List<Bug>
                {
					new Bug { Id = 1, Name = "User access denied", Description=""},
					new Bug { Id = 2, Name = "Application Not responding", Description=""}
				}

			});
			this.Projects.Add(new Project {
				Id = 2,
				Name = "Bug Tracker",
				IsActive = true,
				Bugs = new List<Bug>
				{
					new Bug { Id = 3, Name = "Server communication failure", Description=""},
					new Bug { Id = 4, Name = "Validation errors", Description=""}
				}
			});
			this.Projects.Add(new Project { Id = 3, Name = "Time Tracker", IsActive = false });
		}

		public static ProjectsService Current { get; } = new ProjectsService();
	}
}

