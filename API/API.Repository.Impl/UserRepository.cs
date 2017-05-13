using System;
using System.Collections.Generic;
using API.Context.Entities;
using System.Linq;

namespace API.Repository.Impl
{
    public class UserRepository : IUserRepository
    {
        private API.Context.DbContext Context { get; set; }

        public UserRepository()
        {
            this.Context = new API.Context.DbContext();
        }

        public void CreateUser(User user)
        {
            this.Context.Users.Add(user);
            this.Context.SaveChanges();
        }

        public IList<User> GetUsers()
        {
            return this.Context.Users.ToList();
        }
    }
}