using AutoMapper;
using CompanyStatistics.Commands.Interfaces;
using CompanyStatistics.Models;
using CompanyStatistics.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace CompanyStatistics.Commands
{
    public class GetUsersVisitStatisticCommand : IGetUsersVisitStatisticCommand
    {
        private readonly IUserRepository userRepository;
        private readonly IMapper autoMapper;

        public GetUsersVisitStatisticCommand(
            [FromServices] IUserRepository userRepository,
            [FromServices] IMapper autoMapper)
        {
            this.userRepository = userRepository;
            this.autoMapper = autoMapper;
        }
        public IEnumerable<UserVisitStatistic> Execute(int limit)
        {
            var usersSortedByVisits = userRepository.GetUsersSortedByVisits(limit);

            return autoMapper.Map<
                IEnumerable<Data.Models.User>,
                IEnumerable<UserVisitStatistic>>(usersSortedByVisits);
        }
    }
}
