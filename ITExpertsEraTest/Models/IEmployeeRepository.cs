using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ITExpertsEraTest.Models
{
    public interface IEmployeeRepository
    {
        List<Employee> GetAllEmployee();

        void CreateEmployee(Employee employee);

        // Show Details of the Employee

        Employee GetDetails(int id);

        // Edit Employee Detais

        void EditEmployee(int id, Employee objEmployee);

        // Delete Employee

    }
}
