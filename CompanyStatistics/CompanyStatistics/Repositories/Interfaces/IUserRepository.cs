using CompanyStatistics.Data.Models;
using System.Collections.Generic;

namespace CompanyStatistics.Repositories.Interfaces
{
    public interface IUserRepository
    {
        IEnumerable<User> GetUsersSortedByVisits(int limit);
    }
}
