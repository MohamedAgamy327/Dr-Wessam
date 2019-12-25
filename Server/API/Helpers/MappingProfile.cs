using AutoMapper;
using Domain.Entities;
using API.DTO.Occupation;
using API.DTO.Knowing;
using API.DTO.MedicineType;

namespace API.Helpers
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            // API DTO to Entity
            CreateMap<OccupationForAddDTO, Occupation>();
            CreateMap<OccupationForEditDTO, Occupation>();
            CreateMap<KnowingForAddDTO, Knowing>();
            CreateMap<KnowingForEditDTO, Knowing>();
            CreateMap<MedicineTypeForAddDTO, MedicineType>();
            CreateMap<MedicineTypeForEditDTO, MedicineType>();

            // Entity to API DTO
            CreateMap<Occupation, OccupationForGetDTO>();
            CreateMap<Knowing, KnowingForGetDTO>();
            CreateMap<MedicineType, MedicineTypeForGetDTO>();
        }

    }
}
