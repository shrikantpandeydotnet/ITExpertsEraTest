using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ITExpertsEraTest.Models
{
    public class SqlEmployeeRepository : IEmployeeRepository
    {
        private readonly AppDbContext _context;

        public SqlEmployeeRepository(AppDbContext context)
        {
            _context = context;
        }

        public void CreateEmployee(Employee employee)
        {
            _context.Employees.Add(employee);
            _context.SaveChanges();
        }

        public void EditEmployee(int id, Employee objEmployee)
        {
            Employee employee = _context.Employees.First(employee => employee.Id == id);

            employee.Id = objEmployee.Id;
            employee.Name = objEmployee.Name;
            employee.Salary = objEmployee.Salary;
            employee.Department = objEmployee.Department;

            _context.Update(employee);
            _context.SaveChanges();
        }

        public List<Employee> GetAllEmployee()
        {
            return _context.Employees.ToList();
        }

        public Employee GetDetails(int id)
        {
            throw new NotImplementedException();
        }
    }
}
