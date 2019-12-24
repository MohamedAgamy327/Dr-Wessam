namespace API.DTO.UserDTO
{
    public class UserForLoginDTO
    {
        private string _email;
        public string Email { get { return _email.ToLower(); } set { _email = value; } }
        public string Password { get; set; }
    }
}
