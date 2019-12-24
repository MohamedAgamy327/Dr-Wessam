using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using API.DTO.Vendor;
using AutoMapper;
using Domain.Entities;
using Domain.Enums;
using Microsoft.AspNetCore.Mvc;
using Repository.IRepository;
using Repository.UnitOfWork;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VendorsController : ControllerBase
    {
        private readonly IMapper mapper;
        private readonly IUnitOfWork unitOfWork;
        private readonly IVendorRepository vendorRepository;

        public VendorsController(IMapper mapper, IUnitOfWork unitOfWork, IVendorRepository vendorRepository)
        {
            this.mapper = mapper;
            this.unitOfWork = unitOfWork;
            this.vendorRepository = vendorRepository;
        }

        [HttpPost]
        public async Task<IActionResult> Post(VendorForAddDTO model)
        {

            #region  business validation

            DepartmentEnum department = (DepartmentEnum)Enum.Parse(typeof(DepartmentEnum), model.Department);

            if(await vendorRepository.Get(model.Name, department).ConfigureAwait(true))
            {
                return BadRequest("This vendor already exists");
            }

            #endregion

            Vendor vendor = mapper.Map<Vendor>(model);
            await vendorRepository.Add(vendor).ConfigureAwait(true);
            await unitOfWork.CompleteAsync().ConfigureAwait(true);
            return Ok(mapper.Map<VendorForGetDTO>(await vendorRepository.Get(vendor.Id).ConfigureAwait(true)));
        }

        [HttpPut]
        public async Task<IActionResult> Put(VendorForEditDTO model)
        {
            #region  business validation

            DepartmentEnum department = (DepartmentEnum)Enum.Parse(typeof(DepartmentEnum), model.Department);

            if (await vendorRepository.Get(model.Id,model.Name, department).ConfigureAwait(true))
            {
                return BadRequest("This vendor already exists");
            }

            #endregion

            Vendor vendor = mapper.Map<Vendor>(model);
            vendorRepository.Edit(vendor);
            await unitOfWork.CompleteAsync().ConfigureAwait(true);
            return Ok(mapper.Map<VendorForGetDTO>(await vendorRepository.Get(vendor.Id).ConfigureAwait(true)));
        }

        [Route("{id:int}")]
        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {
            Vendor vendor = await vendorRepository.Get(id).ConfigureAwait(true);
            vendorRepository.Remove(vendor);
            await unitOfWork.CompleteAsync().ConfigureAwait(true);
            return Ok(mapper.Map<VendorForGetDTO>(vendor));
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(mapper.Map<List<VendorForGetDTO>>(await vendorRepository.Get().ConfigureAwait(true)));
        }
    }
}