using System.Collections.Generic;

namespace AccountingApp.Core
{
    public interface INationalityRepository
    {
        IEnumerable<Nationality> GetAll();
    }
}
