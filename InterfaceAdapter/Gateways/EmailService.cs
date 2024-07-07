using WPFCleanArchitecture.Domain.Interfaces;
using WPFCleanArchitecture.Domain.Entities;
using WPFCleanArchitecture.Application.Interfaces;
using WPFCleanArchitecture.InterfaceAdapter.Interfaces;


namespace WPFCleanArchitecture.InterfaceAdapter.Gateways
{
    public class EmailService : IEmailService
    {
        private readonly IEmailGateway _emailGateway;

        public EmailService(IEmailGateway emailGateway)
        {
            _emailGateway = emailGateway;
        }

        public void SendRegistrationEmail(User user)
        {
            string emailContent = $"Hello {user.Name}, welcome to our service!";
            _emailGateway.SendEmail(user.Email, "Registration Confirmation", emailContent);
        }
    }
}