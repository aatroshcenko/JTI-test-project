using System.Collections.Generic;

namespace CompanyStatistics.Data.Models
{
    public class Section
    {
        public int SectionId { get; set; }

        public string Name { get; set; }

        public ICollection<Visit> Visits { get;set; }
    }
}
