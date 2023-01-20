using System;
using System.Collections.Generic;

namespace jwt_token_based_authentication.models;

public partial class EmpList
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Designation { get; set; }

    public long? Salary { get; set; }
}
