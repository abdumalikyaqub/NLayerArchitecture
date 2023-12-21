using System;
using System.Collections.Generic;

namespace StudentManagement.Infrastructure;

public partial class StudentScaffold
{
    public int Id { get; set; }

    public string FullName { get; set; } = null!;

    public string? Citizenship { get; set; }

    public string? Nationality { get; set; }

    public string? PassportData { get; set; }

    public string? PhoneNumber { get; set; }

    public string? MaritalStatus { get; set; }

    public string? FormOfStudy { get; set; }

    public string? BasisOfStudy { get; set; }
}
