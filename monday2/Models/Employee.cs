using System;
using System.Collections.Generic;

namespace monday2.Models;

public partial class Employee
{
    public int EmployeeId { get; set; }

    public string Name { get; set; } = null!;

    public string Position { get; set; } = null!;

    public decimal Salary { get; set; }
}
