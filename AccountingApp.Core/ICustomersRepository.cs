using System.Collections.Generic;

namespace AccountingApp.Core
{
    public interface ICustomersRepository
    {
        IEnumerable<Customer> GetByType(int type);
        Customer GetById(int id);
        void Add(Customer customer);
        void Update(Customer customer);
        void Delete(int id);
    }
}
