using CompanyStatistics.Models;
using System.Collections.Generic;

namespace CompanyStatistics.Commands.Interfaces
{
    public interface IGetSectionsVisitStatisticCommand
    {
        IEnumerable<SectionVisitStatistic> Execute(int limit);
    }
}
