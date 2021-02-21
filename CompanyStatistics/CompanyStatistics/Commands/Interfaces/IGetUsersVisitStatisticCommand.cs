using CompanyStatistics.Models;
using System.Collections.Generic;

namespace CompanyStatistics.Commands.Interfaces
{
    public interface IGetUsersVisitStatisticCommand
    {
        IEnumerable<UserVisitStatistic> Execute(int limit);
    }
}
