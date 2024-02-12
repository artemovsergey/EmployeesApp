using EmployeesApp.Domen.Interfaces;
using EmployeesApp.Domen.Models;
using Microsoft.Data.SqlClient;
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

    public Task<Employee> EditEmployee()
    {
        throw new NotImplementedException();
    }

    public async Task<IEnumerable<Employee>> GetEmployees(int departamentId = 0,
                                                    string? fio = null,
                                                    DateTime? date = null,
                                                    DateTime? birthdate = null,
                                                    decimal? salary = null)
    {

        IQueryable<Employee> query = _db.Employees;

        if(departamentId != 0)
        {
            query = query.Where(e => e.DepartamentId == departamentId);
        }

        if (fio != null)
        {
            query = query.Where(e => e.FullName.Contains(fio));
        }

        if (date != null)
        {
            query = query.Where(e => e.DateEmployment == date);
        }

        if (birthdate != null)
        {
            query = query.Where(e => e.BirthDay == birthdate);
        }

        if (salary != null)
        {
            query = query.Where(e => e.Salary == salary);
        }

        return await query.OrderBy(e => e.FullName)
                          .Skip(0)
                          .Take(query.Count())
                          .ToListAsync();
    }
}
