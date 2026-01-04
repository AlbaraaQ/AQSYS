using System.Collections.Generic;

namespace AccountingApp.Core
{
    public interface IBranchesRepository
    {
        IEnumerable<Branch> GetAll();
    }
}
