using System;

namespace CompetitionWebsite.Repositories
{
    public abstract class BaseRepository<TEntity> where TEntity : class
    {

        public CompetitionWebsiteContext CreateContext()
        {
            return new CompetitionWebsiteContext();
        }
    }
}
