using WPFCleanArchitecture.Application.Interfaces;
using WPFCleanArchitecture.Application.UseCases;
using WPFCleanArchitecture.Domain.Entities;
using WPFCleanArchitecture.Domain.Interfaces;


namespace WPFCleanArchitecture.Application.UseCases
{
    public class RegisterUserUseCase: IRegisterUserUseCase
    {
        private readonly IUserRepository _userRepository;
        private readonly IEmailService _emailService;
        
        public RegisterUserUseCase(IUserRepository userRepository, IEmailService emailService)
        {
            _userRepository = userRepository;
            _emailService = emailService;
        }
        public User Execute(string name, string email)
        {
            var user = new User(name, email);
            var createdUser = _userRepository.CreateUser(user);
            _emailService.SendRegistrationEmail(createdUser);
            return createdUser;
        }

    }
}