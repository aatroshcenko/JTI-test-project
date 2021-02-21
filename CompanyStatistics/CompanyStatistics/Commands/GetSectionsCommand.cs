using AutoMapper;
using CompanyStatistics.Commands.Interfaces;
using CompanyStatistics.Models;
using CompanyStatistics.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace CompanyStatistics.Commands
{
    public class GetSectionsCommand : IGetSectionsCommand
    {
        private readonly ISectionRepository sectionRepository;
        private readonly IMapper autoMapper;

        public GetSectionsCommand(
            [FromServices] ISectionRepository sectionRepository,
            [FromServices] IMapper autoMapper)
        {
            this.sectionRepository = sectionRepository;
            this.autoMapper = autoMapper;
        }

        public IEnumerable<Section> Execute()
        {
            var sections = sectionRepository.GetSections();

            return autoMapper.Map<
                IEnumerable<Data.Models.Section>,
                IEnumerable<Section>>(sections);
        }
    }
}
