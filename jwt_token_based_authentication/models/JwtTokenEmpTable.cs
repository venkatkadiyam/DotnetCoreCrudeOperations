using System;
using System.Collections.Generic;

namespace jwt_token_based_authentication.models;

public partial class JwtTokenEmpTable
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Designation { get; set; }

    public long? Salary { get; set; }

    public string? Role { get; set; }

    public string? UserName { get; set; }

    public string? Password { get; set; }

    public string? Token { get; set; }
}
