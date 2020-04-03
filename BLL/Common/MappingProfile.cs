using AutoMapper;
using BLL.Dtos;
using DAL.Entities;

namespace BLL.Common
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<SalesDto, Sale>().ReverseMap();
            CreateMap<NumbersDto, Number>().ReverseMap();
            CreateMap<PackagesDto, Package>().ReverseMap();
            CreateMap<StatusDto, Status>().ReverseMap();
            CreateMap<VendorsDto, Vendor>().ReverseMap();

        }
    }
}