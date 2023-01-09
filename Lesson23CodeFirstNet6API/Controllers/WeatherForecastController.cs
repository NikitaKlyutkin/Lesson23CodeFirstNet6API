using Lesson23CodeFirstNet6API.Database;
using Lesson23CodeFirstNet6API.Database.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Lesson23CodeFirstNet6API.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class WeatherForecastController : ControllerBase
	{
		private static readonly string[] Summaries = new[]
		{
			"Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
		};

		private readonly ILogger<WeatherForecastController> _logger;
		private readonly MyDBContext _context;

		public WeatherForecastController(ILogger<WeatherForecastController> logger, MyDBContext context)
		{
			_logger = logger;
			_context = context;
		}

		[HttpGet(Name = "GetPlayers")]
		public IEnumerable<Player> Get()
		{
			return _context.Players.ToList();
		}
	}
}