using AutoMapper;
using CompanyStatistics.Mappings.Resolvers;
using CompanyStatistics.Models;
using System.Linq;

namespace CompanyStatistics.Mappings
{
    public class ProjectModelsProfile : Profile
    {
        public ProjectModelsProfile()
        {
            CreateMap<Data.Models.Section, Section>();
            CreateMap<Data.Models.Section, SectionVisitStatistic>()
                .ForMember(dest => dest.Section, opt => opt.MapFrom(s => s))
                .ForMember(dest => dest.TotalVisitsCount, opt => opt.MapFrom(s => s.Visits.Count));

            CreateMap<Data.Models.User, User>();
            CreateMap<Data.Models.User, UserVisitStatistic>()
                .ForMember(dest => dest.User, opt => opt.MapFrom(u => u))
                .ForMember(dest => dest.TotalVisitsCount, opt => opt.MapFrom(u => u.Visits.Count))
                .ForMember(dest => dest.FavoriteSection, opt =>
                {
                    opt.PreCondition(u => u.Visits.Any());
                    opt.MapFrom<FavoriteSectionResolver>();
                });
        }
    }
}
