using AutoMapper;
using WebStarterDBApp1.Models;
using WebStarterDBApp1.DTO;

namespace WebStarterDBApp1.Configuration
{
    public class MapperConfig : Profile
    {
        public MapperConfig()
        {
            CreateMap<StudentInsertDTO, Student>().ReverseMap();
            CreateMap<StudentUpdateDTO, Student>().ReverseMap();
            CreateMap<StudentReadOnlyDTO, Student>().ReverseMap();
        }
    }
}
