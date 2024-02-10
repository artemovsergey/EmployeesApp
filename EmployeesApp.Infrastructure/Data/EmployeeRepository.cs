using EmployeesApp.Domen.Interfaces;
using EmployeesApp.Domen.Models;
using Microsoft.EntityFrameworkCore;
using System.Security.AccessControl;

namespace EmployeesApp.Infrastructure.Data;

public class EmployeeRepository : IEmployeeRepository
{
    private readonly EmployeeContext _db;
    public EmployeeRepository(EmployeeContext db)
    {
        _db = db;
    }

    public async Task<IEnumerable<Employee>> GetEmployees()
    {
        return await _db.Employees.ToListAsync();
    }

    public Task CreateEmployee()
    {
        throw new NotImplementedException();
    }

    public Task DeleteEmployee(Employee employee)
    {
        throw new NotImplementedException();
    }

    public Task<Employee> GetEmployeesById(int id)
    {
        throw new NotImplementedException();
    }
}
