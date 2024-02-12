using EmployeesApp.Domen.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeesApp.Domen.Interfaces;

public interface IEmployeeRepository
{
    Task<IEnumerable<Employee>> GetEmployees(int departamentId = 0,
                                             string? fio = null,
                                             DateTime? date = null,
                                             DateTime? birthdate = null,
                                             decimal? salary = null
                                             );
    Task<Employee> GetEmployeesById(int id);
    Task CreateEmployee();
    Task<Employee> EditEmployee();
    Task DeleteEmployee(Employee employee);
}
