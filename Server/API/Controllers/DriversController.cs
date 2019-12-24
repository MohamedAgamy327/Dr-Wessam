using System.Collections.Generic;
using System.Threading.Tasks;
using API.DTO.Driver;
using AutoMapper;
using Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using Repository.IRepository;
using Repository.UnitOfWork;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DriversController : ControllerBase
    {
        private readonly IMapper mapper;
        private readonly IUnitOfWork unitOfWork;
        private readonly IDriverRepository driverRepository;

        public DriversController(IMapper mapper, IUnitOfWork unitOfWork, IDriverRepository driverRepository)
        {
            this.mapper = mapper;
            this.unitOfWork = unitOfWork;
            this.driverRepository = driverRepository;
        }

        [HttpPost]
        public async Task<IActionResult> Post(DriverForAddDTO model)
        {

            #region  business validation



            #endregion

            Driver driver = mapper.Map<Driver>(model);
            await driverRepository.Add(driver).ConfigureAwait(true);
            await unitOfWork.CompleteAsync().ConfigureAwait(true);
            return Ok(mapper.Map<DriverForGetDTO>(await driverRepository.Get(driver.Id).ConfigureAwait(true)));
        }

        [HttpPut]
        public async Task<IActionResult> Put(DriverForEditDTO model)
        {
            #region  business validation



            #endregion

            Driver driver = mapper.Map<Driver>(model);
            driverRepository.Edit(driver);
            await unitOfWork.CompleteAsync().ConfigureAwait(true);
            return Ok(mapper.Map<DriverForGetDTO>(await driverRepository.Get(driver.Id).ConfigureAwait(true)));
        }

        [Route("{id:int}")]
        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {
            Driver driver = await driverRepository.Get(id).ConfigureAwait(true);
            driverRepository.Remove(driver);
            await unitOfWork.CompleteAsync().ConfigureAwait(true);
            return Ok(mapper.Map<DriverForGetDTO>(driver));
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(mapper.Map<List<DriverForGetDTO>>(await driverRepository.Get().ConfigureAwait(true)));
        }
    }
}