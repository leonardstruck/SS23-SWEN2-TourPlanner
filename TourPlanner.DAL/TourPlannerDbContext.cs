using System;
using Microsoft.EntityFrameworkCore;

namespace TourPlanner.DAL
{
	public class TourPlannerDbContext : DbContext
	{
		public TourPlannerDbContext()
		{
		}

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
			=> optionsBuilder.UseNpgsql("Host=postgres;Database=tourplanner;Username=postgres;Password=postgres");
	}
}

