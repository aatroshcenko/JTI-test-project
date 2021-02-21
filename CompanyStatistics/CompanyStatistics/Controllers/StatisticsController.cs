using CompanyStatistics.Commands.Interfaces;
using CompanyStatistics.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CompanyStatistics.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StatisticsController : Controller
    {
        [HttpGet("sectionsVisit")]
        public IEnumerable<SectionVisitStatistic> GetSectionsVisitStatistic(
            [FromServices] IGetSectionsVisitStatisticCommand command,
            [FromQuery] int limit)
        {
            return command.Execute(limit);
        }

        [HttpGet("usersVisit")]
        public IEnumerable<UserVisitStatistic> GetUsersVisitStatistic(
            [FromServices] IGetUsersVisitStatisticCommand command,
            [FromQuery] int limit)
        {
            return command.Execute(limit);
        }
    }
}
