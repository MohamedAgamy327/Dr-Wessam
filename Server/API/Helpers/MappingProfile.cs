using AutoMapper;
using Domain.Entities;
using API.DTO.Occupation;
using API.DTO.Knowing;
using API.DTO.MedicineType;
using API.DTO.Frequency;
using API.DTO.Instruction;

namespace API.Helpers
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            // API DTO to Entity
            CreateMap<KnowingForAddDTO, Knowing>();
            CreateMap<KnowingForEditDTO, Knowing>();
            CreateMap<FrequencyForAddDTO, Frequency>();
            CreateMap<FrequencyForEditDTO, Frequency>();
            CreateMap<InstructionForAddDTO, Instruction>();
            CreateMap<InstructionForEditDTO, Instruction>();
            CreateMap<OccupationForAddDTO, Occupation>();
            CreateMap<OccupationForEditDTO, Occupation>();
            CreateMap<MedicineTypeForAddDTO, MedicineType>();
            CreateMap<MedicineTypeForEditDTO, MedicineType>();

            // Entity to API DTO
            CreateMap<Knowing, KnowingForGetDTO>();
            CreateMap<Frequency, FrequencyForGetDTO>();
            CreateMap<Occupation, OccupationForGetDTO>();
            CreateMap<Instruction, InstructionForGetDTO>();
            CreateMap<MedicineType, MedicineTypeForGetDTO>();
        }

    }
}
