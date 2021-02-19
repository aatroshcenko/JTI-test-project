using CompanyStatistics.Data;
using CompanyStatistics.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CompanyStatistics.Extensions
{
    public static class CompanyDbContextExtensions
    {
        public static void SeedDatabase(this CompanyDbContext context)
        {
            if (!context.Users.Any())
            {
                var users = new List<User>
                {
                    new User { FirstName = "Алексей", LastName = "Говрилов" },
                    new User { FirstName = "Михаил", LastName = "Штац" },
                    new User { FirstName = "Иван", LastName = "Елесеев" },
                    new User { FirstName = "Иван", LastName = "Попик" },
                    new User { FirstName = "Евгений", LastName = "Шастун" },
                    new User { FirstName = "Евгений", LastName = "Петров" },
                    new User { FirstName = "Антон", LastName = "Добрынин" },
                    new User { FirstName = "Александор", LastName = "Добронравов" },
                    new User { FirstName = "Егор", LastName = "Мащук" },
                    new User { FirstName = "Мария", LastName = "Славич" },
                    new User { FirstName = "Алёна", LastName = "Тефлеева" },
                };
                context.AddRange(users);

                context.SaveChanges();
            }

            if (!context.Sections.Any())
            {
                var sections = new List<Section>
                {
                    new Section { Name = "Новости" },
                    new Section { Name = "Реклама" },
                    new Section { Name = "Заказы" },
                    new Section { Name = "Запасы на складе" },
                };
                context.AddRange(sections);

                context.SaveChanges();
            }

            if (!context.Visits.Any())
            {
                var now = DateTime.UtcNow;
                var visits = new List<Visit>
            {
                new Visit { UserId = 1, SectionId = 1, DateTime = now },
                new Visit { UserId = 1, SectionId = 1, DateTime = now.AddMinutes(-1) },
                new Visit { UserId = 2, SectionId = 1, DateTime = now.AddMinutes(-3) },
                new Visit { UserId = 2, SectionId = 1, DateTime = now.AddMinutes(-5) },
                new Visit { UserId = 2, SectionId = 2, DateTime = now.AddMinutes(-10) },
                new Visit { UserId = 2, SectionId = 3, DateTime = now.AddMinutes(-11) },
                new Visit { UserId = 3, SectionId = 3, DateTime = now.AddMinutes(-12) },
                new Visit { UserId = 3, SectionId = 3, DateTime = now.AddMinutes(-15) },
                new Visit { UserId = 3, SectionId = 3, DateTime = now.AddMinutes(-16) },
                new Visit { UserId = 3, SectionId = 3, DateTime = now.AddMinutes(-17) },
                new Visit { UserId = 4, SectionId = 3, DateTime = now.AddMinutes(-20) },
                new Visit { UserId = 4, SectionId = 3, DateTime = now.AddMinutes(-21) },
                new Visit { UserId = 4, SectionId = 2, DateTime = now.AddMinutes(-22) },
                new Visit { UserId = 4, SectionId = 1, DateTime = now.AddMinutes(-25) },
                new Visit { UserId = 4, SectionId = 1, DateTime = now.AddMinutes(-27) },
                new Visit { UserId = 5, SectionId = 1, DateTime = now.AddMinutes(-28) },
                new Visit { UserId = 5, SectionId = 1, DateTime = now.AddMinutes(-38) },
                new Visit { UserId = 5, SectionId = 1, DateTime = now.AddMinutes(-40) },
                new Visit { UserId = 5, SectionId = 1, DateTime = now.AddMinutes(-41) },
                new Visit { UserId = 6, SectionId = 2, DateTime = now.AddMinutes(-44) },
                new Visit { UserId = 6, SectionId = 3, DateTime = now.AddMinutes(-50) },
                new Visit { UserId = 7, SectionId = 3, DateTime = now.AddMinutes(-51) },
                new Visit { UserId = 7, SectionId = 1, DateTime = now.AddMinutes(-56) },
                new Visit { UserId = 7, SectionId = 4, DateTime = now.AddMinutes(-60) },
                new Visit { UserId = 7, SectionId = 3, DateTime = now.AddMinutes(-71) },
                new Visit { UserId = 8, SectionId = 3, DateTime = now.AddMinutes(-72) },
                new Visit { UserId = 8, SectionId = 4, DateTime = now.AddMinutes(-75) },
                new Visit { UserId = 8, SectionId = 1, DateTime = now.AddMinutes(-76) },
                new Visit { UserId = 9, SectionId = 3, DateTime = now.AddMinutes(-77) },
                new Visit { UserId = 9, SectionId = 3, DateTime = now.AddMinutes(-80) },
                new Visit { UserId = 9, SectionId = 3, DateTime = now.AddMinutes(-81) },
                new Visit { UserId = 9, SectionId = 1, DateTime = now.AddMinutes(-82) },
                new Visit { UserId = 9, SectionId = 1, DateTime = now.AddMinutes(-85) },
                new Visit { UserId = 9, SectionId = 3, DateTime = now.AddMinutes(-87) },
                new Visit { UserId = 10, SectionId = 1, DateTime = now.AddMinutes(-88) },
                new Visit { UserId = 10, SectionId = 1, DateTime = now.AddMinutes(-90) },
                new Visit { UserId = 10, SectionId = 1, DateTime = now.AddMinutes(-94) },
                new Visit { UserId = 11, SectionId = 1, DateTime = now.AddMinutes(-101) },
                new Visit { UserId = 11, SectionId = 2, DateTime = now.AddMinutes(-104) },
            };
                context.AddRange(visits);

                context.SaveChanges();
            }
            
        }
    }
}
