using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CompanyStatistics.Models
{
    public class UserVisitStatistic
    {
        public User User { get; set; }

        public int TotalVisitsCount { get; set; }

        public Section FavoriteSection { get; set; }
    }
}
