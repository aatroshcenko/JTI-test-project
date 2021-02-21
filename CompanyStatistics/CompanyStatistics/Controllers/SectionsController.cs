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
    public class SectionsController : Controller
    {
        [HttpGet("")]
        public IEnumerable<Section> GetSections(
            [FromServices] IGetSectionsCommand command)
        {
            return command.Execute();
        }
    }
}
