namespace DatabaseMySqlEf.Models;
public abstract class RepositoryBase
{
    protected readonly BloggingDbContext Context;

    protected RepositoryBase(BloggingDbContext context)
    {
        Context = context;
    }
}
