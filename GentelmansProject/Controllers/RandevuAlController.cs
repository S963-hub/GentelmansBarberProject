using Microsoft.AspNetCore.Mvc;
using GentelmansProject.Models;
using GentelmansProject.Data;

namespace GentelmansProject.Controllers
{

	public class RandevuAlController : Controller
	{
		private readonly ApplicationDbContext context;
		private readonly IWebHostEnvironment environment;
		public RandevuAlController(ApplicationDbContext context, IWebHostEnvironment environment)
		{
			this.context = context;
			this.environment = environment;
		}


	}
}
