using WPFCleanArchitecture.Domain.Entities;

namespace WPFCleanArchitecture.Application.Interfaces
{
    public interface IEmailService
    {
        void SendRegistrationEmail(User user);
    }
}