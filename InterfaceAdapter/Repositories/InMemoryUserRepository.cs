
using System.Collections.Generic;
using System.Linq;
using WPFCleanArchitecture.Domain.Entities;
using WPFCleanArchitecture.Domain.Interfaces;

namespace WPFCleanArchitecture.InterfaceAdapter.Repositories
{
 public class InMemoryUserRepository : IUserRepository
    {
        private readonly List<User> _users;
        private int _currentId;

        public InMemoryUserRepository()
        {
            _users = new List<User>();
            _currentId = 1;
        }

        public User CreateUser(User user)
        {
            user.Id = _currentId++;
            _users.Add(user);
            return user;
        }

        public User FindUserById(int id)
        {
            return _users.FirstOrDefault(u => u.Id == id);
        }
    }
}