using DataAccess.Models;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;

namespace DataAccess.Services
{
    public class SQLEmployeesData : IEmployeeData
    {
        private readonly InternshipPhase3DbContext _db;

        public SQLEmployeesData(InternshipPhase3DbContext db)
        {
            _db = db;
        }

        public void Add(Employee employee)
        {
            _db.Employees.Add(employee);
            _db.SaveChanges();
        }

        public void Delete(int id)
        {
            var employee = _db.Employees.Find(id);
            _db.Employees.Remove(employee);
            _db.SaveChanges();
        }

        public Employee Get(int id)
        {
            return _db.Employees.FirstOrDefault(e => e.ID == id);
        }

        public IEnumerable<Employee> GetAll()
        {
            return _db.Employees.Select(
                        empl => new Employee()
                        {
                            ID = empl.ID,
                            Intro = empl.Intro,
                            Name = empl.Name,
                            Picture = empl.Picture,
                            SocialMedia = empl.SocialMedia
                        }).ToList();
        }

        public void Update(Employee employee)
        {
            var _emp = _db.Entry(employee);
            _emp.State = EntityState.Modified;

            _db.SaveChanges();
        }
    }
}
