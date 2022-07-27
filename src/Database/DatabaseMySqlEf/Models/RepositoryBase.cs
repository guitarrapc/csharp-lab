using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseMySqlEf.Models;
public abstract class RepositoryBase
{
    protected readonly BloggingDbContext Context;

    protected RepositoryBase(BloggingDbContext context)
    {
        Context = context;
    }
}
