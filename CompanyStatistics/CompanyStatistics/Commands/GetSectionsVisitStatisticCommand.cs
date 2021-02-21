using AutoMapper;
using CompanyStatistics.Commands.Interfaces;
using CompanyStatistics.Models;
using CompanyStatistics.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace CompanyStatistics.Commands
{
    public class GetSectionsVisitStatisticCommand : IGetSectionsVisitStatisticCommand
    {
        private readonly ISectionRepository sectionRepository;
        private readonly IMapper autoMapper;

        public GetSectionsVisitStatisticCommand(
            [FromServices] ISectionRepository sectionRepository,
            [FromServices] IMapper autoMapper)
        {
            this.sectionRepository = sectionRepository;
            this.autoMapper = autoMapper;
        }
        public IEnumerable<SectionVisitStatistic> Execute(int limit)
        {
            var sectionsSortedByVisits = sectionRepository.GetSectionsSortedByVisits(limit);

            return autoMapper.Map<
                IEnumerable<Data.Models.Section>,
                IEnumerable<SectionVisitStatistic>>(sectionsSortedByVisits);
        }
    }
}
