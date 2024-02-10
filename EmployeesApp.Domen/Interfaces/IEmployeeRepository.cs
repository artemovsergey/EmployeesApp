using EmployeesApp.Domen.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeesApp.Domen.Interfaces;

public interface IEmployeeRepository
{
    Task<IEnumerable<Employee>> GetEmployees();
    Task<Employee> GetEmployeesById(int id);
    Task CreateEmployee();
    Task DeleteEmployee(Employee employee);
}
