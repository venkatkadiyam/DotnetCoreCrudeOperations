using System;
using System.Collections.Generic;

namespace jwt_token_based_authentication.models;

public partial class CredentialTable
{
    public int Id { get; set; }

    public string? UserName { get; set; }

    public string? Password { get; set; }

    public string? Role { get; set; }
}
