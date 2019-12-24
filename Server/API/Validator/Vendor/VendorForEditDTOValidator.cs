using API.DTO.Vendor;
using Domain.Enums;
using FluentValidation;

namespace API.Validator.Vendor
{
    public class VendorForEditDTOValidator : AbstractValidator<VendorForEditDTO>
    {
        public VendorForEditDTOValidator()
        {
            RuleFor(x => x.Id).NotNull().NotEmpty();
            RuleFor(x => x.Name).NotEmpty().NotNull();
            RuleFor(x => x.Department).NotEmpty().NotNull().IsEnumName(typeof(DepartmentEnum));
        }
    }
}
