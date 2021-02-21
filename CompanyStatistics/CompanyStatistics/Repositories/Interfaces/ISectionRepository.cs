using CompanyStatistics.Data.Models;
using System.Collections.Generic;

namespace CompanyStatistics.Repositories.Interfaces
{
    public interface ISectionRepository
    {
        IEnumerable<Section> GetSections();

        IEnumerable<Section> GetSectionsSortedByVisits(int limit);
    }
}
