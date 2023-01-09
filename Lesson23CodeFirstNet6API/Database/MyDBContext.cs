using Lesson23CodeFirstNet6API.Database.Entities;
using Microsoft.EntityFrameworkCore;

namespace Lesson23CodeFirstNet6API.Database
{
	public class MyDBContext : DbContext
	{
		public MyDBContext(DbContextOptions opts) : base(opts)
		{
			Database.EnsureDeleted();
			Database.EnsureCreated();
		}

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer("Data Source= DESKTOP-522TD1V\\TEW_SQLEXPRESS; Initial Catalog=FootBallCodeFirst;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
		}
		public DbSet<Player> Players { get; set; }
		public DbSet<Teams> Teamses { get; set; }
		public DbSet<Traner> Traners { get; set; }
		public DbSet<Group> Groups { get; set; }
		public DbSet<TimeTable> TimeTables { get; set; }

		
	}
}
