using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApplication.Data
{
    public class BancaDati : DbContext
	{


		public DbSet<Piatto> Piatti { get; set; }
		public DbSet<Portata> Portate { get; set; }
		public DbSet<Stagione> Stagioni { get; set; }
		public DbSet<Allergene> Allergeni { get; set; }

		public BancaDati(DbContextOptions options) : base(options) { }
	}
}





