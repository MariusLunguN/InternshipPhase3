using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Website.Models
{
    public class AboutUsViewModel
    {
        public int ID { get; set; }

        public string Title { get; set; }

        public IEnumerable<Employee> EmployeeList { get; set; }
    }
}