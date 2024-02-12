using EmployeesApp.Domen.Interfaces;
using EmployeesApp.Domen.Models;

namespace EmployeesApp.Application.Services;

public class EmployeeService
{
    private readonly IEmployeeRepository _repository;
    public EmployeeService(IEmployeeRepository repository)
    {
        _repository = repository;
    }

    public async Task<IEnumerable<Employee>> GetEmployees(int departamentId = 0,
                                                     string? fio = null,
                                                     DateTime? date = null,
                                                     DateTime? birthdate = null,
                                                     decimal? salary = null)
    {
        return await _repository.GetEmployees(departamentId, fio, date, birthdate, salary);
    }


}
