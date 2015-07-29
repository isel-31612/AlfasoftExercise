using AlfasoftExercise.Models;
using System;
using System.Data.Entity;

namespace AlfasoftExercise.DatabaseConfiguration
{
	public class AlfasoftDBContext : DbContext
	{
		public AlfasoftDBContext() : base("name=AlfasoftDataContext")
		{
			Database.SetInitializer(new CreateDatabaseIfNotExists<AlfasoftDBContext>());
		}
		public virtual DbSet<User> Users { get; set; }
	}
}