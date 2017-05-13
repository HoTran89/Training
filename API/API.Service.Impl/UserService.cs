using API.Service.DTO;
using API.Repository;
using API.Repository.Impl;
using API.Context.Entities;
using System.Collections.Generic;

namespace API.Service.Impl
{
    public class UserService : IUserService
    {
        public CreateUserResponse CreateUSer(CreateUserRequest request)
        {
            ValidationCreateUserRequest(request);
            IUserRepository userRepository = new UserRepository();

            User user = new User(request.UserName, request.PassWord);
            userRepository.CreateUser(user);
            CreateUserResponse response = new CreateUserResponse()
            {
                UserName = user.UserName
            };

            return response;
        }

        public IList<UserListItem> GetUsers()
        {
            IUserRepository userRepository = new UserRepository();
            IList<User> users = userRepository.GetUsers();

            IList<UserListItem> response = new List<UserListItem>();
            if (users.Count > 0)
            {
                foreach (var user in users)
                {
                    UserListItem item = new UserListItem()
                    {
                        UserName = user.UserName,
                        PassWord = user.PassWord
                    };

                    response.Add(item);
                }
            }
            return response;
        }

        private void ValidationCreateUserRequest(CreateUserRequest request)
        {
            if (string.IsNullOrWhiteSpace(request.UserName))
            {

            }

            if (string.IsNullOrWhiteSpace(request.PassWord))
            {

            }
        }
    }
}