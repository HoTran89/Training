using API.Service;
using API.Service.DTO;
using API.Service.Impl;
using System.Collections.Generic;
using System.Web.Http;

namespace API.Controllers
{

    [RoutePrefix("api/users")]
    public class UsersController : ApiController
    {
        [HttpPost]
        [Route("")]
        public CreateUserResponse CreateUSer([FromBody] CreateUserRequest request)
        {
            IUserService userService = new UserService();
            return userService.CreateUSer(request);
        }

        [HttpGet]
        [Route("")]
        public IList<UserListItem> GetUsers()
        {
            IUserService userService = new UserService();
            return userService.GetUsers();
        }
    }
}