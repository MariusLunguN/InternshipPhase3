using System.Collections.Generic;

namespace DataAccess.Models
{
    public class EmployeeComponent
    {
        public int ID { get; set; }

        public string Title { get; set; }

        public IEnumerable<Employee> EmployeeList { get; set; }
    }
}
