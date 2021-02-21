using CompanyStatistics.Data;
using CompanyStatistics.Data.Models;
using CompanyStatistics.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace CompanyStatistics.Repositories
{
    public class SectionRepository : ISectionRepository
    {
        private readonly CompanyDbContext context;

        public SectionRepository(
            [FromServices] CompanyDbContext context)
        {
            this.context = context;
        }

        public IEnumerable<Section> GetSections()
        {
            return context.Sections
                .AsNoTracking()
                .ToList();
        }


        public IEnumerable<Section> GetSectionsSortedByVisits(int limit)
        {
            var sectionIdsSortedByTotalVisitsCount = context.Sections
                .FromSqlInterpolated($"EXECUTE [dbo].[GetSectionsSortedByTotalVisitsCount] {limit}")
                .ToList()
                .Select(s => s.SectionId);

            var sectionsWithVisits = context.Sections
                .AsNoTracking()
                .Where(s => sectionIdsSortedByTotalVisitsCount.Contains(s.SectionId))
                .Include(s => s.Visits)
                .ToList();

            return sectionIdsSortedByTotalVisitsCount.Join(
                sectionsWithVisits,
                id => id, 
                s => s.SectionId,
                (id, section) => section);


        }
    }
}
