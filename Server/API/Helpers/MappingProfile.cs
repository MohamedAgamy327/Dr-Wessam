using AutoMapper;
using API.DTO.UserDTO;
using Domain.Entities;
using API.DTO.Vendor;
using API.DTO.Vehicle;
using API.DTO.Driver;

namespace API.Helpers
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            // API DTO to Entity
            CreateMap<VendorForAddDTO, Vendor>();
            CreateMap<VendorForEditDTO, Vendor>();
            CreateMap<VehicleForAddDTO, Vehicle>();
            CreateMap<VehicleForEditDTO, Vehicle>();
            CreateMap<DriverForAddDTO, Driver>();
            CreateMap<DriverForEditDTO, Driver>();

            CreateMap<UserForAddDTO, User>();

            // Entity to API DTO
            CreateMap<Vendor, VendorForGetDTO>()
             .ForMember(dest => dest.Department, opt => opt.MapFrom(src => src.Department.ToString()));
            CreateMap<Vehicle, VehicleForGetDTO>()
             .ForMember(dest => dest.VendorName, opt => opt.MapFrom(src => src.Vendor.Name));
            CreateMap<Driver, DriverForGetDTO>()
                 .ForMember(dest => dest.VendorName, opt => opt.MapFrom(src => src.Vendor.Name))
                 .ForMember(dest => dest.LicenseType, opt => opt.MapFrom(src => src.LicenseType.ToString()));
        }

    }
}
