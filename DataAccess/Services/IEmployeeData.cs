using DataAccess.Models;
using System.Collections.Generic;

namespace DataAccess.Services
{
    public interface IEmployeeData
    {
        void Add(Employee employee);
        void Update(Employee employee);
        void Delete(int id);
        IEnumerable<Employee> GetAll();
        Employee Get(int id);
    }
}
