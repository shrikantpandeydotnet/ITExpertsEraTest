using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ITExpertsEraTest.Models
{
    public class MockEmployeeRepository : IEmployeeRepository
    {
        static List<Employee> _employeeList;

        static MockEmployeeRepository()
        {
            _employeeList = new List<Employee>();

            _employeeList.Add(new Employee() { Id=1, Name="Anjali", Salary=5000, Department="IT" });
            _employeeList.Add(new Employee() { Id=2, Name="Naveen", Salary=50000, Department="HR" });
            _employeeList.Add(new Employee() { Id=3, Name="Varsha", Salary=15000, Department="Admin" });
        }

        public void CreateEmployee(Employee employee)
        {
            _employeeList.Add(employee);
        }

        public void EditEmployee(int id, Employee newEmployee)
        {
            Employee employee = _employeeList.First(employee => employee.Id == id);

            employee.Id = newEmployee.Id;
            employee.Name = newEmployee.Name;
            employee.Salary = newEmployee.Salary;
            employee.Department = newEmployee.Department;
        }

        public List<Employee> GetAllEmployee()
        {
            return _employeeList;
        }

        public Employee GetDetails(int id)
        {
            Employee employeeResult = _employeeList.First(employee => employee.Id == id);

            return employeeResult;
        }
    }
}
