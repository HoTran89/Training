using API.Context.Entities;
using System.Data.Entity;

namespace API.Context
{
    public class DbContext : System.Data.Entity.DbContext
    {
        public DbContext() : base("Default")
        {

        }

        public DbSet<User> Users { get; set; }

    }
}