namespace Lesson23CodeFirstNet6API.Database.Entities
{
	public class Traner
	{
		public Guid id { get; set; }
		public string Name { get; set; }
		public string Surname { get; set; }
		public List<Teams> Teamses { get; set; }
	}
}