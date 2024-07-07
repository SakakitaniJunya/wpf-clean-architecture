
using WPFCleanArchitecture.Domain.Entities;

namespace WPFCleanArchitecture.Application.UseCases
{
    public interface IRegisterUserUseCase
    {
        // please coding copilot
        public User Execute(string name, string email);
    }
}
