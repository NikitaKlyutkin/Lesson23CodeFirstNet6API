using Microsoft.VisualBasic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lesson23CodeFirstNet6API.Database.Entities
{
	public class TimeTable
	{
		public Guid id { get; set; }
		public Group Groups { get; set; }
		
		[ForeignKey("TeamAID")]
		public Teams? TeamA { get; set; }
		[ForeignKey("TeamBID")]
		public Teams? TeamB { get; set;}
		public DateTime Time { get; set; }
	}
}
