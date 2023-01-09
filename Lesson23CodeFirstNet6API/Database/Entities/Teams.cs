namespace Lesson23CodeFirstNet6API.Database.Entities
{
	public class Teams
	{
		public Guid id { get; set; }
		public string Name { get; set; }
		public float Rate { get; set; }
		public List<Traner> Traners { get; set; }
	} 
}
