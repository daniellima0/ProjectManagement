using System;
using System.Collections.Generic;

namespace ProjectManagement.DAL.DBContext;

public partial class Status
{
    public int Id { get; set; }

    public string Status1 { get; set; } = null!;

    public virtual ICollection<Project> Projects { get; set; } = new List<Project>();
}
