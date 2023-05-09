using System;
using System.Collections.Generic;

namespace ProjectManagement.MODEL;

public partial class Project
{
    public int Id { get; set; }

    public string ProjectName { get; set; } = null!;

    public string ManagerName { get; set; } = null!;

    public string StartDate { get; set; } = null!;

    public string? FinishDate { get; set; }

    public string Summary { get; set; } = null!;

    public int IdStatus { get; set; }

    public virtual Status IdStatusNavigation { get; set; } = null!;
}
