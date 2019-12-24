using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using API.DTO.UserDTO;
using Domain.Entities;
using Repository.IRepository;
using Repository.UnitOfWork;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Utilities.Password;
using API.IHelpers;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsersController : Controller
    {
        private readonly IJWTManager jwtManager;
        private readonly IMapper mapper;
        private readonly IUserRepository userRepository;
        private readonly IUnitOfWork unitOfWork;

        public UsersController(IJWTManager jwtManager, IMapper mapper, IUserRepository userRepository, IUnitOfWork unitOfWork)
        {
            this.jwtManager = jwtManager;
            this.mapper = mapper;
            this.unitOfWork = unitOfWork;
            this.userRepository = userRepository;
        }

        [HttpPost]
        public async Task<IActionResult> Post(UserForAddDTO model)
        {
            SecurePassword.CreatePasswordHash(model.Password, out byte[] passwordHash, out byte[] passwordSalt);
            User user = mapper.Map<User>(model);
            user.PasswordHash = passwordHash;
            user.PasswordSalt = passwordSalt;

            await userRepository.Add(user).ConfigureAwait(true);
            await unitOfWork.CompleteAsync().ConfigureAwait(true);

            return Ok(mapper.Map<UserForGetDTO>(user));
        }

        [Authorize(Roles = "Admin")]
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            //var claimsIdentity = User.Identity as ClaimsIdentity;
            //var email = claimsIdentity.Claims.Where(c => c.Type == "Email").FirstOrDefault()?.Value;
            List<UserForGetDTO> users = mapper.Map<List<UserForGetDTO>>(await userRepository.GetUsers().ConfigureAwait(true));
            return Ok(users);
        }

        [Route("login")]
        [HttpPost]
        public async Task<IActionResult> Login(UserForLoginDTO model)
        {
            User user = await userRepository.Login(model.Email, model.Password).ConfigureAwait(true);
            if (user == null)
                return NotFound();

            return Ok(new { Token = jwtManager.GenerateToken(user) });
        }

    }
}