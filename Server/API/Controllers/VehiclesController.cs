using System.Collections.Generic;
using System.Threading.Tasks;
using API.DTO.Vehicle;
using AutoMapper;
using Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using Repository.IRepository;
using Repository.UnitOfWork;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VehiclesController : ControllerBase
    {
        private readonly IMapper mapper;
        private readonly IUnitOfWork unitOfWork;
        private readonly IVehicleRepository vehicleRepository;

        public VehiclesController(IMapper mapper, IUnitOfWork unitOfWork, IVehicleRepository vehicleRepository)
        {
            this.mapper = mapper;
            this.unitOfWork = unitOfWork;
            this.vehicleRepository = vehicleRepository;
        }

        [HttpPost]
        public async Task<IActionResult> Post(VehicleForAddDTO model)
        {

            #region  business validation



            #endregion

            Vehicle vehicle = mapper.Map<Vehicle>(model);
            await vehicleRepository.Add(vehicle).ConfigureAwait(true);
            await unitOfWork.CompleteAsync().ConfigureAwait(true);
            return Ok(mapper.Map<VehicleForGetDTO>(await vehicleRepository.Get(vehicle.Id).ConfigureAwait(true)));
        }

        [HttpPut]
        public async Task<IActionResult> Put(VehicleForEditDTO model)
        {
            #region  business validation



            #endregion

            Vehicle vehicle = mapper.Map<Vehicle>(model);
            vehicleRepository.Edit(vehicle);
            await unitOfWork.CompleteAsync().ConfigureAwait(true);
            return Ok(mapper.Map<VehicleForGetDTO>(await vehicleRepository.Get(vehicle.Id).ConfigureAwait(true)));
        }

        [Route("{id:int}")]
        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {
            Vehicle vehicle = await vehicleRepository.Get(id).ConfigureAwait(true);
            vehicleRepository.Remove(vehicle);
            await unitOfWork.CompleteAsync().ConfigureAwait(true);
            return Ok(mapper.Map<VehicleForGetDTO>(vehicle));
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(mapper.Map<List<VehicleForGetDTO>>(await vehicleRepository.Get().ConfigureAwait(true)));
        }
    }
}