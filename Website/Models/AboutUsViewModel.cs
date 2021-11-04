using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Website.Models
{
    public class AboutUsViewModel
    {
        public string Title { get; set; }

        public IEnumerable<Employee> EmployeeList { get; set; }
    }
}