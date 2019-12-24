using API.DTO.Vendor;
using Domain.Enums;
using FluentValidation;

namespace API.Validator.Vendor
{
    public class VendorForAddDTOValidator : AbstractValidator<VendorForAddDTO>
    {
        public VendorForAddDTOValidator()
        {
            RuleFor(x => x.Name).NotEmpty().NotNull();
            RuleFor(x => x.Department).NotEmpty().NotNull().IsEnumName(typeof(DepartmentEnum));
        }
    }
}
