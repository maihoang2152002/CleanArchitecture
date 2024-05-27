using System;
using System.Collections.Generic;

namespace CleanArchitecture.Domain.Entities;

public partial class InitModel
{
    public Guid Id { get; set; }

    public string InitModelName { get; set; }
}
