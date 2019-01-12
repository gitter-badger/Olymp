using Microsoft.EntityFrameworkCore;
using Olymp.Communication.Messages;

namespace Olymp.Persistence
{
    public partial class StoreContext : DbContext
    {
        public class User
        {
            public string Id { get; set; }
            public string UserName { get; set; }
            public string Password { get; set; }
            public bool IsAdmin { get; set; }
        }
    }
}