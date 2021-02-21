using CompanyStatistics.Data;
using CompanyStatistics.Data.Models;
using CompanyStatistics.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace CompanyStatistics.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly CompanyDbContext context;

        public UserRepository(
            [FromServices] CompanyDbContext context)
        {
            this.context = context;
        }

        public IEnumerable<User> GetUsersSortedByVisits(int limit)
        {
            var userIdsSortedByTotalVisitsCount = context.Users
                .FromSqlInterpolated($"EXECUTE [dbo].[GetUsersSortedByTotalVisitsCount] {limit}")
                .ToList()
                .Select(u => u.UserId);

            var usersWithVisits = context.Users
                .AsNoTracking()
                .Where(u => userIdsSortedByTotalVisitsCount.Contains(u.UserId))
                .Include(s => s.Visits)
                .ThenInclude(v => v.Section)
                .ToList();

            return userIdsSortedByTotalVisitsCount.Join(
                usersWithVisits,
                id => id,
                u => u.UserId,
                (id, user) => user);
        }
    }
}
