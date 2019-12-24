using API.DTO.UserDTO;
using Repository.IRepository;
using FluentValidation;

namespace API.Validator.UserValidator
{
    public class UserForAddDTOValidator : AbstractValidator<UserForAddDTO>

    {
        private readonly IUserRepository userRepository;
        public UserForAddDTOValidator(IUserRepository userRepository)
        {
            this.userRepository = userRepository;

            RuleFor(x => x.Name).NotEmpty().NotNull();
            RuleFor(x => x.Email).NotEmpty().NotNull().EmailAddress().MustAsync(async (email, cancellation) => {
                bool exists = await userRepository.GetUser(email).ConfigureAwait(true);
                return !exists;
            }).WithMessage("Email must be unique"); 
            RuleFor(x => x.Password).NotEmpty().NotNull();
        }

    }
}
