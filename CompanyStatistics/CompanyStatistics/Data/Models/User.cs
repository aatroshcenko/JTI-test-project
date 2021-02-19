using System.Collections.Generic;

namespace CompanyStatistics.Data.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public ICollection<Visit> Visits { get; set; }
    }
}
