namespace Lesson23CodeFirstNet6API.Database.Entities
{
	public class Player
	{
		public Guid id { get; set; }
		public string Name { get; set; }
		public string Surname { get; set; }
		public int Age { get; set; }
		public Teams Teams { get; set; }
		public float Salary { get; set; }
	}
}
