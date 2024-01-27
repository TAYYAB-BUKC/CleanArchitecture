using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Core.Entities
{
    public class Team
    {
        public int teamId { get; set; }
        public string? teamName { get; set; }
        public string? teamImage { get; set; }
        public string? teamBio { get; set; }
        public string? teamLeadName { get; set; }
        public bool isActive { get; set; }
        public bool? isDeleted { get; set; }
        public int? createdBy { get; set; }
        public DateTime? createdDate { get; set; }
        public int? updatedBy { get; set; }
        public DateTime? updateDate { get; set; }
    }
}