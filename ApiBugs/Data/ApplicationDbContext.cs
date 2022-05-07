using System;
using ApiBugs.Models;
using Microsoft.EntityFrameworkCore;

namespace ApiBugs.Data
{
	public class ApplicationDbContext : DbContext
	{
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
		{
		}


		public DbSet<bugModel> BugsDb { get; set; }


	}
}

