using System.Collections.Generic;

namespace AccountingApp.Core
{
    public interface ILookupRepository<T> where T : class
    {
        IEnumerable<T> GetAll();
    }
}
