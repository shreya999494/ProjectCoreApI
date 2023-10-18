using System;
using System.Collections.Generic;

namespace ProjectCoreApI.Database;

public partial class User
{
    public int UId { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public string? Email { get; set; }

    public string? Password { get; set; }
}
