using CompanyStatistics.Models;
using System.Collections.Generic;

namespace CompanyStatistics.Commands.Interfaces
{
    public interface IGetSectionsCommand
    {
        IEnumerable<Section> Execute();
    }
}
