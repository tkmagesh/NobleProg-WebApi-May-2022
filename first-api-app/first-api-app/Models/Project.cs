﻿using System;
namespace first_api_app.Models
{
	public class Project
	{
		public int Id { get; set; }
		public string Name { get; set; } = string.Empty;
		public bool IsActive { get; set; }
	}
}

