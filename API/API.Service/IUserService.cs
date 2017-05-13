using API.Service.DTO;

namespace API.Service
{
    public interface IUserService
    {
        CreateUserResponse CreateUSer(CreateUserRequest request);
        System.Collections.Generic.IList<UserListItem> GetUsers();
    }
}
