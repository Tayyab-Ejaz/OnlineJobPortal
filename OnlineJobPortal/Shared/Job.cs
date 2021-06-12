using System;
using System.Collections.Generic;

#nullable disable

namespace OnlineJobPortal.Shared
{
    public partial class Job
    {
        public Job()
        {
            JobApplieds = new HashSet<JobApplied>();
        }

        public int Id { get; set; }
        public int? EmpId { get; set; }
        public string Description { get; set; }
        public DateTime? Date { get; set; }
        public decimal? Salary { get; set; }
        public string Loc { get; set; }
        public string Category { get; set; }

        public virtual Employer Emp { get; set; }
        public virtual ICollection<JobApplied> JobApplieds { get; set; }
    }
}
