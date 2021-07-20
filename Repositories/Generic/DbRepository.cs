using System;
using Domain;

namespace Repositories.Generic
{
    public interface DbRepository<T> : IDbRepository<T>
    where T : class
    {

    }

}
