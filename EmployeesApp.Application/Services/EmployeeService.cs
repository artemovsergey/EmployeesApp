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
                                                     decimal? salary = null,
                                                     string sortColumn = "FullName",
                                                     string sortOrder = "ASC")
    {
        return await _repository.GetEmployees(departamentId,
                                              fio, 
                                              date, 
                                              birthdate, 
                                              salary, 
                                              sortColumn, 
                                              sortOrder);
    }

    public async Task Create(Employee e)
    {
        await _repository.Create(e);
    }

    public async Task Delete(Employee e)
    {
        await _repository.Delete(e);
    }

    public async Task Edit(Employee e)
    {
        await _repository.Edit(e);
    }



}
