using System.Collections.Generic;

namespace AccountingApp.Core
{
    public interface IEmployeesRepository
    {
        IEnumerable<Employee> GetAll();
        Employee GetById(int id);
        void Add(Employee employee, IEnumerable<int> branchIds);
        void Update(Employee employee, IEnumerable<int> branchIds);
        void Delete(int id);
        IEnumerable<Branch> GetEmployeeBranches(int employeeId);
    }
}
