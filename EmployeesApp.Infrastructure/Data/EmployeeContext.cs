using EmployeesApp.Domen.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeesApp.Infrastructure.Data;

public class EmployeeContext : DbContext
{

    public EmployeeContext(DbContextOptions<EmployeeContext> options) : base(options)
    {

    }

    public DbSet<Employee> Employees { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=Myrtex;Trusted_Connection=True;");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Employee>()
            .Property(e => e.Salary)
            .HasColumnType("decimal(18,2)"); // Указывает тип столбца с точностью  18 цифр и  2 знаками после запятой
    }

}
