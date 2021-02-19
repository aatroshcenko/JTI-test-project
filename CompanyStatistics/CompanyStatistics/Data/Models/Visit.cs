using System;

namespace CompanyStatistics.Data.Models
{
    public class Visit
    {
        public int VisitId { get; set; }

        public int UserId { get; set; }

        public int SectionId { get; set; }

        public DateTime DateTime { get; set; }

        public User User { get; set; }

        public Section Section { get; set; }
    }
}
