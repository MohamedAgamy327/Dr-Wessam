﻿using AutoMapper;
using Domain.Entities;
using API.DTO.Occupation;
using API.DTO.Knowing;
using API.DTO.MedicineType;
using API.DTO.Frequency;
using API.DTO.Instruction;
using API.DTO.Patient;
using API.DTO.Medicine;

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
            CreateMap<PatientForAddDTO, Patient>();
            CreateMap<PatientForEditDTO, Patient>();
            CreateMap<MedicineForAddDTO, Medicine>();
            CreateMap<MedicineForEditDTO, Medicine>();

            // Entity to API DTO
            CreateMap<Knowing, KnowingForGetDTO>();
            CreateMap<Frequency, FrequencyForGetDTO>();
            CreateMap<Occupation, OccupationForGetDTO>();
            CreateMap<Instruction, InstructionForGetDTO>();
            CreateMap<MedicineType, MedicineTypeForGetDTO>();
            CreateMap<Patient, PatientForGetDTO>()
                   .ForMember(dest => dest.HusbandOccupation, opt => opt.MapFrom(src => src.HusbandOccupation != null ? src.HusbandOccupation.Name : null))
                   .ForMember(dest => dest.Occupation, opt => opt.MapFrom(src => src.Occupation != null ? src.Occupation.Name : null))
                   .ForMember(dest => dest.Knowing, opt => opt.MapFrom(src => src.Knowing != null ? src.Knowing.Name : null));
            CreateMap<Medicine, MedicineForGetDTO>()
                   .ForMember(dest => dest.Frequency, opt => opt.MapFrom(src => src.Frequency != null ? src.Frequency.EnglishName : null))
                   .ForMember(dest => dest.MedicineType, opt => opt.MapFrom(src => src.MedicineType != null ? src.MedicineType.Name : null));
        }

    }
}
