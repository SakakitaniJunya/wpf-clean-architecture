
using WPFCleanArchitecture.Domain.Entities;

namespace WPFCleanArchitecture.Domain.Interfaces
{

   public interface IUserRepository
   {
      User CreateUser(User user);
      User FindUserById(int id);
   }

}