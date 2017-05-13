using System.Collections.Generic;
using API.Context.Entities;

namespace API.Repository
{
    public interface IUserRepository
    {
        void CreateUser(User user);
        IList<User> GetUsers();
    }
}