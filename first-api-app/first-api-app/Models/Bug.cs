using System;
namespace first_api_app.Models
{
	public class Bug
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
		public bool IsClosed { get; set; }
		public Bug()
		{
		}
	}
}

