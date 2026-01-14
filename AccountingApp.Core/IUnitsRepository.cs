using System.Collections.Generic;

namespace AccountingApp.Core
{
    public interface IUnitsRepository
    {
        IEnumerable<Unit> GetAll();
        void Add(Unit unit);
        void Update(Unit unit);
        void Delete(int id);
    }
}
