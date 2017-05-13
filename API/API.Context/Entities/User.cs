using System;

namespace API.Context.Entities
{
    public class User
    {
        public Guid Id { get; set; }
        public string UserName { get; set; }
        public string PassWord { get; set; }

        public User()
        {
            this.Id = Guid.NewGuid();
        }

        public User(string userName, string passWord) : this()
        {
            this.UserName = userName;
            this.PassWord = passWord;
        }
    }
}
