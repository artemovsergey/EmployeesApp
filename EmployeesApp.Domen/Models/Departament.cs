﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeesApp.Domen.Models;

public class Departament
{
    public int Id { get; set; }
    public string Name { get; set; }
    public virtual ICollection<Employee> Employees { get; set; } = null;
}
