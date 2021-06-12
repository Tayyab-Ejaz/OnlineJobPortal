using System;
using System.Collections.Generic;

#nullable disable

namespace OnlineJobPortal.Shared
{
    public partial class Candidate
    {
        public Candidate()
        {
            JobApplieds = new HashSet<JobApplied>();
        }

        public int Id { get; set; }
        public string Fname { get; set; }
        public string Lname { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string StAddress { get; set; }
        public string City { get; set; }
        public string Provice { get; set; }
        public byte[] Image { get; set; }
        public string Tittle { get; set; }
        public decimal? Phone { get; set; }
        public string Degree { get; set; }

        public virtual ICollection<JobApplied> JobApplieds { get; set; }
    }
}
