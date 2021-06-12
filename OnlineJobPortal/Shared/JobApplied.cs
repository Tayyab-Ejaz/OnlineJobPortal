using System;
using System.Collections.Generic;

#nullable disable

namespace OnlineJobPortal.Shared
{
    public partial class JobApplied
    {
        public int Id { get; set; }
        public int? CandidateId { get; set; }
        public int? JobId { get; set; }
        public string Status { get; set; }

        public virtual Candidate Candidate { get; set; }
        public virtual Job Job { get; set; }
    }
}
