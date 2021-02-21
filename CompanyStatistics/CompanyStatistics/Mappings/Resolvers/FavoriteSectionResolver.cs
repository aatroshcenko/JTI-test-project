using AutoMapper;
using CompanyStatistics.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CompanyStatistics.Mappings.Resolvers
{
    public class FavoriteSectionResolver : IValueResolver<Data.Models.User, UserVisitStatistic, Section>
    {
        private readonly IMapper autoMapper;
        public FavoriteSectionResolver(
            [FromServices] IMapper autoMapper)
        {
            this.autoMapper = autoMapper;
        }

        public Section Resolve(Data.Models.User source, UserVisitStatistic destination, Section destMember, ResolutionContext context)
        {
            var favoriteSection = source.Visits.GroupBy(
                v => v.SectionId,
                v => v)
                .OrderByDescending(x => x.Count())
                .First().First().Section;

            return autoMapper.Map<Data.Models.Section, Section>(favoriteSection);
        }
    }
}
