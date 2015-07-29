using System;

namespace AlfasoftExercise.DatabaseConfiguration
{
	public class AlfasoftDBContext : DbContext
	{
		public AlfasoftDBContext() : base("name=ThothDataContext")
		{
			Database.SetInitializer<AlfasoftDBContext>(new AlwaysDatabaseInitializer());
		}
		public virtual DbSet<User> Users { get; set; }
	}
}