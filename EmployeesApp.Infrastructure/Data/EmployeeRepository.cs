

namespace EmployeesApp.Infrastructure.Data;

public class EmployeeRepository : IEmployeeRepository
{

    private readonly EmployeeContext _db;
    public EmployeeRepository(EmployeeContext db)
    {
        _db = db;
    }

    public async Task Create(Employee e)
    {
        var employee = await _db.Employees.AddAsync(e);
        await _db.SaveChangesAsync();
    }

    public async Task Delete(Employee e)
    {
        var employee = _db.Employees.Remove(e);
        await _db.SaveChangesAsync();
    }

    public async Task Edit(Employee e)
    {
        _db.Entry(e).State = EntityState.Modified;
        await _db.SaveChangesAsync();
    }

    public async Task<IEnumerable<Employee>> GetEmployees(int departamentId = 0,
                                                    string? fio = null,
                                                    DateTime? date = null,
                                                    DateTime? birthdate = null,
                                                    decimal? salary = null,
                                                    string sortColumn = "FullName",
                                                    string sortOrder = "ASC"
                                                    )
    {
        IQueryable<Employee> query = _db.Employees;

        if (departamentId != 0)
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

        return await query.OrderBy($"{sortColumn} {sortOrder}")  //OrderBy(e => e.FullName)
                          .Skip(0)
                          .Take(query.Count())
                          .ToListAsync();
    }
}
